//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20113
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
        public struct R13 : IGpReg64<R13>
        {
            public const int BitWidth = 64;        

            public const int ByteCount = 13;

            public const string Name = nameof(R13);

            public const GpRegId Id = GpRegId.r13;            

            [FieldOffset(0)]
            public ulong r13;

            [FieldOffset(0)]
            public uint r13d;

            [FieldOffset(0)]
            public ushort r13w;

            [FieldOffset(0)]
            public byte r13b;

            [FieldOffset(1)]
            byte r13bh;

            byte IGpReg64<R13>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r13b; 
 
                [MethodImpl(Inline)]
                set => r13b = value;
            }
            
            ushort IGpReg64<R13>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r13w; 
 
                [MethodImpl(Inline)]
                set => r13w = value;
            }

            uint IGpReg64<R13>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r13d; 
 
                [MethodImpl(Inline)]
                set => r13d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}