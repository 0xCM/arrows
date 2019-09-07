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
        public struct DI : IGpReg16<DI>
        {

            [FieldOffset(0)]
            public ushort di;

            [FieldOffset(0)]
            public DIL dil;

            public const GpRegId Id = GpRegId.edi;          

            [MethodImpl(Inline)]
            public static implicit operator ushort(DI src)
                => src.di;

            [MethodImpl(Inline)]
            public static implicit operator DI(ushort src)
                => new DI(src);

            [MethodImpl(Inline)]
            public DI(ushort src)
                : this()
            {
                this.di = src;
            }

            public ushort Content 
            { 
                [MethodImpl(Inline)]
                get => di; 

                [MethodImpl(Inline)]
                set => di = value;
            }

            byte IGpReg16<DI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => dil; 
 
                [MethodImpl(Inline)]
                set => dil = value;
            }
            
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}