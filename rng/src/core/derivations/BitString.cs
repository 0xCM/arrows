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
        /// Defines a point source that produces bitstring with varying lengths
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The potential bitstring lengths</param>
        [MethodImpl(Inline)]
        public static IPointSource<BitString> BitStringSource(this IPolyrand random, Interval<int> length)        
            => new BitStringSource(random, length);

        /// <summary>
        /// Converts a point source to a bitstram
        /// </summary>
        /// <param name="src">The point source</param>
        /// <typeparam name="T">The point type</typeparam>
        [MethodImpl(Inline)]
        public static IRandomStream<Bit> ToBitStream<T>(this IPointSource<T> src)
            where T : unmanaged
                => BitSource<T>.From(src);    
        
        /// <summary>
        /// Produces a stream of random bits
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<Bit> Bits(this IPolyrand random)
            => random.PointSource<ulong>().ToBitStream();

        /// <summary>
        /// Produces a random bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int minlen, int maxlen)
        {
            var count = 1 + random.Next(minlen, maxlen) >> 6;
            var data = random.Span<ulong>(count);
            return data.ToBitString().Truncate(maxlen);
        }

        /// <summary>
        /// Produces a random bitstring with randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The mininimum length of the bitstring</param>
        /// <param name="maxlen">The maximum length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, Interval<int> length)
            => random.BitString(length.Left, length.Right);

        /// <summary>
        /// Produces a random bitstring with a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString(this IPolyrand random, int len)
        {
            var count = 1 + len >> 6;
            var data = random.Span<ulong>(count);
            return data.ToBitString().Truncate(len);
        }

        /// <summary>
        /// Produces a random bitstring with a specified natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitstring length</param>
        [MethodImpl(Inline)]
        public static BitString BitString<N>(this IPolyrand random, N n = default)
            where N : ITypeNat, new()
                => random.BitString((int)n.value);

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

            return stream(produce(), random.RngKind);
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
            
            return stream(produce(), random.RngKind);
        }
    }
}