//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static partial class AsmOps
    {
     
        static AsmOps()
        {

                            
            add8iBytes.Liberate();   
            add8uBytes.Liberate();   
            add16iBytes.Liberate();   
            add16uBytes.Liberate();   
            add32iBytes.Liberate();   
            add32uBytes.Liberate();   
            add64iBytes.Liberate();   
            add64uBytes.Liberate();   
            add32fBytes.Liberate();   
            add64fBytes.Liberate();   

            negate8iBytes.Liberate();   
            negate8uBytes.Liberate();   
            negate16iBytes.Liberate();   
            negate16uBytes.Liberate();   
            negate32iBytes.Liberate();   
            negate32uBytes.Liberate();   
            negate64iBytes.Liberate();   
            negate64uBytes.Liberate();   
            negate32fBytes.Liberate();   
            negate64fBytes.Liberate();               
            rand32uBytes.Liberate();
        }

        readonly struct RandHost<T>
            where T : struct
        {
            
            public static readonly RandHost<T> TheOnly = default;

            static readonly AsmEmitter<T> Reified = AsmCode.FromBytes<T>(rand32uBytes).CreateEmitter();
            
            public AsmEmitter<T> Operator
                => Reified;
        }

        public static uint Rand()
            => RandHost<uint>.TheOnly.Operator();

        /// <summary>
        /// The handle for the current process
        /// </summary>
        static readonly IntPtr ProcHandle = System.Diagnostics.Process.GetCurrentProcess().Handle;

        public unsafe static IntPtr Liberate(this ReadOnlySpan<byte> src)
        {
            var pCode = (IntPtr)Z0.As.refptr(ref Z0.As.asRef(in src[0]));
            var start = (ulong)pCode;
            var end = start + (ulong)src.Length;            
            var msg = appMsg($"Liberating the memory range [{start.FormatHex(false)},{end.FormatHex(false)}] ({src.Length} bytes) for execution", SeverityLevel.Babble);
            print(msg);
            
            if (!OS.VirtualProtectEx(ProcHandle, pCode, (UIntPtr)src.Length, 0x40, out uint _))
                throw new Exception("VirtualProtectEx failed");     
            return pCode;
        }

        public unsafe static IntPtr Liberate(this byte[] src)
        {

            var pCode = (IntPtr)Z0.As.refptr(ref src[0]);
            if (!OS.VirtualProtectEx(ProcHandle, pCode, (UIntPtr)src.Length, 0x40, out uint _))
                throw new Exception("VirtualProtectEx failed");     
            return pCode;

        }

   }

}