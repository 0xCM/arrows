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

    public static class PowersOfTwo
    {
        public const long N0 = 2^0; //1
        public const long N1 = 2^1; //2
        public const long N2 = 2^2; //4
        public const long N3 = 2^3; //8
        public const long N4 = 2^4; //16
        public const long N5 = 2^5; //32
        public const long N6 = 2^6; //64
        public const long N7 = 2^7; //128
        public const long N8 = 2^8; //256
        public const long N9 = 2^9; //512
        public const long N10 = 2^10; //1024
        public const long N11 = 2^11; //2056
        public const long N12 = 2^12;
        public const long N13 = 2^13;
        public const long N14 = 2^14;
        public const long N15 = 2^15;
    }

}