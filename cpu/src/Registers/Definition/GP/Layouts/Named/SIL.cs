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
        [StructLayout(LayoutKind.Explicit)]
        public struct SIL : IGpReg8<SIL>
        {
            [FieldOffset(0)]
            public byte sil;

            public const GpRegId Id = GpRegId.sil;            

            [MethodImpl(Inline)]
            public static implicit operator byte(SIL src)
                => src.sil;

            [MethodImpl(Inline)]
            public static implicit operator SIL(byte src)
                => new SIL(src);

            [MethodImpl(Inline)]
            public SIL(byte src)
                => sil = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}