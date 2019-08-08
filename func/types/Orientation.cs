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

}