//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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

}
