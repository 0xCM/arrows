//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;


    /// <summary>
    /// Defines orientation - a choice between exactly one of two values,
    /// e.g. top/bottom, front/back, left/right, true/false. The labels
    /// chosen - "Left" and "Right" reflect convention, not semantics
    /// </summary>
    /// <remarks> The most elementary and primitive perspective of duality</remarks>
    public enum Orientation : sbyte
    {        
        /// <summary>
        /// Specifies a leftward orientation
        /// </summary>
        Left = - 1,
        
        /// <summary>
        /// Specifies a rightward orientation
        /// </summary>
        Right = 1
    }

    /// <summary>
    /// Defines polarity - an optional choice between exactly one of two values
    /// From this perspective, an orientation can be viewed as a required choice
    /// of sign. Or, a sign can be viwed as a subsumption of orientation sans duality
    /// </summary>
    /// <remaks>
    /// Note also that this fills in the need for a true mathematical "sign": A number
    /// is either Negative, Positive or Neutral=0.
    /// </remaks>
    public enum Sign : sbyte
    {
        
        /// <summary>
        /// Specifies negative polarity and can be interpreted as mathematical sign
        /// </summary>
        Negative = -1,
        
        /// <summary>
        /// Specifies neutral polarity and from a mathemtatical perspectives gives 
        /// a sign classification to the number 0.
        /// </summary>
        Neutral = 0,
        
        
        /// <summary>
        /// Specifies positive polarity and can be interpreted as mathematical sign
        /// </summary>
        Positive = 1
    }


 
    public static class Pow2
    {


        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong mul(int exp, ulong factor)
            => pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static uint mul(int exp, uint factor)
            => (uint)pow(exp)*factor;

        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static int mul(int exp, int factor)
            => (int)pow(exp)*factor;

        public static intg<T> mul<T>(int exp, intg<T> factor)
            where T : struct, IEquatable<T>
                => 2.ToIntG<T>().pow(exp) * factor;

        /// <summary>
        /// Computes 2^i 
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong pow(int exp)
            => exp switch {
                0 => T00,
                1 => T01,
                2 => T02,
                3 => T03,
                4 => T04,
                5 => T05,
                6 => T06,
                7 => T07,
                8 => T08,
                9 => T09,
                10 => T10,
                11 => T11,
                12 => T12,
                13 => T13,
                14 => T14,
                15 => T15,
                16 => T16,
                17 => T17,
                18 => T18,
                19 => T19,
                20 => T20,
                21 => T21,
                22 => T12,
                23 => T23,
                _ => 0UL,
            };


        /// <summary>
        /// 2^0 = 1
        /// </summary>
        public const byte T00 = 0;

        /// <summary>
        /// 2^1 = 2
        /// </summary>
        public const byte T01 = 2;

        /// <summary>
        /// 2^2 = 4
        /// </summary>
        public const byte T02 = 2*2;

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

        /// <summary>
        /// 2^8 = 256
        /// </summary>
        public const ushort T08 = 2*T07;

        /// <summary>
        /// 2^9 = 512
        /// </summary>
        public const ushort T09 = 2*T08;

        /// <summary>
        /// 2^10 = 1024
        /// </summary>
        public const ushort T10 = 2*T09;
        
        /// <summary>
        /// 2^11 = 2056
        /// </summary>
        public const ushort T11 = 2*T10;
        
        /// <summary>
        /// 2^12 = 4096
        /// </summary>
        public const ushort T12 = 2*T11;

        /// <summary>
        /// 2^13 = 8192
        /// </summary>
        public const ushort T13 = 2*T12;

        /// <summary>
        /// 2^14 = 16,384
        /// </summary>
        public const ushort T14 = 2*T13;
        
        /// <summary>
        /// 2^15 = 32,768
        /// </summary>
        public const ushort T15 = 2*T14;

        /// <summary>
        /// 2^16 = 65,536
        /// </summary>
        public const uint T16 = 2*T15;
        
        /// <summary>
        /// 2^17 = 131,072
        /// </summary>
        public const uint T17 = 2*T16;

        /// <summary>
        /// 2^18 = 262,144
        /// </summary>
        public const uint T18 = 2*T17;

        /// <summary>
        /// 2^19 = 524,288
        /// </summary>
        public const uint T19 = 2*T18;

        /// <summary>
        /// 2^20 = 1,048,576
        /// </summary>
        public const uint T20 = 2*T19;
        
        /// <summary>
        /// 2^21 = 2,097,152
        /// </summary>
        public const uint T21 = 2*T20;

        /// <summary>
        /// 2^22 = 4,194,304
        /// </summary>
        public const uint T22 = 2*T21;

        /// <summary>
        /// 2^23 = 8,388,608
        /// </summary>
        public const uint T23 = 2*T22;
        
        /// <summary>
        /// 2^24 = 16,777,216
        /// </summary>
        public const uint T24 = 2*T23;

        public const uint T25 = 2*T24;
        public const ulong T26 = 2*T25;
        public const ulong T27 = 2*T26;
        public const ulong T28 = 2*T27;
        public const ulong T29 = 2*T28;
        public const ulong T30 = 2*T29;
        public const ulong T31 = 2*T30;
        public const ulong T32 = 2*T31;
        public const ulong T33 = 2*T32;
        public const ulong T34 = 2*T33;
        public const ulong T35 = 2*T34;
        public const ulong T36 = 2*T35;
        public const ulong T37 = 2*T36;
        public const ulong T38 = 2*T37;

    }


}