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
        public struct ECX : IGpReg32<ECX>
        {
            [FieldOffset(0)]
            public uint ecx;

            [FieldOffset(0)]
            public CX cx;

            [FieldOffset(0)]
            public CL cl;

            [FieldOffset(1)]
            public CH ch;

            public const GpRegId Id = GpRegId.ecx;          

            [MethodImpl(Inline)]
            public static implicit operator uint(ECX src)
                => src.ecx;

            [MethodImpl(Inline)]
            public static implicit operator ECX(uint src)
                => new ECX(src);

            [MethodImpl(Inline)]
            public ECX(uint src)
                : this()
            {
                this.ecx = src;
            }

            public uint Content 
            { 
                [MethodImpl(Inline)]
                get => ecx; 

                [MethodImpl(Inline)]
                set => ecx = value;
            }

            byte IGpReg32<ECX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => cl; 
 
                [MethodImpl(Inline)]
                set => cl = value;
            }
            
            ushort IGpReg32<ECX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => cx; 
 
                [MethodImpl(Inline)]
                set => cx = value;
            }
  
            GpRegId IGpReg.Id 
                => Id;
        }
    }
}