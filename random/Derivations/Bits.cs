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
    using System.Numerics;
    using System.Text;

    using static zfunc;
    using static As;

    partial class RngX
    {        
        /// <summary>
        /// Produces a stream of uniformly random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<Bit> Bits(this IRandomSource random)
        {
            while(true)
            {
                var bs = random.NextUInt64().ToBitString();
                for(var i = 0; i< 64; i++)
                    yield return bs[i];
                                    
            }
        }
 
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

        /// <summary>
        /// Produces a stream of random bytes
        /// </summary>
        /// <param name="random">The random source</param>
        public static IEnumerable<byte> Bytes(this IRandomSource random)
        {
            while(true)
            {
                var bytes = BitConverter.GetBytes(random.NextUInt64());
                for(var i = 0; i< bytes.Length; i++)
                    if(i == 0)
                        yield return bytes[i];
            }
        }

    }
}