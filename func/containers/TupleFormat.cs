//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the available tuple format styles that may
    /// be applied when representing a tuple as text
    /// </summary>
    public enum TupleFormat
    {
        /// <summary>
        /// Indicates a tuple text representation of the form "(x1,...xn)"
        /// </summary>
        Coordinate,

        /// <summary>
        /// Indicates a tuple text representation of the form "[x1,...xn]"
        /// </summary>
        List,

        /// <summary>
        /// Indicates a tuple text representation of the form "{x1,...xn}"
        /// </summary>
        Record
    }


}