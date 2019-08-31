//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    /// <summary>
    /// Classifies the chronological disposition of one instant in time with respect to another
    /// </summary>
    public enum TimeMarker : byte
    {
        /// <summary>
        /// Indicates the subject is antecedent to the comperand
        /// </summary>
        Before,
        
        /// <summary>
        /// Indicates the subject is identical to the comperand
        /// </summary>
        Matches,
        
        /// <summary>
        /// Indicates the subject follows the comperand
        /// </summary>
        After,

        /// <summary>
        /// Indicates the subject is inclusively between a start date and an end date
        /// </summary>
        Between
    }


}