//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    /*
    typedef union  __declspec(intrin_type) __declspec(align(64)) __m512i {
        __int8              m512i_i8[64];
        __int16             m512i_i16[32];
        __int32             m512i_i32[16];
        __int64             m512i_i64[8];
        unsigned __int8     m512i_u8[64];
        unsigned __int16    m512i_u16[32];
        unsigned __int32    m512i_u32[16];
        unsigned __int64    m512i_u64[8];
    } __m512i;
    
     */
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public ref struct U512
    {

        [FieldOffset(0)]
        public ulong x0;

        [FieldOffset(8)]
        public ulong x1;

        [FieldOffset(16)]
        public ulong x2;

        [FieldOffset(24)]
        public ulong x3;

        [FieldOffset(32)]
        public ulong x4;

        [FieldOffset(40)]
        public ulong x5;

        [FieldOffset(48)]
        public ulong x6;

        [FieldOffset(56)]
        public ulong x7;

        [FieldOffset(0)]        
        public byte x0000;
        
        [FieldOffset(1)]
        public byte x0001;
        
        [FieldOffset(2)]
        public byte x0002;
        
        [FieldOffset(3)]
        public byte x0003;

        [FieldOffset(4)]
        public byte x0004;
        
        [FieldOffset(5)]
        public byte x0005;
        
        [FieldOffset(6)]
        public byte x0006;
        
        [FieldOffset(7)]
        public byte x0007;

        [FieldOffset(8)]        
        public byte x0008;
        
        [FieldOffset(9)]
        public byte x0009;
        
        [FieldOffset(10)]
        public byte x001A;
        
        [FieldOffset(11)]
        public byte x001B;

        [FieldOffset(12)]
        public byte x000C;
        
        [FieldOffset(13)]
        public byte x000D;
        
        [FieldOffset(14)]
        public byte x000E;
        
        [FieldOffset(15)]
        public byte x000F;

        [FieldOffset(16)]
        public byte x0010;

        [FieldOffset(17)]
        public byte x0011;

        [FieldOffset(18)]
        public byte x0012;


    }

}