//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using Z0.Asm;

    using static zfunc;
    
    partial class Registers
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct EDI : IGpReg32<EDI>
        {

            [FieldOffset(0)]
            public uint edi;

            [FieldOffset(0)]
            public DI di;

            [FieldOffset(0)]
            public DIL dil;

            public const GpRegId Id = GpRegId.edi;          

            [MethodImpl(Inline)]
            public static implicit operator uint(EDI src)
                => src.edi;

            [MethodImpl(Inline)]
            public static implicit operator EDI(uint src)
                => new EDI(src);

            [MethodImpl(Inline)]
            public EDI(uint src)
                : this()
            {
                this.edi = src;
            }

            public uint Content 
            { 
                [MethodImpl(Inline)]
                get => edi; 

                [MethodImpl(Inline)]
                set => edi = value;
            }

            byte IGpReg32<EDI>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => dil; 
 
                [MethodImpl(Inline)]
                set => dil = value;
            }
            
            ushort IGpReg32<EDI>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => di; 
 
                [MethodImpl(Inline)]
                set => di = value;
            }

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}