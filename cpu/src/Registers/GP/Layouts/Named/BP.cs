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
        public struct BP : IGpReg16<BP>
        {
            [FieldOffset(0)]
            public ushort bp;

            [FieldOffset(0)]
            public BPL bpl;

            public const GpRegId Id = GpRegId.bp;

            [MethodImpl(Inline)]
            public static implicit operator ushort(BP src)
                => src.bp;

            [MethodImpl(Inline)]
            public static implicit operator BP(ushort src)
                => new BP(src);


            [MethodImpl(Inline)]
            public BP(ushort src)
                : this()
            {
                bp = src;
            }

            byte IGpReg16<BP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => bpl; 
 
                [MethodImpl(Inline)]
                set => bpl = value;
            }
            
 
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}