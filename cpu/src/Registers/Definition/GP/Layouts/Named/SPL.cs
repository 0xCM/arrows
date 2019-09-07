//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using Z0.Asm;
    
    using static zfunc;
        
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct SPL : IGpReg8<SPL>
        {
            [FieldOffset(0)]
            public byte spl;

            public const GpRegId Id = GpRegId.spl;            

            [MethodImpl(Inline)]
            public static implicit operator byte(SPL src)
                => src.spl;

            [MethodImpl(Inline)]
            public static implicit operator SPL(byte src)
                => new SPL(src);

            [MethodImpl(Inline)]
            public SPL(byte src)
                =>spl = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}