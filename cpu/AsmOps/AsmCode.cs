//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Encapsulates a block of decoded assembly
    /// </summary>
    public readonly ref struct AsmCode
    {
        [MethodImpl(Inline)]
        public static implicit operator AsmCode(in ReadOnlySpan<byte> Bytes)
            => new AsmCode(in Bytes);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<byte>(in AsmCode code)
            => code.Bytes;

        [MethodImpl(Inline)]
        public AsmCode(in ReadOnlySpan<byte> Bytes)
        {
            this.Bytes = Bytes;
        }

        /// <summary>
        /// Specifies the encoded asm bytes
        /// </summary>
        public readonly ReadOnlySpan<byte> Bytes;

        /// <summary>
        /// Specfies the length of the encoded bytes
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        /// <summary>
        /// Retruns a pointer to the endoded bytes
        /// </summary>
        public IntPtr Pointer
        {
            [MethodImpl(Inline)]
            get => GetPointer();
        }

        [MethodImpl(Inline)]
        unsafe IntPtr GetPointer()
        {
            var pCode = (IntPtr)As.refptr(ref As.asRef(in Bytes[0]));
            if (!VirtualProtectEx(ProcHandle, pCode, (UIntPtr)Length, 0x40 /* EXECUTE_READWRITE */, out uint _))
                throw new Exception("VirtualProtectEx failed");     
            return pCode;
        }

        /// <summary>
        /// Creates a delegate to execute the encapsulated code
        /// </summary>
        /// <typeparam name="T">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public T CreateDelegate<T>()
            where T : Delegate        
                => Marshal.GetDelegateForFunctionPointer<T>(Pointer);

        /// <summary>
        /// The handle for the current process
        /// </summary>
        static readonly IntPtr ProcHandle = System.Diagnostics.Process.GetCurrentProcess().Handle;

        /// <summary>
        /// Windows API that applies memory protection attributes
        /// </summary>
        [DllImport("kernel32.dll")]
        static extern bool VirtualProtectEx(IntPtr hProc, IntPtr pCode, UIntPtr codelen, uint flags, out uint oldFlags); 
    }

}