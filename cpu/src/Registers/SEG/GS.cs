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
        /// Extra data segment register 3/3 - pointer to extra data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct GS : ICpuReg16
        {            
            [FieldOffset(0)]
            public ushort gs;

            [MethodImpl(Inline)]
            public static implicit operator ushort(GS src)
                => src.gs;

            [MethodImpl(Inline)]
            public static implicit operator GS(ushort src)
                => new GS(src);

            [MethodImpl(Inline)]
            public GS(ushort src)
                => gs = src;            
        }
    }
}