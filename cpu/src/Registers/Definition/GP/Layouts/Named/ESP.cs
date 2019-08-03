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
        public struct ESP : IGpReg32<ESP>
        {
            [FieldOffset(0)]
            public uint esp;

            [FieldOffset(0)]
            public SP sp;

            [FieldOffset(0)]
            public SPL spl;

            public const GpRegId Id = GpRegId.esp;

            [MethodImpl(Inline)]
            public static implicit operator uint(ESP src)
                => src.esp;

            [MethodImpl(Inline)]
            public static implicit operator ESP(uint src)
                => new ESP(src);

            [MethodImpl(Inline)]
            public ESP(uint src)
                : this()
            {
                esp = src;
            }

            byte IGpReg32<ESP>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => spl; 
 
                [MethodImpl(Inline)]
                set => spl = value;
            }
            
            ushort IGpReg32<ESP>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => sp; 
 
                [MethodImpl(Inline)]
                set => sp = value;
            }

            GpRegId IGpReg.Id 
                => Id;
        }
    }
}