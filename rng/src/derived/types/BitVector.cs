//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    using BV = Z0.BitVector;

    partial class RngD
    {
        [MethodImpl(Inline)]
        static IRandomStream<T> stream<T>(IEnumerable<T> src, RngKind rng)
            where T : struct
                =>  new RandomStream<T>(rng,src);

        /// <summary>
        /// Retrieves the next unsigned 4-bit value from the source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The selection domain</param>
        [MethodImpl(Inline)]
        public static UInt4 NextUInt4(this IPolyrand src, Interval<byte>? domain = null)
        {
            return domain.Map(d => (UInt4)src.Next(d.Left, d.Right),  () => (UInt4)src.Next<byte>());
        }

        /// <summary>
        /// Produces a random r-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector4 BitVector4(this IPolyrand random)
            => random.NextUInt4();

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector8(this IPolyrand random)
            => random.Next<byte>();

        /// <summary>
        /// Produces a random 16-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector16(this IPolyrand random)
            => random.Next<ushort>();

        /// <summary>
        /// Produces a 16-bit bitvector with a specified maximum width <= 16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="width">The with</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector16(this IPolyrand random, int maxwidth)
        {
            var v = random.Next<ushort>();
            return (v >>= (16-maxwidth));
        }

        /// <summary>
        /// Produces a random 32-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector32(this IPolyrand random)
            => random.Next<uint>();

        /// <summary>
        /// Produces a random 64-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector64(this IPolyrand random)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a random 128-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector128(this IPolyrand random)
            => random.BitVector(zfunc.n128);

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector(this IPolyrand random, N8 n)
            => random.Next<byte>();

        /// <summary>
        /// Produces a 16-bit bitvector with a specified maximum width <= 16
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="width">The with</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector(this IPolyrand random, N16 n, int? maxwidth = null)
        {
            var v = random.Next<ushort>();
            return maxwidth == null ? v : (v >>= (16-maxwidth));
        }

        /// <summary>
        /// Produces a 32-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The singleton value for n=32</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector(this IPolyrand random, N32 n)
            => random.Next<uint>();

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector(this IPolyrand random, N64 n)
            => random.Next<ulong>();

        /// <summary>
        /// Produces a random 128-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector(this IPolyrand random, N128 n)
            => (random.Next<ulong>(), random.Next<ulong>());

        /// <summary>
        /// Produces a stream of random 4-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector4> BitVectors(this IPolyrand random, N4 n)
        {
            IEnumerable<BitVector4> produce()
            {            
                while(true)
                    yield return random.NextUInt4();
            }

            return stream(produce(), random.RngKind);            
        }

        /// <summary>
        /// Produces a stream of random 8-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector8> BitVectors(this IPolyrand random, N8 n)
        {
            IEnumerable<BitVector8> produce()
            {            
                while(true)
                    yield return random.BitVector(n);
            }

            return stream(produce(), random.RngKind);            
        }            

        /// <summary>
        /// Produces a stream of random 16-bit bitvectors, optionally cropping with width to a specified maximum
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector16> BitVectors(this IPolyrand random, N16 n,  int? maxwidth = null)
        {
            IEnumerable<BitVector16> produce()
            {
                if(maxwidth != null)
                {
                    var mw = maxwidth.Value;
                    while(true)
                        yield return random.BitVector16(mw);
                }
                else
                {
                    while(true)
                        yield return random.BitVector16();
                }
            }

            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a stream of random 32-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector32> BitVectors(this IPolyrand random, N32 n)
        {
            IEnumerable<BitVector32> produce()
            {
                while(true)
                    yield return random.BitVector(n);

            }
            return stream(produce(), random.RngKind);
        }            

        /// <summary>
        /// Produces a stream of random 64-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector64> BitVectors(this IPolyrand random, N64 n)
        {
            IEnumerable<BitVector64> produce()
            {
                while(true)
                    yield return random.BitVector(n);
            }
            return stream(produce(), random.RngKind);
        }            

        /// <summary>
        /// Produces a stream of random 128-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IRandomStream<BitVector128> BitVectors(this IPolyrand random, N128 n)
        {
            IEnumerable<BitVector128> produce()
            {
                while(true)
                    yield return random.BitVector(n);

            }
            return stream(produce(), random.RngKind);
        }            

        /// <summary>
        /// Produces a generic bitvector of natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVector<N,T>(this IPolyrand random, N len = default, T rep = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => BV.Load<N,T>(random.Stream<T>().TakeSpan(BV.CellCount<N,T>()));

        /// <summary>
        /// Produces a random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, BitSize len)
            where T : unmanaged
                => BV.Load<T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(len)), len);

        /// <summary>
        /// Produces a random generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The inclusive minimum bitvector length</param>
        /// <param name="maxlen">The inclusive maximum bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, BitSize minlen, BitSize maxlen)
            where T : unmanaged
        {
            var len = random.Next<int>(minlen,++maxlen);
            return BV.Load<T>(random.Stream<T>().TakeArray(BV.CellCount<T>(len),len));
        }

        /// <summary>
        /// Produces a generic bitvector of randomized length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="range">The range of potential bitvector lengths</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IPolyrand random, Interval<int> range)
            where T : unmanaged
                => random.BitVector<T>(range.Left, range.Right);
                        

    }

}