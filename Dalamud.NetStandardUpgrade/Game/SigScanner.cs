using System;
using System.Diagnostics;

namespace Dalamud.Game
{
    public sealed class SigScanner : IDisposable
    {
        /// <summary>
        /// If the search on this module is performed on a copy.
        /// </summary>
        public bool IsCopy { get; private set; }

        /// <summary>
        /// If the ProcessModule is 32-bit.
        /// </summary>
        public bool Is32BitProcess { get; }

        /// <summary>
        /// The base address of the search area. When copied, this will be the address of the copy.
        /// </summary>
        public IntPtr SearchBase => throw new NotImplementedException();

        /// <summary>
        /// The base address of the .text section search area.
        /// </summary>
        public IntPtr TextSectionBase => new IntPtr(SearchBase.ToInt64() + TextSectionOffset);
        /// <summary>
        /// The offset of the .text section from the base of the module.
        /// </summary>
        public long TextSectionOffset { get; private set; }
        /// <summary>
        /// The size of the text section.
        /// </summary>
        public int TextSectionSize { get; private set; }

        /// <summary>
        /// The base address of the .data section search area.
        /// </summary>
        public IntPtr DataSectionBase => new IntPtr(SearchBase.ToInt64() + DataSectionOffset);
        /// <summary>
        /// The offset of the .data section from the base of the module.
        /// </summary>
        public long DataSectionOffset { get; private set; }
        /// <summary>
        /// The size of the .data section.
        /// </summary>
        public int DataSectionSize { get; private set; }

        /// <summary>
        /// The ProcessModule on which the search is performed.
        /// </summary>
        public ProcessModule Module { get; }

        /// <summary>
        /// Free the memory of the copied module search area on object disposal, if applicable.
        /// </summary>
        public void Dispose() {}

        /// <summary>
        /// Scan for a byte signature in the .text section.
        /// </summary>
        /// <param name="signature">The signature.</param>
        /// <returns>The real offset of the found signature.</returns>
        public IntPtr ScanText(string signature)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Scan for a .data address using a .text function.
        /// This is intended to be used with IDA sigs.
        /// Place your cursor on the line calling a static address, and create and IDA sig.
        /// </summary>
        /// <param name="signature">The signature of the function using the data.</param>
        /// <param name="offset">The offset from function start of the instruction using the data.</param>
        /// <returns>An IntPtr to the static memory location.</returns>
        public IntPtr GetStaticAddressFromSig(string signature, int offset)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Scan for a byte signature in the .data section.
        /// </summary>
        /// <param name="signature">The signature.</param>
        /// <returns>The real offset of the found signature.</returns>
        public IntPtr ScanData(string signature)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Scan for a byte signature in the whole module search area.
        /// </summary>
        /// <param name="signature">The signature.</param>
        /// <returns>The real offset of the found signature.</returns>
        public IntPtr ScanModule(string signature)
        {
            throw new NotImplementedException();
        }

        public IntPtr Scan(IntPtr baseAddress, int size, string signature)
        {
            throw new NotImplementedException();
        }

        public IntPtr ResolveRelativeAddress(IntPtr nextInstAddr, int relOffset)
        {
            throw new NotImplementedException();
        }
    }
}
