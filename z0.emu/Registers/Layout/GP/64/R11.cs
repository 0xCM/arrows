//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20111
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
        public struct R11 : IGpReg64<R11>
        {
            public const int BitWidth = 64;        

            public const int ByteCount = 11;

            public const string Name = nameof(R11);

            public const GpRegId Id = GpRegId.r11;            

            [FieldOffset(0)]
            public ulong r11;

            [FieldOffset(0)]
            public uint r11d;

            [FieldOffset(0)]
            public ushort r11w;

            [FieldOffset(0)]
            public byte r11b;

            [FieldOffset(1)]
            byte r11bh;

            byte IGpReg64<R11>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r11b; 
 
                [MethodImpl(Inline)]
                set => r11b = value;
            }
            
            ushort IGpReg64<R11>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r11w; 
 
                [MethodImpl(Inline)]
                set => r11w = value;
            }

            uint IGpReg64<R11>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r11d; 
 
                [MethodImpl(Inline)]
                set => r11d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}