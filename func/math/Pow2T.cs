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
    using static Pow2;

    /// <summary>
    /// Defines pow2-related operations
    /// </summary>
    public readonly struct Pow2<T>
        where T : struct
    {
        internal static readonly Pow2<T> TheOnly = default;

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

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// and 2^i does not exceed the maximum value of T
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static T pow(byte i)
            => Unsafe.As<ulong,T>(ref Powers[i]);

        /// <summary>
        /// Computes 2^i where i is an integer value in the interval [0,63]
        /// and 2^i does not exceed the maximum value of T
        /// </summary>
        /// <param name="i">The exponent</param>
        [MethodImpl(Inline)]
        public static T pow(int i)
            => Unsafe.As<ulong,T>(ref Powers[i]);

        /// <summary>
        /// For i < j, computes the sequence 2^i, ..., 2^j 
        /// </summary>
        /// <param name="i">The minimum power</param>
        /// <param name="j">The maximum power</param>
        /// <typeparam name="T">The computation result type</typeparam>
        public static T[] powers(in byte i, in byte j)
        {   
            var dst = new T[j - i + 1];
            var current = i;
            var pos = 0;
            while(current <= j)
                dst[pos++] = pow(current++);
            return dst;
        }


        /// <summary>
        /// Solves for i in the equation n = 2^i
        /// </summary>
        /// <param name="n">The exponentiated value n such that 2^n <= 2^15</param>
        [MethodImpl(Inline)]
        public static byte inv(T n)
            => Inverted.TryGetValue(convert<T,ulong>(n), out byte e) ? e : Pow2Error(n);

        static byte Pow2Error(T pow2)
            => throw new ArgumentException($"{pow2} is not a power of 2");
    }

}