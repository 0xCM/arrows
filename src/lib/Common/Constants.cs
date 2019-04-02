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

    public enum BinaryDigit : byte
    {
        B0 = 0,
        B1 = 1
    }

    public enum DecimalDigit : byte
    {
        D0 = 0,
        D1 = 1,
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D5 = 5,
        D6 = 6,
        D7 = 7,
        D8 = 8,
        D9 = 9,

    }

    public static class Pow2
    {


        /// <summary>
        /// Computes 2^i * rhs
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong mul(int exp, ulong factor)
            => pow(exp)*factor;

        public static intg<T> mul<T>(int exp, intg<T> factor)
            => 2.ToIntG<T>().pow(exp) * factor;

        /// <summary>
        /// Computes 2^i 
        /// </summary>
        /// <param name="exp">The exponent</param>
        public static ulong pow(int exp)
            => exp switch {
                0 => T0,
                1 => T1,
                2 => T2,
                3 => T3,
                4 => T4,
                5 => T5,
                6 => T6,
                7 => T7,
                8 => T8,
                9 => T9,
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


        public const byte T0 = 0; //1
        public const byte T1 = 2; //2
        public const byte T2 = 2*2; //4
        public const byte T3 = 2*T2; //8
        public const byte T4 = 2*T3; //16
        public const byte T5 = 2*T4; //32
        public const byte T6 = 2*T5; //64
        public const byte T7 = 2*T6; //128
        public const ulong T8 = 2*T7; //256
        public const ulong T9 = 2*T8; //512
        public const ulong T10 = 2*T9; //1024
        public const ulong T11 = 2*T10; //2056
        public const ulong T12 = 2*T11;
        public const ulong T13 = 2*T12;
        public const ulong T14 = 2*T13;
        public const ulong T15 = 2*T14;
        public const ulong T16 = 2*T15;
        public const ulong T17 = 2*T16;
        public const ulong T18 = 2*T17;
        public const ulong T19 = 2*T18;
        public const ulong T20 = 2*T19;
        public const ulong T21 = 2*T20;
        public const ulong T22 = 2*T21;
        public const ulong T23 = 2*T22;
        public const ulong T24 = 2*T23;
        public const ulong T25 = 2*T24;
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
    }

    

}