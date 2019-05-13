//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using static DeciDigit;

    /// <summary>
    /// Defines the literals that constitute the base-10 digits
    /// </summary>
    public enum DeciDigit : byte
    {
        /// <summary>
        /// Specifies 0 base 10
        /// </summary>
        D0 = 0,

        /// <summary>
        /// Specifies 1 base 10
        /// </summary>
        D1 = 1,
        
        /// <summary>
        /// Specifies 2 base 10
        /// </summary>
        D2 = 2,
        
        /// <summary>
        /// Specifies 3 base 10
        /// </summary>
        D3 = 3,

        /// <summary>
        /// Specifies 4 base 10
        /// </summary>
        D4 = 4,

        /// <summary>
        /// Specifies 5 base 10
        /// </summary>
        D5 = 5,

        /// <summary>
        /// Specifies 6 base 10
        /// </summary>
        D6 = 6,

        /// <summary>
        /// Specifies 7 base 10
        /// </summary>
        D7 = 7,
        
        /// <summary>
        /// Specifies 8 base 10
        /// </summary>
        D8 = 8,
        
        /// <summary>
        /// Specifies 9 base 10
        /// </summary>
        D9 = 9,

        /// <summary>
        /// Identifies the zero digit
        /// </summary>
        Zero = D0,

        /// <summary>
        /// Identifies the one digit
        /// </summary>
        One = D1,
        
        /// <summary>
        /// Identifies the last digit
        /// </summary>
        Last = D9,
        
        /// <summary>
        /// Specifies the base to which the digits are relative (10)
        /// </summary>
        Base = Last + D1
    }


}