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
        public struct DIL : IGpReg8<DIL>
        {
            [FieldOffset(0)]
            public byte dil;

            public const GpRegId Id = GpRegId.dil;            

            [MethodImpl(Inline)]
            public static implicit operator byte(DIL src)
                => src.dil;

            [MethodImpl(Inline)]
            public static implicit operator DIL(byte src)
                => new DIL(src);

            [MethodImpl(Inline)]
            public DIL(byte src)
                =>dil = src;


            GpRegId IGpReg.Id 
                => Id;
        }
    }
}