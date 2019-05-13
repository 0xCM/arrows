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
 
    using static zfunc;
    using static HexDigit;

    public static class HexDigits
    {
        static readonly IReadOnlyDictionary<char, HexDigit> Index 
            = new Dictionary<char, HexDigit>
            {
                ['0'] = X0, ['1'] = X1, ['2'] = X2, ['3'] = X3, 
                ['4'] = X4, ['5'] = X5, ['6'] = X6, ['7'] = X7,
                ['8'] = X8, ['9'] = X9, ['A'] = XA, ['B'] = XB,
                ['C'] = XC, ['D'] = XD, ['E'] = XE, ['F'] = XF
            };

        /// <summary>
        /// Parses the Hex digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static HexDigit Parse(char c)
            => Index.TryFind(c).Require();

        /// <summary>
        /// Parses valid hex digits from the source string, ignoring characters
        /// that aren't digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<HexDigit> Parse(string src)
        {            
            var offset = src.StartsWithAny(items("0x","0X"))  ? 2 : 0;
            var len = src.Length - offset;
            var dst = span<HexDigit>(len);
            for(var i = offset; i< len; i++)
                dst[i] = Parse(src[i]);            
            return dst;            
        }
    }
}
