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
        public struct RCX : IGpReg64<RCX>
        {
            [FieldOffset(0)]
            public ulong rcx;

            [FieldOffset(0)]
            public ECX ecx;

            [FieldOffset(0)]
            public CX cx;

            [FieldOffset(0)]
            public CL cl;

            [FieldOffset(1)]
            public CH ch;

            public const GpRegId Id = GpRegId.rcx;

            [MethodImpl(Inline)]
            public static implicit operator ulong(RCX src)
                => src.rcx;

            [MethodImpl(Inline)]
            public static implicit operator RCX(ulong src)
                => new RCX(src);

            [MethodImpl(Inline)]
            public RCX(ulong src)
                : this()
            {
                rcx = src;
            }

            byte IGpReg64<RCX>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => cl; 
 
                [MethodImpl(Inline)]
                set => cl = value;
            }
            
            ushort IGpReg64<RCX>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => cx; 
 
                [MethodImpl(Inline)]
                set => cx = value;
            }

            uint IGpReg64<RCX>.Lo32
            { 
                [MethodImpl(Inline)]
                get => ecx; 
 
                [MethodImpl(Inline)]
                set => ecx = value;
            }
  
            GpRegId IGpReg.Id 
                => Id;
 
        }
    }
}