//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;

    using static zfunc;


    public static class Seed64
    {
        
        public static void GenSeeds(int count)
        {
            var entropy = Seed.Entropy<ulong>(count);
            var counter = 0;
            foreach(var e in entropy)
            {
                
                var name = "Seed" + (counter++).ToString().PadLeft(2,'0');
                var format = new string(' ',8) + $"public const ulong {name} = {e.ToHexString(false,true)}ul;";
                print(format);
                print();
            }
        }

        /// <summary>
        /// Entropic seed generated for each call
        /// </summary>
        public static ulong Enropic
            => Seed.Entropy<ulong>();

        public const ulong Seed00 = 0x6b85fa440de5b8cul;

        public const ulong Seed01 = 0x7b7531f97f027927ul;

        public const ulong Seed02 = 0x3d23d3e502385413ul;

        public const ulong Seed03 = 0xc2aeaaa2db28084dul;

        public const ulong Seed04 = 0x7e70fadc5e628bfful;

        public const ulong Seed05 = 0x9263b9d261881eaeul;

        public const ulong Seed06 = 0xc4629a81a2a652e2ul;

        public const ulong Seed07 = 0xc1bc851bc2106fbdul;

        public const ulong Seed08 = 0xcc72c823e062387eul;

        public const ulong Seed09 = 0xa92f9e10ff9b40f0ul;

        public const ulong Seed10 = 0xb90378da88e8a357ul;

        public const ulong Seed11 = 0x5b5138fadacc4453ul;

        public const ulong Seed12 = 0x4de6294bea9e50faul;

        public const ulong Seed13 = 0xeff692810d6f2279ul;

        public const ulong Seed14 = 0x9bb69aaceea1959ful;

        public const ulong Seed15 = 0x37103b0c95ffa7f1ul;

        public const ulong Seed16 = 0xec46e1f31460a140ul;

        public const ulong Seed17 = 0x3e9264b4caa32e2cul;

        public const ulong Seed18 = 0xc1114c9f887824f2ul;

        public const ulong Seed19 = 0xa9970116bda91b21ul;

        public const ulong Seed20 = 0xd795da54edbc1baeul;

        public const ulong Seed21 = 0x22525139068c1de0ul;

        public const ulong Seed22 = 0x5305570a74d8aab3ul;

        public const ulong Seed23 = 0xbaf3a1758abecc5eul;

        public const ulong Seed24 = 0x44f010d1c1139198ul;

        public const ulong Seed25 = 0x7f887aa9c017c0d4ul;

        public const ulong Seed26 = 0xc2028e76c9737fd8ul;

        public const ulong Seed27 = 0x11d6ffb29bb6fbc7ul;

        public const ulong Seed28 = 0x93ba815aad6ae036ul;

        public const ulong Seed29 = 0x77de3a33eb97cdc6ul;

        public const ulong Seed30 = 0x74f4d8408d60e411ul;

        public const ulong Seed31 = 0x4adf52d3edb9dcb2ul;

        public const ulong Seed32 = 0x34958170a5e0f364ul;

        public const ulong Seed33 = 0x2c44775eaa8505f6ul;

        public const ulong Seed34 = 0x8a0718a20285f2ccul;

        public const ulong Seed35 = 0xef368a7d3f08cb21ul;

        public const ulong Seed36 = 0x6339c654d59a3fd1ul;

        public const ulong Seed37 = 0xd954055a89a31a0aul;

        public const ulong Seed38 = 0x75c1d7d7e262cb8ul;

        public const ulong Seed39 = 0x36122b3828c2958aul;

        public const ulong Seed40 = 0xf413e31ceef9c843ul;

        public const ulong Seed41 = 0xee7e527ca8259910ul;

        public const ulong Seed42 = 0x84fe2563569c64b3ul;

        public const ulong Seed43 = 0x43bfcbd6bb1978c6ul;

        public const ulong Seed44 = 0xd541c8ead0a4b80ful;

        public const ulong Seed45 = 0xba374b20c3589283ul;

        public const ulong Seed46 = 0xabbc8f990d090d8eul;

        public const ulong Seed47 = 0x6b1dbb547b498bcful;

        public const ulong Seed48 = 0x12d4ec902f5ea09dul;

        public const ulong Seed49 = 0xb0549906e7255148ul;

    }

}