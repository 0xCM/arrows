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
    using static As;


    public static class Seed64
    {    

        /// <summary>
        /// Entropic seed generated for each call
        /// </summary>
        public static ulong Entropic
            => Seed.Entropy<ulong>();

        public static ulong Lookup(uint i)
            => i <= 15 
             ? RawBytes.ReadPrimalValue<ulong>((int)(i*8)) 
             : Errors.ThrowOutOfRange<ulong>((int)i, 0, 15);
                            
        public static ulong Seed00 => Lookup(0);

        public static ulong Seed01 => Lookup(1);

        public static ulong Seed02 => Lookup(2);

        public static ulong Seed03 => Lookup(3);

        public static ulong Seed04 => Lookup(4);

        public static ulong Seed05 => Lookup(5);

        public static ulong Seed06 => Lookup(6);

        public static ulong Seed07 => Lookup(7);

        public static ulong Seed08 => Lookup(8);

        public static ulong Seed09 => Lookup(9);

        public static ulong Seed10 => Lookup(10);

        public static ulong Seed11 => Lookup(11);

        public static ulong Seed12 => Lookup(12);

        public static ulong Seed13 => Lookup(13);

        public static ulong Seed14 => Lookup(14);

        public static ulong Seed15 => Lookup(15);


        /// <summary>
        /// See https://vcsjones.com/2019/02/01/csharp-readonly-span-bytes-static/ for an explanation
        /// of how the jit optimizes this
        /// </summary>
        /// <value></value>
        static ReadOnlySpan<byte> RawBytes => new byte[]
        {
            0x20, 0xda, 0x1f, 0x32, 0x4b, 0xca, 0x42, 0x5b,
            0x06, 0xbd, 0xac, 0xdb, 0x28, 0x87, 0x7a, 0xd4,
            0x0c, 0xd9, 0x1e, 0xde, 0x5d, 0x17, 0xd6, 0x7c,
            0x08, 0xcf, 0x94, 0x93, 0xf4, 0x5c, 0x4f, 0x6b,
            0x7a, 0x02, 0x62, 0x31, 0x37, 0xed, 0x21, 0x03,
            0xef, 0xe4, 0x4c, 0x0a, 0xbd, 0x8d, 0x48, 0x21,
            0xaf, 0x50, 0x9b, 0x7a, 0x75, 0x7d, 0xc0, 0xa7,
            0x4b, 0x70, 0x86, 0x84, 0x64, 0xee, 0x2b, 0x04,
            0x9c, 0xb5, 0x58, 0x3b, 0x35, 0xf3, 0x6f, 0x9a,
            0xf1, 0x5f, 0x70, 0x5f, 0xd3, 0x1b, 0x76, 0x8e,
            0x38, 0x72, 0xe0, 0x39, 0x6b, 0x6a, 0x45, 0x1a,
            0x7e, 0x34, 0xa8, 0xfb, 0x3d, 0xe4, 0x46, 0xa7,
            0x68, 0x41, 0x52, 0xa8, 0xbe, 0x22, 0xf6, 0xd9,
            0x1f, 0xa9, 0x8f, 0xb5, 0xef, 0x5b, 0xa6, 0x51,
            0x67, 0x64, 0x33, 0xae, 0xac, 0x7f, 0x0c, 0x71,
            0xb2, 0x38, 0xc8, 0xce, 0x36, 0xfe, 0xbc, 0xb4,
            0x0c, 0x79, 0x82, 0xef, 0x47, 0xe0, 0x79, 0xbb,
            0x69, 0xfb, 0x4f, 0x36, 0x59, 0x54, 0xec, 0xea,
            0x15, 0x24, 0x48, 0x77, 0xc3, 0x29, 0x3a, 0x50,
            0xae, 0xf6, 0x7d, 0x6f, 0x36, 0x98, 0x54, 0x56,
            0x74, 0x91, 0x4d, 0xec, 0x2a, 0x87, 0x9a, 0xfd,
            0x64, 0x7a, 0x48, 0x4e, 0xfa, 0x4b, 0xfc, 0xcf,
            0x09, 0xfb, 0x01, 0x9b, 0x78, 0xfa, 0x10, 0xe3,
            0x3c, 0x3b, 0xf9, 0x67, 0xa0, 0x53, 0xef, 0xc8,
            0x16, 0xf3, 0x7d, 0xd3, 0x11, 0xec, 0x25, 0x93,
            0x00, 0xa9, 0xac, 0x26, 0x0f, 0x7c, 0x0a, 0xf4,
            0xeb, 0xa1, 0xa8, 0x77, 0x11, 0x0c, 0x1f, 0xf3,
            0x8b, 0x35, 0xb7, 0xbb, 0x83, 0xc7, 0xd4, 0xc4,
            0x4d, 0xff, 0x80, 0xc9, 0xb7, 0x4e, 0xac, 0x41,
            0xf7, 0x97, 0x90, 0x50, 0x06, 0x38, 0x75, 0x46,
            0x3f, 0xf7, 0x3b, 0x83, 0x98, 0xfa, 0x9a, 0x5a,
            0x1f, 0xb5, 0x2f, 0xb1, 0x7c, 0x78, 0x9e, 0xfe,
            0x5d, 0x93, 0x2b, 0x66, 0x83, 0xd7, 0x49, 0x09,
            0x54, 0xd8, 0x5e, 0x4f, 0x56, 0x46, 0x84, 0x25,
            0x38, 0x41, 0xf3, 0x9a, 0x30, 0xb9, 0x98, 0x4d,
            0xf6, 0x77, 0x7c, 0x72, 0x61, 0x1c, 0x1a, 0x55,
            0x7b, 0x5f, 0xe5, 0xad, 0x8d, 0x07, 0x62, 0x61,
            0xb7, 0xc3, 0x36, 0x4d, 0x9a, 0xcf, 0x44, 0x4c,
            0x28, 0x41, 0xd5, 0x79, 0xd7, 0xe0, 0x1e, 0xd4,
            0x92, 0x0d, 0x9c, 0x5b, 0x57, 0x68, 0xd9, 0x74,
            0x89, 0x81, 0xd0, 0xc2, 0x77, 0x31, 0x8e, 0x00,
            0xe3, 0x17, 0x8d, 0x5e, 0x2f, 0xb8, 0xac, 0x02,
            0x61, 0x47, 0x07, 0x2d, 0x8c, 0xec, 0xe8, 0xcc,
            0x5b, 0x70, 0x1f, 0xcf, 0x62, 0x96, 0xbc, 0x02,
            0x21, 0x8c, 0x74, 0xfe, 0xec, 0x77, 0xd0, 0x49,
            0x6e, 0x36, 0xf1, 0x72, 0xf1, 0x67, 0x9e, 0xbf,
            0xbd, 0xde, 0x71, 0x18, 0x37, 0x18, 0x6d, 0x5c,
            0x72, 0x9c, 0xbe, 0x29, 0xab, 0x98, 0x24, 0x31,
            0x51, 0xe3, 0x5d, 0x0c, 0xe2, 0xdf, 0x2c, 0x66,
            0xc2, 0x6e, 0xbc, 0x2c, 0xde, 0xc3, 0x0d, 0xd7,
        };        
  }
}