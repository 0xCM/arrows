//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using static DecimalDigit;



    /// <summary>
    /// Defines the literals that constitute the base-10 digits
    /// </summary>
    public enum DecimalDigit : uint
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


    public static class DecimalDigits
    {
        /// <summary>
        /// Parses the decimal digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static DecimalDigit parse(char c)
            => c switch{
                '0' => D0,
                '1' => D1,
                '2' => D2,
                '3' => D3,
                '4' => D4,
                '5' => D5,
                '6' => D6,
                '7' => D7,
                '8' => D8,
                '9' => D9,
                _ => throw new NotSupportedException($"{c}")
            };

        /// <summary>
        /// Parses valid decimail digits from the source string, ignoring characters
        /// that aren't digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static IReadOnlyList<DecimalDigit> parse(string src)
        {
            var digits = new List<DecimalDigit>(src.Length);
            foreach(var c in src)
                if(Char.IsDigit(c))
                    digits.Add(parse(c));
            return digits;
        }
    }
}