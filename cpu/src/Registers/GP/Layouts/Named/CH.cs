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
        [StructLayout(LayoutKind.Explicit)]
        public struct CH : IGpReg8<CH>
        {
            [FieldOffset(0)]
            public byte ch;

            public const GpRegId Id = GpRegId.ch;            

            [MethodImpl(Inline)]
            public static implicit operator byte(CH src)
                => src.ch;

            [MethodImpl(Inline)]
            public static implicit operator CH(byte src)
                => new CH(src);

            [MethodImpl(Inline)]
            public CH(byte src)
                => ch = src;

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}