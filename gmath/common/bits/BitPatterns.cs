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

    public static class BitPatterns
    {

        public static readonly BitVectorU8 BV000 = BitVectorU8.Define(0, 0, 0, 0, 0, 0, 0, 0);

        public static readonly BitVectorU8 BV001 = BitVectorU8.Define(1, 0, 0, 0, 0, 0, 0, 0);

        public static readonly BitVectorU8 BV002 = BitVectorU8.Define(0, 1, 0, 0, 0, 0, 0, 0);

        public static readonly BitVectorU8 BV003 = BV002 | BV001;

        public static readonly BitVectorU8 BV004 = BitVectorU8.Define(0, 0, 1, 0, 0, 0, 0, 0);

        public static readonly BitVectorU8 BV005 = BV004 | BV001;

        public static readonly BitVectorU8 BV006 = BV004 | BV002;

        public static readonly BitVectorU8 BV007 = BV004 | BV003;

        public static readonly BitVectorU8 BV008 = BitVectorU8.Define(0, 0, 0, 1, 0, 0, 0, 0);

        public static readonly BitVectorU8 BV009 = BV008 | BV001;

        public static readonly BitVectorU8 BV010 = BV008 | BV002;

        public static readonly BitVectorU8 BV011 = BV008 | BV003;

        public static readonly BitVectorU8 BV012 = BV008 | BV004;

        public static readonly BitVectorU8 BV013 = BV008 | BV005;

        public static readonly BitVectorU8 BV014 = BV008 | BV006;

        public static readonly BitVectorU8 BV015 = BV008 | BV007;

        public static readonly BitVectorU8 BV016 = BitVectorU8.Define(0, 0, 0, 0, 1, 0, 0, 0);

        public static readonly BitVectorU8 BV017 = BV016 | BV001;

        public static readonly BitVectorU8 BV018 = BV016 | BV002;

        public static readonly BitVectorU8 BV019 = BV016 | BV003;

        public static readonly BitVectorU8 BV020 = BV016 | BV004;

        public static readonly BitVectorU8 BV021 = BV016 | BV005;

        public static readonly BitVectorU8 BV022 = BV016 | BV006;

        public static readonly BitVectorU8 BV023 = BV016 | BV007;

        public static readonly BitVectorU8 BV024 = BV016 | BV008;

        public static readonly BitVectorU8 BV025 = BV016 | BV009;
        
        public static readonly BitVectorU8 BV026 = BV016 | BV010;
        
        public static readonly BitVectorU8 BV027 = BV016 | BV011;
        
        public static readonly BitVectorU8 BV028 = BV016 | BV012;
        
        public static readonly BitVectorU8 BV029 = BV016 | BV013;
        
        public static readonly BitVectorU8 BV030 = BV016 | BV014;
        
        public static readonly BitVectorU8 BV031 = BV016 | BV015;

        public static readonly BitVectorU8 BV032 = BitVectorU8.Define(0, 0, 0, 0, 0, 1, 0, 0);
        
        public static readonly BitVectorU8 BV033 = BV032 | BV001;

        public static readonly BitVectorU8 BV034 = BV032 | BV002;

        public static readonly BitVectorU8 BV035 = BV032 | BV003;

        public static readonly BitVectorU8 BV036 = BV032 | BV004;

        public static readonly BitVectorU8 BV037 = BV032 | BV005;

        public static readonly BitVectorU8 BV038 = BV032 | BV006;

        public static readonly BitVectorU8 BV039 = BV032 | BV007;

        public static readonly BitVectorU8 BV040 = BV032 | BV008;

        public static readonly BitVectorU8 BV041 = BV032 | BV009;
        
        public static readonly BitVectorU8 BV042 = BV032 | BV010;
        
        public static readonly BitVectorU8 BV043 = BV032 | BV011;
        
        public static readonly BitVectorU8 BV044 = BV032 | BV012;
        
        public static readonly BitVectorU8 BV045 = BV032 | BV013;
        
        public static readonly BitVectorU8 BV046 = BV032 | BV014;
        
        public static readonly BitVectorU8 BV047 = BV032 | BV015;

        public static readonly BitVectorU8 BV048 = BV032 | BV016;

        public static readonly BitVectorU8 BV049 = BV032 | BV017;

        public static readonly BitVectorU8 BV050 = BV032 | BV018;

        public static readonly BitVectorU8 BV051 = BV032 | BV019;

        public static readonly BitVectorU8 BV052 = BV032 | BV020;

        public static readonly BitVectorU8 BV053 = BV032 | BV021;

        public static readonly BitVectorU8 BV054 = BV032 | BV022;

        public static readonly BitVectorU8 BV055 = BV032 | BV023;

        public static readonly BitVectorU8 BV056 = BV032 | BV024;
        
        public static readonly BitVectorU8 BV057 = BV032 | BV025;
        
        public static readonly BitVectorU8 BV058 = BV032 | BV026;
        
        public static readonly BitVectorU8 BV059 = BV032 | BV027;
        
        public static readonly BitVectorU8 BV060 = BV032 | BV028;
        
        public static readonly BitVectorU8 BV061 = BV032 | BV029;
        
        public static readonly BitVectorU8 BV062 = BV032 | BV030;
        
        public static readonly BitVectorU8 BV063 = BV032 | BV031;

        public static readonly BitVectorU8  BV064 = BitVectorU8.Define(0, 0, 0, 0, 0, 0, 1, 0);

        public static readonly BitVectorU8 BV065 = BV064 | BV001;

        public static readonly BitVectorU8 BV066 = BV064 | BV002;

        public static readonly BitVectorU8 BV067 = BV064 | BV003;

        public static readonly BitVectorU8 BV068 = BV064 | BV004;

        public static readonly BitVectorU8 BV069 = BV064 | BV005;

        public static readonly BitVectorU8 BV070 = BV064 | BV006;

        public static readonly BitVectorU8 BV071 = BV064 | BV007;

        public static readonly BitVectorU8 BV072 = BV064 | BV008;

        public static readonly BitVectorU8 BV073 = BV064 | BV009;

        public static readonly BitVectorU8 BV074 = BV064 | BV010;

        public static readonly BitVectorU8 BV075 = BV064 | BV011;

        public static readonly BitVectorU8 BV076 = BV064 | BV012;

        public static readonly BitVectorU8 BV077 = BV064 | BV013;

        public static readonly BitVectorU8 BV078 = BV064 | BV014;

        public static readonly BitVectorU8 BV079 = BV064 | BV015;

        public static readonly BitVectorU8 BV080 = BV064 | BV016;

        public static readonly BitVectorU8  BV128 = BitVectorU8.Define(0, 0, 0, 0, 0, 0, 0, 1);
        
        public static readonly BitVectorU8  BV255 = BitVectorU8.Define(1, 1, 1, 1, 1, 1, 1, 1);
                
        static readonly BitVectorU8[] Lookup = new BitVectorU8[]
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

        public static BitVectorU8 Find(byte src)
            => src <= 63 ? Lookup[src] : BitVectorU8.Define(src);

        [StructLayout(LayoutKind.Explicit )]
        public struct U16 
        {
            [FieldOffset(0)]
            public ushort data;
            
            [FieldOffset(0)]
            public byte lolo;
                        
            [FieldOffset(1)]
            public byte hihi;
        }


        [StructLayout(LayoutKind.Explicit)]
        public struct U32 
        {
            [FieldOffset(0)]
            public uint data;
            
            [FieldOffset(0)]
            public byte lolo;
            
            [FieldOffset(1)]
            public byte lohi;
            
            [FieldOffset(2)]
            public byte hilo;
            
            [FieldOffset(3)]
            public byte hihi;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct U64 
        {
            [FieldOffset(0)]
            public ulong data;
            
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

}