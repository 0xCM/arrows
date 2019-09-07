//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class Registers
    {
        /// <summary>
        /// Extra data segment register 1/3 - pointer to extra data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct ES : ICpuReg16
        {
            [FieldOffset(0)]
            public ushort es;

            [MethodImpl(Inline)]
            public static implicit operator ushort(ES src)
                => src.es;

            [MethodImpl(Inline)]
            public static implicit operator ES(ushort src)
                => new ES(src);

            [MethodImpl(Inline)]
            public ES(ushort src)
                => es = src;            
        }
    }
}