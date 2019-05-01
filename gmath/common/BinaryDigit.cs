//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static BinaryDigit;

    using static zcore;

    public static class BinaryDigits
    {
        /// <summary>
        /// Parses a binary digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static BinaryDigit parse(char c)
            => c switch{
                '0' => B0,
                '1' => B1,
                _ => throw new NotSupportedException($"{c}")
            };

        /// <summary>
        /// Parses valid decimail digits from the source string, ignoring characters
        /// that aren't digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static IReadOnlyList<BinaryDigit> parse(string src)
        {
            var digits = new List<BinaryDigit>(src.Length);
            foreach(var c in src)
                if(Char.IsDigit(c))
                    digits.Add(parse(c));
            return digits;
        }
    }


    /// <summary>
    /// Defines the literals that constitute the base-2 digits
    /// </summary>
    public enum BinaryDigit : uint
    {
        /// <summary>
        /// Specifies 0 base 2
        /// </summary>
        B0 = 0,
        
        /// <summary>
        /// Specifies 1 base 2
        /// </summary>
        B1 = 1,

        /// <summary>
        /// Identifies the zero digit
        /// </summary>
        Zero = B0,

        /// <summary>
        /// Identifies the one digit
        /// </summary>
        One = B1,
        
        /// <summary>
        /// Identifies the last digit
        /// </summary>
        Last = B1,
        
        /// <summary>
        /// Specifies the base to which the digits are relative (10)
        /// </summary>
        Base = Last + B1

    }


}