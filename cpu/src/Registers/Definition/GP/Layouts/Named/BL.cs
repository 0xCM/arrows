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
        public struct BL : IGpReg8<BL>
        {
            [FieldOffset(0)]
            public byte bl;

            public const GpRegId Id = GpRegId.bl;            

            [MethodImpl(Inline)]
            public static implicit operator byte(BL src)
                => src.bl;

            [MethodImpl(Inline)]
            public static implicit operator BL(byte src)
                => new BL(src);

            [MethodImpl(Inline)]
            public BL(byte src)
                => bl = src;
                
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}