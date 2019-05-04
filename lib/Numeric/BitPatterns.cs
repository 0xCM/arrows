//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;

    using static zcore;

    using ByteVector = BitVector<N8>;
    

    public static class BitVectorPatterns
    {

        static ByteVector pattern(bit b7, bit b6, bit b5, bit b4, bit b3, bit b2, bit b1, bit b0)
            => BitVector.define<N8>(b7, b6, b5, b4, b3, b2, b1, b0);

        public static ByteVector lookup(byte src)
            => ByteIndex[src];

        public static readonly ByteVector BV000 = pattern(0, 0, 0, 0, 0, 0, 0, 0);

        public static readonly ByteVector BV001 = pattern(0, 0, 0, 0, 0, 0, 0, 1);

        public static readonly ByteVector BV002 = pattern(0, 0, 0, 0, 0, 0, 1, 0);

        public static readonly ByteVector BV003 = BV002 | BV001;

        public static readonly ByteVector BV004 = pattern(0, 0, 0, 0, 0, 1, 0, 0);

        public static readonly ByteVector BV005 = BV004 | BV001;

        public static readonly ByteVector BV006 = BV004 | BV002;

        public static readonly ByteVector BV007 = BV004 | BV003;

        public static readonly ByteVector BV008 = pattern(0, 0, 0,0, 1, 0, 0, 0);

        public static readonly ByteVector BV009 = BV008 | BV001;

        public static readonly ByteVector BV010 = BV008 | BV002;

        public static readonly ByteVector BV011 = BV008 | BV003;

        public static readonly ByteVector BV012 = BV008 | BV004;

        public static readonly ByteVector BV013 = BV008 | BV005;

        public static readonly ByteVector BV014 = BV008 | BV006;

        public static readonly ByteVector BV015 = BV008 | BV007;

        public static readonly ByteVector BV016 = pattern(0, 0, 0, 1, 0, 0, 0, 0);

        public static readonly ByteVector BV017 = BV016 | BV001;

        public static readonly ByteVector BV018 = BV016 | BV002;

        public static readonly ByteVector BV019 = BV016 | BV003;

        public static readonly ByteVector BV020 = BV016 | BV004;

        public static readonly ByteVector BV021 = BV016 | BV005;

        public static readonly ByteVector BV022 = BV016 | BV006;

        public static readonly ByteVector BV023 = BV016 | BV007;

        public static readonly ByteVector BV024 = BV016 | BV008;

        public static readonly ByteVector BV025 = BV016 | BV009;
        
        public static readonly ByteVector BV026 = BV016 | BV010;
        
        public static readonly ByteVector BV027 = BV016 | BV011;
        
        public static readonly ByteVector BV028 = BV016 | BV012;
        
        public static readonly ByteVector BV029 = BV016 | BV013;
        
        public static readonly ByteVector BV030 = BV016 | BV014;
        
        public static readonly ByteVector BV031 = BV016 | BV015;

        public static readonly ByteVector BV032 = pattern(0, 0, 1, 0, 0, 0, 0, 0);
        
        public static readonly ByteVector BV033 = BV032 | BV001;

        public static readonly ByteVector BV034 = BV032 | BV002;

        public static readonly ByteVector BV035 = BV032 | BV003;

        public static readonly ByteVector BV036 = BV032 | BV004;

        public static readonly ByteVector BV037 = BV032 | BV005;

        public static readonly ByteVector BV038 = BV032 | BV006;

        public static readonly ByteVector BV039 = BV032 | BV007;

        public static readonly ByteVector BV040 = BV032 | BV008;

        public static readonly ByteVector BV041 = BV032 | BV009;
        
        public static readonly ByteVector BV042 = BV032 | BV010;
        
        public static readonly ByteVector BV043 = BV032 | BV011;
        
        public static readonly ByteVector BV044 = BV032 | BV012;
        
        public static readonly ByteVector BV045 = BV032 | BV013;
        
        public static readonly ByteVector BV046 = BV032 | BV014;
        
        public static readonly ByteVector BV047 = BV032 | BV015;

        public static readonly ByteVector BV048 = BV032 | BV016;

        public static readonly ByteVector BV049 = BV032 | BV017;

        public static readonly ByteVector BV050 = BV032 | BV018;

        public static readonly ByteVector BV051 = BV032 | BV019;

        public static readonly ByteVector BV052 = BV032 | BV020;

        public static readonly ByteVector BV053 = BV032 | BV021;

        public static readonly ByteVector BV054 = BV032 | BV022;

        public static readonly ByteVector BV055 = BV032 | BV023;

        public static readonly ByteVector BV056 = BV032 | BV024;
        
        public static readonly ByteVector BV057 = BV032 | BV025;
        
        public static readonly ByteVector BV058 = BV032 | BV026;
        
        public static readonly ByteVector BV059 = BV032 | BV027;
        
        public static readonly ByteVector BV060 = BV032 | BV028;
        
        public static readonly ByteVector BV061 = BV032 | BV029;
        
        public static readonly ByteVector BV062 = BV032 | BV030;
        
        public static readonly ByteVector BV063 = BV032 | BV031;

        public static readonly ByteVector  BV064 = pattern(0, 1, 0, 0, 0, 0, 0, 0);

        public static readonly ByteVector BV065 = BV064 | BV001;

        public static readonly ByteVector BV066 = BV064 | BV002;

        public static readonly ByteVector BV067 = BV064 | BV003;

        public static readonly ByteVector BV068 = BV064 | BV004;

        public static readonly ByteVector BV069 = BV064 | BV005;

        public static readonly ByteVector BV070 = BV064 | BV006;

        public static readonly ByteVector BV071 = BV064 | BV007;

        public static readonly ByteVector BV072 = BV064 | BV008;

        public static readonly ByteVector BV073 = BV064 | BV009;

        public static readonly ByteVector BV074 = BV064 | BV010;

        public static readonly ByteVector  BV128 = pattern(1, 0, 0, 0, 0, 0, 0, 0);
        
        public static readonly ByteVector  BV255 = pattern(1, 1, 1, 1, 1, 1, 1, 1);
    
        
        
        static readonly ByteVector[] ByteIndex = new ByteVector[]
        {
            BV000, BV001, BV002, BV003, BV004, BV005, BV006, BV007,
            BV008, BV009, BV010, BV011, BV012, BV013, BV014, BV015,
            BV016, BV017, BV018, BV019, BV020, BV021, BV022, BV023,
            BV024, BV025, BV026, BV027, BV028, BV029, BV030, BV031,
            BV032, BV033, BV034, BV035, BV036, BV037, BV038, BV039,
            BV040, BV041, BV042, BV043, BV044, BV045, BV046, BV047,
            BV048, BV049, BV050, BV051, BV052, BV053, BV054, BV055,
            BV056, BV057, BV058, BV059, BV060, BV061, BV062, BV063,

        };

        

    }

    public enum BitPattern : byte
    {
        B000 = 0b00000000,        
        B00000000 = B000,

        B001 = 0b00000001,
        B00000001 = B001, 

        B002 = 0b00000010,
        B00000010 = B002, 

        B003 = B002 | B001,
        B00000011 = B003,

        B004 = 0b00000100,
        B00000100 = B004,

        B005 = B004 | B001,
        B00000101 = B005,

        B006 = B004 | B002,
        B00000110 = B006,

        B007 = B004 | B003,
        B00000111 = B007,

        B008 = 0b00001000,
        B00001000 = B008,

        B009 = B008 | B001,
        B00001001 = B009,

        B010 = B008 | B002,
        B00001010 = B010,

        B011 = B008 | B003,
        B00001011 = B011,

        B012 = B008 | B004,
        B00001100 = B012,

        B013 = B008 | B005,
        B00001101 = B013,

        B014 = B008 | B006,
        B00001110 = B014,

        B015 = B008 | B007,
        B00001111 = B015,

        B016 = 0b00010000,
        
        B017 = B016 | B001,

        B018 = B016 | B002,

        B019 = B016 | B003,

        B020 = B016 | B004,

        B021 = B016 | B005,

        B022 = B016 | B006,

        B023 = B016 | B007,

        B024 = B016 | B008,

        B025 = B016 | B009,
        
        B026 = B016 | B010,
        
        B027 = B016 | B011,
        
        B028 = B016 | B012,
        
        B029 = B016 | B013,
        
        B030 = B016 | B014,
        
        B031 = B016 | B015,

        B032 = 0b00100000,

        B033 = B032 | B001,

        B034 = B032 | B002,

        B035 = B032 | B003,

        B036 = B032 | B004,

        B037 = B032 | B005,

        B038 = B032 | B006,

        B039 = B032 | B007,

        B040 = B032 | B008,

        B041 = B032 | B009,
        
        B042 = B032 | B010,
        
        B043 = B032 | B011,
        
        B044 = B032 | B012,
        
        B045 = B032 | B013,
        
        B046 = B032 | B014,
        
        B047 = B032 | B015,

        B048 = B032 | B016,

        B049 = B032 | B017,

        B050 = B032 | B018,

        B051 = B032 | B019,

        B052 = B032 | B020,

        B053 = B032 | B021,

        B054 = B032 | B022,

        B055 = B032 | B023,

        B056 = B032 | B024,
        
        B057 = B032 | B025,
        
        B058 = B032 | B026,
        
        B059 = B032 | B027,
        
        B060 = B032 | B028,
        
        B061 = B032 | B029,
        
        B062 = B032 | B030,
        
        B063 = B032 | B031,

    }

    public static class BitPatterns
    {

        public const byte B128 = 0b10000000;

        public const byte B255 = 0b11111111;

        [StructLayout(LayoutKind.Explicit )]
        public struct UInt16Bytes 
        {
            [FieldOffset(0)]
            public ushort I16;
            
            [FieldOffset(0)]
            public byte lolo;
                        
            [FieldOffset(1)]
            public byte hihi;
        }


        [StructLayout(LayoutKind.Explicit )]
        public struct UInt32Bytes 
        {
            [FieldOffset(0)]
            public uint value;
            
            [FieldOffset(0)]
            public byte lolo;
            
            [FieldOffset(1)]
            public byte lohi;
            
            [FieldOffset(2)]
            public byte hilo;
            
            [FieldOffset(3)]
            public byte hihi;
        }

        [StructLayout(LayoutKind.Explicit )]
        public struct UInt64Bytes 
        {
            [FieldOffset(0)]
            public ulong UL;
            
            [FieldOffset(0)]
            public uint UI0;

            [FieldOffset(4)]
            public uint UI1;

            [FieldOffset(0)]
            public uint US0;

            [FieldOffset(2)]
            public uint US1;

            [FieldOffset(4)]
            public uint US2;

            [FieldOffset(6)]
            public uint US3;

            [FieldOffset(0)]        
            public byte B0;
            
            [FieldOffset(1)]
            public byte B1;
            
            [FieldOffset(2)]
            public byte B2;
            
            [FieldOffset(3)]
            public byte B3;

            [FieldOffset(4)]
            public byte B4;
            
            [FieldOffset(5)]
            public byte B5;
            
            [FieldOffset(6)]
            public byte B6;
            
            [FieldOffset(7)]
            public byte B7;

        }

    }


    partial class xcore
    {
        public static BitVector<N8> ToByteVector(this BitPattern pattern)
            => BitVectorPatterns.lookup((byte)pattern);

        /// <summary>
        /// Constructs a bytevector from an array of digits
        /// </summary>
        /// <param name="src">The source digits</param>
        public static BitVector<N8> ToByteVector(this BinaryDigit[] src)
            => bytevector(src);

    }
}