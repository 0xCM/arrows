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
        public struct SI : IGpReg16<SI>
        {
            [FieldOffset(0)]
            public ushort si;

            [FieldOffset(0)]
            public SIL sil;

            public const GpRegId Id = GpRegId.si;            

            [MethodImpl(Inline)]
            public static implicit operator ushort(SI src)
                => src.si;

            [MethodImpl(Inline)]
            public static implicit operator SI(ushort src)
                => new SI(src);

            [MethodImpl(Inline)]
            public SI(ushort src)
                : this()
            {
                this.si = src;
            }

            byte IGpReg16<SI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => sil; 
 
                [MethodImpl(Inline)]
                set => sil = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
       }
    }
}