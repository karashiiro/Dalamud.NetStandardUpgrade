using Dalamud.Plugin;
using SharedMemory;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Dalamud.NetStandardUpgradePlugin
{
    public class NetStandardUpgradePlugin : IDalamudPlugin
    {
        public string Name => "NetStandardUpgradePlugin";

        public const int RequestBufferSize = 256;

        private string NetStandardUpgrader { get => Path.Combine(Environment.CurrentDirectory, "NetStandardUpgrade.exe"); }

        private DalamudPluginInterface pluginInterface;
        private Process netStandardUpgrader;
        private BufferReadWrite memory;

        private Task runningTask;

        public void Initialize(DalamudPluginInterface pluginInterface)
        {
            this.pluginInterface = pluginInterface;
            this.netStandardUpgrader = Process.Start(NetStandardUpgrader);
            this.memory = new BufferReadWrite("DalamudNetStandardUpgrade");

            this.runningTask = AcceptRequests();
        }

        private Task AcceptRequests()
        {
            int i = 0;
            while (true)
            {
                memory.Read(out InteropHeader header, i);
                if (header.Acknowledged)
                {
                    i += RequestBufferSize;
                    continue;
                }
                header.Source = DataSource.Net20;
                header.Acknowledged = true;

                memory.Read(out InteropMethodRequest request, i + 8);
                string nspace = request.Method.Substring(0, request.Method.LastIndexOf("."));
                string justMethod = request.Method.Substring(request.Method.LastIndexOf("." + 1));
                Type requestedType = typeof(Dalamud).Assembly.GetType(nspace);
                MethodInfo requestedMethod = requestedType.GetMethod(justMethod);
                object returnValue;
                try
                {
                    returnValue = requestedMethod.Invoke(this.pluginInterface, request.Parameters);
                }
                catch (Exception e)
                {
                    header.Faulted = true;
                    if (e is ArgumentException)
                        header.Exception = RemoteException.ArgumentException;
                    else if (e is ArgumentNullException)
                        header.Exception = RemoteException.ArgumentNullException;
                    char[] message = e.Message.ToCharArray();
                    message.Append((char)0);
                    memory.Write(message, i + 8);
                    continue;
                }

                byte[] interopResponse;
                var returnType = requestedMethod.ReturnType;
                if (!returnType.IsValueType || returnType.IsEnum)
                {
                    // Reference types crash, I guess
                    continue;
                }
                else
                {
                    // Value type
                    interopResponse = GetBytes(returnValue);
                }
                memory.Write(interopResponse, i + 8);
            }
        }

        // In classic dev fashion, copying off SO https://stackoverflow.com/a/3278956
        private byte[] GetBytes(object obj)
        {
            int size = Marshal.SizeOf(obj);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        private enum DataSource : byte
        {
            Net20,
            Net21,
        }

        private enum RemoteException : byte
        {
            None,
            ArgumentException,
            ArgumentNullException,
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct InteropHeader
        {
            [FieldOffset(0x00)] public DataSource Source;
            [FieldOffset(0x01)] public bool Acknowledged;
            [FieldOffset(0x02)] public bool Faulted;
            [FieldOffset(0x03)] public RemoteException Exception;
        }

        private struct InteropMethodRequest
        {
            public string Method;
            public object[] Parameters;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.runningTask.Dispose();
                    this.memory.Close();
                    this.memory.Dispose();
                    this.netStandardUpgrader.Dispose();
                    this.pluginInterface.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
