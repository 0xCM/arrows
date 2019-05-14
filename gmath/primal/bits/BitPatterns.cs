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

        public static readonly BitVectorU8 BV081 = BV064 | BV017;

        public static readonly BitVectorU8 BV082 = BV064 | BV018;

        public static readonly BitVectorU8 BV083 = BV064 | BV019;

        public static readonly BitVectorU8 BV084 = BV065 | BV020;

        public static readonly BitVectorU8 BV085 = BV065 | BV021;

        public static readonly BitVectorU8 BV086 = BV065 | BV022;

        public static readonly BitVectorU8 BV087 = BV065 | BV023;

        public static readonly BitVectorU8 BV088 = BV065 | BV024;

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


        [StructLayout(LayoutKind.Explicit )]
        public struct I16 
        {
            [FieldOffset(0)]
            public short value;
            
            [FieldOffset(0)]
            public byte x000;
                        
            [FieldOffset(1)]
            public byte x001;
        }

    }

}