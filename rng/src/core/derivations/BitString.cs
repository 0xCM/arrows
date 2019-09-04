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
    using static As;

    partial class RngX
    {
        /// <summary>
        /// Produces a stream of uniformly random bits
        /// </summary>
        /// <param name="random">The random source</param>
        public static IRandomStream<Bit> Bits(this IPolyrand random)
        {
            IEnumerable<Bit> produce()
            {
                while(true)
                {
                    var bs = random.Next<ulong>().ToBitString();
                    for(var i = 0; i< 64; i++)
                        yield return bs[i];                                    
                }
            }

            return stream(produce());
        }

        /// <summary>
        /// Produces a random bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int minlen, int maxlen)
            => random.Bits().TakeSpan(random.Next(minlen, maxlen)).ToBitString();

        /// <summary>
        /// Produces a random bitstring with a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int len)
            => Z0.BitString.FromBits(random.Bits().Take(len));

        /// <summary>
        /// Produces a random bitstring with a specified natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString<N>(this IPolyrand random, N n = default)
            where N : ITypeNat, new()
                => Z0.BitString.FromBits(random.Bits().Take((int)n.value));

        /// <summary>
        /// Produces sequences of random bitstrings with specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The length of the produced bitstrings</param>
        public static IRandomStream<BitString> BitStrings(this IPolyrand random, int len)
        {
            IEnumerable<BitString> produce()
            {
                while(true)
                    yield return random.BitString(len);
            }

            return stream(produce());
        }

        /// <summary>
        /// Produces a random sequence of bitstrings with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        public static IRandomStream<BitString> BitStrings(this IPolyrand random, int minlen, int maxlen)
        {
            IEnumerable<BitString> produce()
            {
                while(true)
                    yield return random.BitString(minlen,maxlen);
            }
            
            return stream(produce());
        }
    }
}