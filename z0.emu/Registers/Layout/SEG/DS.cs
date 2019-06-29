//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class Registers
    {
        /// <summary>
        /// Data segment register - pointer to data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct DS : ICpuReg16
        {
            [MethodImpl(Inline)]
            public static implicit operator ushort(DS src)
                => src.ds;

            [MethodImpl(Inline)]
            public static implicit operator DS(ushort src)
                => new DS(src);

            [MethodImpl(Inline)]
            public DS(ushort src)
                => ds = src;
            
            [FieldOffset(0)]
            public ushort ds;


        }
    }
}