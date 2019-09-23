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
    using static As;

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

            Add128Host.Init();
        }

        readonly struct RandHost<T>
            where T : unmanaged
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

        unsafe static IntPtr Liberate(this ReadOnlySpan<byte> src)
            => OS.Liberate(src);
   }

}