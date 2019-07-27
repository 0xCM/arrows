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
    using static BitWidth;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct DL : IGpReg8<DL>
        {
            public const GpRegId Id = GpRegId.dl;          


            [MethodImpl(Inline)]
            public static implicit operator byte(DL src)
                => src.dl;

            [MethodImpl(Inline)]
            public static implicit operator DL(byte src)
                => new DL(src);
            

            [MethodImpl(Inline)]
            public DL(byte src)
                => this.dl = src;

            [FieldOffset(0)]
            public byte dl;

            GpRegId IGpReg.Id 
                => Id;
 
        }
    }
}