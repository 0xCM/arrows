//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    
    using static mfunc;
    
    public static class Pow2
    {
        /// <summary>
        /// Computes 2^i 
        /// </summary>
        /// <param name="exp">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(int exp)
            => exp switch {
                0 => (ulong)T00,
                1 => (ulong)T01,
                2 => (ulong)T02,
                3 => (ulong)T03,
                4 => (ulong)T04,
                5 => (ulong)T05,
                6 => (ulong)T06,
                7 => (ulong)T07,
                8 => (ulong)T08,
                9 => (ulong)T09,
                10 => (ulong)T10,
                11 => (ulong)T11,
                12 => (ulong)T12,
                13 => (ulong)T13,
                14 => (ulong)T14,
                15 => (ulong)T15,
                16 => (ulong)T16,
                17 => (ulong)T17,
                18 => (ulong)T18,
                19 => (ulong)T19,
                20 => (ulong)T20,
                21 => (ulong)T21,
                22 => (ulong)T22,
                23 => (ulong)T23,
                24 => (ulong)T24,
                25 => (ulong)T25,
                26 => (ulong)T26,
                27 => (ulong)T27,
                28 => (ulong)T28,
                29 => (ulong)T29,
                30 => (ulong)T30,
                31 => (ulong)T31,
                32 => (ulong)T32,
                33 => (ulong)T33,
                34 => (ulong)T34,
                35 => (ulong)T35,
                _ => 0UL,
            };

        public static T[] powers<T>(int min, byte max)
        {   
            var dst = new T[max - min + 1];
            var current = min;
            var i = 0;
            while(current <= max)
                dst[i++] = ClrConverter.convert<ulong,T>(pow(current++));
            return dst;
        }

        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const int T00 = 1;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const int T01 = 2*T00;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const int T02 = 2*T01;

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        public const int T03 = 2*T02;

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        public const int T04 = 2*T03;

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        public const int T05 = 2*T04;

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        public const int T06 = 2*T05;

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        public const int T07 = 2*T06;

        /// <summary>
        /// 2^8 = 256
        /// </summary>
        public const int T08 = 2*T07;

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        public const int T09 = 2*T08;

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        public const int T10 = 2*T09;
        
        /// <summary>
        /// 2^11 = 2048
        /// </summary>
        public const int T11 = 2*T10;
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        public const int T12 = 2*T11;

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        public const int T13 = 2*T12;

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        public const int T14 = 2*T13;
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        public const int T15 = 2*T14;

        /// <summary>
        /// 2^16 = 65,536
        /// </summary>
        public const int T16 = 2*T15;
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        public const int T17 = 2*T16;

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        public const int T18 = 2*T17;

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        public const int T19 = 2*T18;

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        public const int T20 = 2*T19;
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        public const int T21 = 2*T20;

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        public const int T22 = 2*T21;

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        public const int T23 = 2*T22;
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        public const int T24 = 2*T23;

        /// <summary>
        /// 2^25 = _
        /// </summary>
        public const int T25 = 2*T24;
        
        /// <summary>
        /// 2^26 = _
        /// </summary>
        public const int T26 = 2*T25;
        
        /// <summary>
        /// 2^27 = _
        /// </summary>
        public const int T27 = 2*T26;
        
        /// <summary>
        /// 2^28 = _
        /// </summary>
        public const int T28 = 2*T27;
        
        /// <summary>
        /// 2^29 = _
        /// </summary>
        public const int T29 = 2*T28;
        
        /// <summary>
        /// 2^30 = _
        /// </summary>
        public const long T30 = 2*T29;
        
        /// <summary>
        /// 2^31 = _
        /// </summary>
        public const long T31 = 2*T30;
        
        /// <summary>
        /// 2^32 = _
        /// </summary>
        public const long T32 = 2*T31;
        
        public const long T33 = 2*T32;
        
        public const long T34 = 2*T33;
        
        public const long T35 = 2*T34;
        
        public const long T36 = 2*T35;
        
        public const long T37 = 2*T36;
        
        public const long T38 = 2*T37;
        
        public const long T39 = 2*T38;
        
        public const long T40 = 2*T39;
        
        public const long T41 = 2*T40;
        
        public const long T42 = 2*T41;
        
        public const long T43 = 2*T42;
        
        public const long T44 = 2*T43;
        
        public const long T45 = 2*T44;
        
        public const long T46 = 2*T45;

        public const long T47 = 2*T46;
        
        public const long T48 = 2*T47;
        
        public const long T49 = 2*T48;


    }

}