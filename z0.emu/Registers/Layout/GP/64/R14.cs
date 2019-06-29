//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 20114
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
        public struct R14 : IGpReg64<R14>
        {
            public const int ByteCount = 14;

            public const string Name = nameof(R14);

            public const GpRegId Id = GpRegId.r14;            

            [FieldOffset(0)]
            public ulong r14;

            [FieldOffset(0)]
            public uint r14d;

            [FieldOffset(0)]
            public ushort r14w;

            [FieldOffset(0)]
            public byte r14b;


            byte IGpReg64<R14>.Lo8 
            { 
                [MethodImpl(Inline)]
                get => r14b; 
 
                [MethodImpl(Inline)]
                set => r14b = value;
            }
            
            ushort IGpReg64<R14>.Lo16 
            { 
                [MethodImpl(Inline)]
                get => r14w; 
 
                [MethodImpl(Inline)]
                set => r14w = value;
            }

            uint IGpReg64<R14>.Lo32
            { 
                [MethodImpl(Inline)]
                get => r14d; 
 
                [MethodImpl(Inline)]
                set => r14d = value;
            }


            GpRegId IGpReg.Id 
                => Id;
       }
    }
}