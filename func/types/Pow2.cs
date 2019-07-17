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

    
    using static zfunc;

    public static class Pow2U8
    {
        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const byte T00 = 1;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const byte T01 = 2*T00;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const byte T02 = 2*T01;

        /// <summary>
        /// 2^3 = 8
        /// </summary>
        public const byte T03 = 2*T02;

        /// <summary>
        /// 2^4 = 16
        /// </summary>
        public const byte T04 = 2*T03;

        /// <summary>
        /// 2^5 = 32
        /// </summary>
        public const byte T05 = 2*T04;

        /// <summary>
        /// 2^6 = 64
        /// </summary>
        public const byte T06 = 2*T05;

        /// <summary>
        /// 2^7 = 128
        /// </summary>
        public const byte T07 = 2*T06;
            

    }

    public static class Pow2
    {        
        
        static readonly byte[] _PowU8 = new byte[]
        {
            T00, T01, T02, T03, T04, T05, T06, T07 
        };

        static readonly IReadOnlyDictionary<byte,byte> _PowU8Iverse
            = _PowU8.Mapi((i,v) => (v,(byte)i)).ToDictionary();

        static readonly ushort[] _PowU16 = new ushort[]
        {
            T00, T01, T02, T03, T04, T05, T06, T07, 
            T08, T09, T10, T11, T12, T13, T14, T15, 
        };

        static readonly IReadOnlyDictionary<ushort,byte> _PowU16Inverse
            = _PowU16.Mapi((i,v) => (v,(byte)i)).ToDictionary();

        static readonly uint[] _PowU32 = new uint[]
        {
            T00, T01, T02, T03, T04, T05, T06, T07, 
            T08, T09, T10, T11, T12, T13, T14, T15, 
            T16, T17, T18, T19, T20, T21, T22, T23, 
            T24, T25, T26, T27, T28, T29, T30, T31, 
        };

        static readonly IReadOnlyDictionary<uint,byte> _PowU32Inverse
            = _PowU32.Mapi((i,v) => (v,(byte)i)).ToDictionary();

        static readonly ulong[] _PowU64 = new ulong[]{
            T00, T01, T02, T03, T04, T05, T06, T07, 
            T08, T09, T10, T11, T12, T13, T14, T15, 
            T16, T17, T18, T19, T20, T21, T22, T23, 
            T24, T25, T26, T27, T28, T29, T30, T31, 
            T32, T33, T34, T35, T36, T37, T38, T39,
            T40, T41, T42, T43, T44, T45, T46, T47, 
            T48, T49, T50, T51, T52, T53, T54, T55, 
            T56, T57, T58, T59, T60, T61, T62, T63};


        static readonly IReadOnlyDictionary<ulong,byte> _PowU64Inverse
            = _PowU64.Mapi((i,v) => (v,(byte)i)).ToDictionary();

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,7]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static byte pow(sbyte i)
            => _PowU8[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,7]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static byte pow(byte i)
            => _PowU8[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,15]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ushort pow(short i)
            => _PowU16[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,15]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ushort pow(ushort i)
            => _PowU16[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,31]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static uint pow(int i)
            => _PowU32[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,31]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static uint pow(uint i)
            => _PowU32[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(long i)
            => _PowU64[i];

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(ulong i)
            => _PowU64[i];

        /// <summary>
        /// For i < j, computes the sequence 2^i, ..., 2^j 
        /// </summary>
        /// <param name="i">The minimum power</param>
        /// <param name="j">The maximum power</param>
        /// <typeparam name="T">The computation result type</typeparam>
        public static T[] powers<T>(in byte i, in byte j)
            where T : struct
        {   
            var dst = new T[j - i + 1];
            var current = (ulong)i;
            var pos = 0;
            while(current <= j)
                dst[pos++] = convert<ulong,T>(pow(current++));
            return dst;
        }

        static T Pow2Error<T>(T pow2)
            => throw new ArgumentException($"{pow2} is not a power of 2");

        /// <summary>
        /// Given n, computes i  n = 2^i
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^7</param>
        [MethodImpl(Inline)]
        public static byte inv(byte n)
            => _PowU8Iverse.TryGetValue(n, out byte e) ? e : Pow2Error(n);

        /// <summary>
        /// Given n, computes i  n = 2^i
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^15</param>
        [MethodImpl(Inline)]
        public static ushort inv(ushort pow2)
            => _PowU16Inverse.TryGetValue(pow2, out byte e) ? e : Pow2Error(pow2);

        /// <summary>
        /// Given n, computes i  n = 2^i
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^31</param>
        [MethodImpl(Inline)]
        public static uint inv(uint pow2)
            => _PowU32Inverse.TryGetValue(pow2, out byte e) ? e : Pow2Error(pow2);

        /// <summary>
        /// Given n, computes i  n = 2^63
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^15</param>
        [MethodImpl(Inline)]
        public static ulong inv(ulong pow2)
            => _PowU64Inverse.TryGetValue(pow2, out byte e) ? e : Pow2Error(pow2);

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
        /// 2^25 = 33,554,432
        /// </summary>
        public const int T25 = 2*T24;
        
        /// <summary>
        /// 2^26 = 67,108,864
        /// </summary>
        public const int T26 = 2*T25;
        
        /// <summary>
        /// 2^27 = 134,217,728
        /// </summary>
        public const int T27 = 2*T26;
        
        /// <summary>
        /// 2^28 = 268,435,456
        /// </summary>
        public const int T28 = 2*T27;
        
        /// <summary>
        /// 2^29 = 268,435,456
        /// </summary>
        public const int T29 = 2*T28;
        
        /// <summary>
        /// 2^30 = 1,073,741,824
        /// </summary>
        public const int T30 = 2*T29;
        
        /// <summary>
        /// 2^31 = _
        /// </summary>
        public const uint T31 = 2*(uint)T30;
        
        /// <summary>
        /// 2^32 = _
        /// </summary>
        public const long T32 = 2*(long)T31;
        
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

        public const long T50 = 2*T49;

        public const long T51 = 2*T50;
                
        public const long T52 = 2*T51;

        public const long T53 = 2*T52;

        public const long T54 = 2*T53;

        public const long T55 = 2*T54;

        public const long T56 = 2*T55;

        public const long T57 = 2*T56;

        public const long T58 = 2*T57;

        public const long T59 = 2*T58;
        
        public const long T60 = 2*T59;

        public const long T61 = 2*T60;

        public const long T62 = 2*T61;        
        
        /// <summary>
        /// 9223372036854775808
        /// </summary>
        public const ulong T63 = 2* (ulong)T62;

    }
}