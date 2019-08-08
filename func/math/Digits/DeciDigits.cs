//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static DeciDigit;

    public static class DeciDigits
    {
        static readonly IReadOnlyDictionary<char, DeciDigit> Index 
            = new Dictionary<char, DeciDigit>
            {
                ['0'] = D0, ['1'] = D1, ['2'] = D2, ['3'] = D3, 
                ['4'] = D4, ['5'] = D5, ['6'] = D6, ['7'] = D7,
                ['8'] = D8, ['9'] = D9, 
            };

        /// <summary>
        /// Parses the decimal digit if possible; oterwise, raises an error
        /// </summary>
        /// <param name="c">The source character</param>
        public static DeciDigit Parse(char c)
            => Index.TryFind(c).OnNone( () => throw new Exception($"There is no decimal digit corresponding the the character '{c}'")).Value();

        /// <summary>
        /// Parses valid decimail digits from the source string
        /// </summary>
        /// <param name="src">The source string</param>
        public static Span<DeciDigit> Parse(string src)
        {
            var len = src.Length;
            var dst = span<DeciDigit>(len);
            for(var i = 0; i< len; i++)
                dst[i] = Parse(src[i]);            
            return dst;            
        }

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(byte src)
            => src.ToString().Select(DeciDigits.Parse).ToArray();

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(ushort src)
            => src.ToString().Select(DeciDigits.Parse).ToArray();

        /// <summary>
        /// Gets the sequence of decimal digits defined by a source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static DeciDigit[] Get(uint src)
            => src.ToString().Select(DeciDigits.Parse).ToArray();

    }
}