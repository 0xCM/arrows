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
    
    public static class Pow2    
    {                
        /// <summary>
        /// Computes the remainder of division by a power of 2, a % 2^i
        /// </summary>
        /// <param name="a">The value being divided by a power of 2</param>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong mod(ulong a, int i)        
            => a & ((1ul << i) - 1);  

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(byte i)
            => pow<ulong>(i);

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63], and
        /// because .Net loves signed 32-bit integers
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong pow(int i)
            => pow<ulong>((byte)i);

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// and 2^i does not exceed the maximum value of T
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static T pow<T>(byte i)
            where T : unmanaged
            => Unsafe.As<ulong,T>(ref Powers[i]);

        /// <summary>
        /// For i < j, computes the sequence 2^i, ..., 2^j 
        /// </summary>
        /// <param name="i">The minimum power</param>
        /// <param name="j">The maximum power</param>
        /// <typeparam name="T">The computation result type</typeparam>
        public static T[] powers<T>(in byte i, in byte j)
            where T : unmanaged
        {   
            var dst = new T[j - i + 1];
            var current = i;
            var pos = 0;
            while(current <= j)
                dst[pos++] = pow<T>(current++);
            return dst;
        }

        /// <summary>
        /// Solves for i in the equation n = 2^i
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^15</param>
        [MethodImpl(Inline)]
        public static byte inv<T>(T n)
            where T : unmanaged
            => Inverted.TryGetValue(convert<T,ulong>(n), out byte e) ? e : Pow2Error(n);

        /// <summary>
        /// Given n, computes i  n = 2^63
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^63</param>
        [MethodImpl(Inline)]
        public static ulong inv(ulong pow2)
            => inv<ulong>(pow2);

        [MethodImpl(Inline)]
        public static ulong inv(int pow2)
            => inv((int)pow2);

        static byte Pow2Error<T>(T pow2)
            where T : unmanaged
                => throw new ArgumentException($"{pow2} is not a power of 2");

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
        /// 2^8 = 256 = UInt8.MaxValue + 1
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
        /// 2^16 = 65,536 = UInt16.MaxValue + 1
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
        /// 2^26 = 67,108,864 = 0x4000000
        /// </summary>
        public const int T26 = 2*T25;
        
        /// <summary>
        /// 2^27 = 134,217,728 = 0x8000000
        /// </summary>
        public const int T27 = 2*T26;
        
        /// <summary>
        /// 2^28 = 268,435,456 = 0x10000000
        /// </summary>
        public const int T28 = 2*T27;
        
        /// <summary>
        /// 2^29 = 536,870,912 = 0x20000000;
        /// </summary>
        public const int T29 = 2*T28;
        
        /// <summary>
        /// 2^30 = 1,073,741,824 = 0x40000000
        /// </summary>
        public const int T30 = 2*T29;

        /// <summary>
        /// 2^31 - 1 = 2,147,483,647 = 0x7FFFFFFF
        /// </summary>
        public const uint T31m1 = int.MaxValue;

        /// <summary>
        /// 2^31 = 2,147,483,648 = 0x80000000
        /// </summary>
        public const uint T31 = 2*(uint)T30;

        /// <summary>
        /// 2^32 - 1 = 4,294,967,295 = 0xFFFFFFFF
        /// </summary>
        public const uint T32m1 = uint.MaxValue; 

        /// <summary>
        /// 2^32 = 4,294,967,296 = 0x100000000
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
        /// T63 = 9223372036854775808 
        /// </summary>
        public const ulong T63 = 2*(ulong)T62;


        static readonly ulong[] Powers = new ulong[]
        {
            T00, T01, T02, T03, T04, T05, T06, T07, 
            T08, T09, T10, T11, T12, T13, T14, T15, 
            T16, T17, T18, T19, T20, T21, T22, T23, 
            T24, T25, T26, T27, T28, T29, T30, T31, 
            T32, T33, T34, T35, T36, T37, T38, T39,
            T40, T41, T42, T43, T44, T45, T46, T47, 
            T48, T49, T50, T51, T52, T53, T54, T55, 
            T56, T57, T58, T59, T60, T61, T62, T63
        };

        static readonly IReadOnlyDictionary<ulong,byte> Inverted
            = Powers.Mapi((i,v) => (v,(byte)i)).ToDictionary();

    }
}