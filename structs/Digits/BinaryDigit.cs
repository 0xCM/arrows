//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Defines the literals that constitute the base-2 digits
    /// </summary>
    public enum BinaryDigit : byte
    {
        /// <summary>
        /// Specifies 0 base 2
        /// </summary>
        Zed = 0,
        
        /// <summary>
        /// Specifies 1 base 2
        /// </summary>
        One = 1,

        /// Identifies the last digit
        /// </summary>
        Last = One,
        
        /// <summary>
        /// Specifies the base to which the digits are relative (10)
        /// </summary>
        Base = Last + One

    }


}