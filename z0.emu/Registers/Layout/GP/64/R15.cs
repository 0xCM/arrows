//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20115
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
        public struct R15 : IGpReg64<R15>
        {
            public const int BitWidth = 64;        

            public const int ByteCount = 15;

            public const string Name = nameof(R15);

            public const GpRegId Id = GpRegId.r15;            

            [FieldOffset(0)]
            public ulong r15;

            [FieldOffset(0)]
            public uint r15d;

            [FieldOffset(0)]
            public ushort r15w;

            [FieldOffset(0)]
            public byte r15b;

            [FieldOffset(1)]
            byte r15bh;

            byte IGpReg64<R15>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r15b; 
 
                [MethodImpl(Inline)]
                set => r15b = value;
            }

            
            ushort IGpReg64<R15>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r15w; 
 
                [MethodImpl(Inline)]
                set => r15w = value;
            }

            uint IGpReg64<R15>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r15d; 
 
                [MethodImpl(Inline)]
                set => r15d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}