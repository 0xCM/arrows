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

    using static zfunc;

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
 
        /// <summary>
        /// Produces a random bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IRandomSource random, int minlen, int maxlen)
        {
            var len = random.Next(closed(minlen,maxlen+1));
            return random.Bits().TakeSpan(len).ToBitString();
        }

        /// <summary>
        /// Produces a random bitstring with a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IRandomSource random, int len)
            => Z0.BitString.FromBits(random.Bits().Take(len));

        /// <summary>
        /// Produces a random bitstring with a specified natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString<N>(this IRandomSource random, N n = default)
            where N : ITypeNat, new()
                => Z0.BitString.FromBits(random.Bits().Take((int)n.value));

        /// <summary>
        /// Produces sequences of random bitstrings with specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The length of the produced bitstrings</param>
        public static IEnumerable<BitString> BitStrings(this IRandomSource random, int len)
        {
            while(true)
                yield return random.BitString(len);
        }

        /// <summary>
        /// Produces a random sequence of bitstrings with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
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