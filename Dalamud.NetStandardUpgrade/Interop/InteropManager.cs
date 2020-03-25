using SharedMemory;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Dalamud.NetStandardUpgrade.Interop
{
    public static class InteropManager
    {
        /**
         * Header is laid out as follows:
         * 
         * 0       2       4
         * +---------------+
         * |Src|Ack|Flt|Exc|
         * +---------------+
         */
        public static BufferReadWrite Memory { get; set; }

        public const int BuffersPerPlugin = 10;
        public const int RequestBufferSize = 256;

        /// <summary>
        /// Request a method from Dalamud.
        /// </summary>
        public static Task<T> Request<T>(string method, params object[] args) where T : struct
        {
            if (method == null)
                throw new ArgumentNullException(nameof(method));

            var request = new InteropMethodRequest
            {
                Method = method,
                Parameters = args,
            };

            int i = 0;
            Memory.Read(out InteropHeader header, i);
            while (!header.Acknowledged)
            {
                i += RequestBufferSize;
                Memory.Read(out header, i);
            }

            var sendHeader = new InteropHeader
            {
                Source = DataSource.Net21,
                Acknowledged = false,
                Faulted = false,
                Exception = RemoteException.None,
            };
            Memory.Write(ref sendHeader);
            Memory.Write(ref request, i + 8);
            while (sendHeader.Source != DataSource.Net20)
            {
                Memory.Read(out header, i);
            }
            if (header.Faulted)
            {
                Memory.Read(out IntPtr messagePtr, i + 8);
                string message = Marshal.PtrToStringAuto(messagePtr);
                throw header.Exception switch
                {
                    RemoteException.ArgumentException => new ArgumentException(message),
                    RemoteException.ArgumentNullException => new ArgumentNullException(message),
                    _ => new Exception(message),
                };
            }

            Memory.Read(out T response, i + 8);
            return Task.FromResult(response);
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
    }
}
