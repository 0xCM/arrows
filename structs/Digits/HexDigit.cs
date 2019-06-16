//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static HexDigit;

    /// <summary>
    /// Defines the literals that constitute the base-16 digits
    /// </summary>
    public enum HexDigit : byte
    {
        /// <summary>
        /// Specifies 0 base 16
        /// </summary>
        X0 = 0x0,

        /// <summary>
        /// Specifies 1 base 16
        /// </summary>
        X1 = 0x1,
        
        /// <summary>
        /// Specifies 2 base 16
        /// </summary>
        X2 = 0x2,
        
        /// <summary>
        /// Specifies 3 base 16
        /// </summary>
        X3 = 0x3,

        /// <summary>
        /// Specifies 4 base 16
        /// </summary>
        X4 = 0x4,

        /// <summary>
        /// Specifies 5 base 16
        /// </summary>
        X5 = 0x5,

        /// <summary>
        /// Specifies 6 base 16
        /// </summary>
        X6 = 0x6,

        /// <summary>
        /// Specifies 7 base 16
        /// </summary>
        X7 = 0x7,
        
        /// <summary>
        /// Specifies 8 base 16
        /// </summary>
        X8 = 0x8,
        
        /// <summary>
        /// Specifies 9 base 16
        /// </summary>
        X9 = 0x9,

        /// <summary>
        /// Specifies 10 base 16
        /// </summary>
        XA = 0xA,

        /// <summary>
        /// Specifies 11 base 16
        /// </summary>
        XB = 0xB,

        /// <summary>
        /// Specifies 12 base 16
        /// </summary>
        XC = 0xC,

        /// <summary>
        /// Specifies 13 base 16
        /// </summary>
        XD = 0xD,

        /// <summary>
        /// Specifies 14 base 16
        /// </summary>
        XE = 0xE,

        /// <summary>
        /// Specifies 14 base 16
        /// </summary>
        XF = 0xF,

        /// <summary>
        /// Identifies the zero digit
        /// </summary>
        Zero = X0,

        /// <summary>
        /// Identifies the one digit
        /// </summary>
        One = X1,
        
        /// <summary>
        /// Identifies the last digit
        /// </summary>
        Last = XF,
        
        /// <summary>
        /// Specifies the base to which the digits are relative (10)
        /// </summary>
        Base = Last + X1
    }

 
}