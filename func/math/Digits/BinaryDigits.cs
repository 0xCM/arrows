//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static BinaryDigit;
    using static zfunc;
    
    public static class BinaryDigits
    {
        /// <summary>
        /// Parses a binary digit if possible; otheriwise raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline)]
        public static BinaryDigit Parse(char c)
            => c == '0' ? Zed : c == '1' ? One 
                : throw new NotSupportedException($"{c}");

        /// <summary>
        /// Parses valid decimail digits from the source string, ignoring characters
        /// that aren't digits
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<BinaryDigit> Parse(ReadOnlySpan<char> src)
        {
            var offset = src.StartsWith("0b") ? 2 : 0;
            var len = src.Length - offset;
            var dst = span<BinaryDigit>(len);
            for(var i = offset; i< len; i++)
                dst[i] = Parse(src[i]);            
            return dst;
        }
 



    }
}