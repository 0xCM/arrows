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
        /// Indicates a value is strictly less than the comperand
        /// </summary>
        Before,
        
        /// <summary>
        /// Indicates a value is identical to the comperand
        /// </summary>
        Matches,
        
        /// <summary>
        /// Indicates a subject date is strictly greater than the comperand
        /// </summary>
        After,

        /// <summary>
        /// Indicates a date is inclusively between a start date and an end date
        /// </summary>
        Between
    }

    /// <summary>
    ///  Satisfied when a test date t is oriented  with the parameter(s) according to the
    /// specified orientation
    /// </summary>
    public readonly struct DateOrientation
    {        
        public DateOrientation(TimeMarker orientation, VarExpr<Date> param1, VarExpr<Date>? param2 = null)
        {
            this.Param1 = param1;
            this.Param2 = param2;
            this.Orientation = orientation;
        }

        public readonly VarExpr<Date> Param1;

        public readonly VarExpr<Date>? Param2;

        public readonly TimeMarker Orientation;

    }

}