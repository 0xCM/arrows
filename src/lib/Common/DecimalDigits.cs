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
    /// Defines the base 10 digits
    /// </summary>
    public enum DecimalDigit : byte
    {
        D0 = 0,
        D1 = 1,
        D2 = 2,
        D3 = 3,
        D4 = 4,
        D5 = 5,
        D6 = 6,
        D7 = 7,
        D8 = 8,
        D9 = 9,
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