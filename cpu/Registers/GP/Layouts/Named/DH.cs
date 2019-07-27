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
        public struct DH : IGpReg8<DH>
        {
            [FieldOffset(0)]
            public byte dh;

            public const string Name = nameof(DH);

            public const GpRegId Id = GpRegId.dh;          

            [MethodImpl(Inline)]
            public static implicit operator byte(DH src)
                => src.dh;

            [MethodImpl(Inline)]
            public static implicit operator DH(byte src)
                => new DH(src);
            

            [MethodImpl(Inline)]
            public DH(byte src)
                => this.dh = src;

            GpRegId IGpReg.Id 
                => Id; 
        }
    }
}