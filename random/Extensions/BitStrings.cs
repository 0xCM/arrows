//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class RngX
    {
        [MethodImpl(Inline)]
        public static BitString BitString(this IRandomSource random, int minlen, int maxlen)
        {
            var len = random.Next(closed(minlen,maxlen+1));
            return random.Bits().TakeSpan(len).ToBitString();
        }

        public static IEnumerable<BitString> BitStrings(this IRandomSource random, int minlen, int maxlen)
        {
            while(true)
                yield return random.BitString(minlen,maxlen);
        }
    }
}    