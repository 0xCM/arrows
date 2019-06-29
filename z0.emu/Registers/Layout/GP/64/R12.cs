//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20112
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
        public struct R12 : IGpReg64<R12>
        {
            [FieldOffset(0)]
            public ulong r12;

            [FieldOffset(0)]
            public uint r12d;

            [FieldOffset(0)]
            public ushort r12w;

            [FieldOffset(0)]
            public byte r12b;

            public const int BitWidth = 64;        

            public const int ByteCount = 12;

            public const string Name = nameof(R12);

            public const GpRegId Id = GpRegId.r12;            



            byte IGpReg64<R12>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r12b; 
 
                [MethodImpl(Inline)]
                set => r12b = value;
            }

            ushort IGpReg64<R12>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r12w; 
 
                [MethodImpl(Inline)]
                set => r12w = value;
            }

            uint IGpReg64<R12>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r12d; 
 
                [MethodImpl(Inline)]
                set => r12d = value;
            }

            GpRegId IGpReg.Id 
                => Id;
       }
    }
}