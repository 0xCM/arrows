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
        /// <summary>
        /// Accumulator for operands and results data
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct EAX : IGpReg32<EAX>
        {
            [FieldOffset(0)]
            public uint eax;

            [FieldOffset(0)]
            public AX ax;

            [FieldOffset(0)]
            public AL al;

            [FieldOffset(1)]
            public AH ah;

            public const GpRegId Id = GpRegId.eax;          


            [MethodImpl(Inline)]
            public static implicit operator uint(EAX src)
                => src.eax;

            [MethodImpl(Inline)]
            public static implicit operator EAX(uint src)
                => new EAX(src);

            [MethodImpl(Inline)]
            public EAX(uint src)
                : this()
            {
                this.eax = src;
            }

            public uint Content 
            { 
                [MethodImpl(Inline)]
                get => eax; 

                [MethodImpl(Inline)]
                set => eax = value;
            }

            byte IGpReg32<EAX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => al; 
 
                [MethodImpl(Inline)]
                set => al = value;
            }

            
            ushort IGpReg32<EAX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => ax; 
 
                [MethodImpl(Inline)]
                set => ax = value;
            }
 
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}