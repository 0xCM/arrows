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

    partial class RngX
    {
        /// <summary>
        /// Produces a random r-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector4 BitVector4(this IRandomSource random)
            => BV.FromNibble(random.NextUInt4());

        /// <summary>
        /// Produces a stream of random 4-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector4> Bitvectors4(this IRandomSource random)
        {
            while(true)
                yield return random.NextUInt4();
        }

        /// <summary>
        /// Produces a random 8-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector8 BitVector8(this IRandomSource random)
            => random.NextUInt8();

        /// <summary>
        /// Produces a stream of random 8-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector8> BitVectors8(this IRandomSource random)
        {
            while(true)
                yield return random.BitVector8();
        }            

        /// <summary>
        /// Produces a random 16-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector16 BitVector16(this IRandomSource random)
            => random.NextUInt16();

        /// <summary>
        /// Produces a stream of random 16-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector16> BitVectors16(this IRandomSource random)
        {
            while(true)
                yield return random.BitVector16();
        }            

        /// <summary>
        /// Produces a random 32-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector32 BitVector32(this IRandomSource random)
            => random.NextUInt32();

        /// <summary>
        /// Produces a stream of random 32-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector32> BitVectors32(this IRandomSource random)
        {
            while(true)
                yield return random.BitVector32();
        }            

        /// <summary>
        /// Produces a random 64-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector64 BitVector64(this IRandomSource random)
            => random.NextUInt64();

        /// <summary>
        /// Produces a stream of random 64-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector64> BitVectors64(this IRandomSource random)
        {
            while(true)
                yield return random.BitVector64();
        }            

        /// <summary>
        /// Produces a random 128-bit bitvector
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitVector128 BitVector128(this IRandomSource random)
            => (random.NextUInt64(), random.NextUInt64());

        /// <summary>
        /// Produces a stream of random 128-bit bitvectors
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector128> BitVectors128(this IRandomSource random)
        {
            while(true)
                yield return random.BitVector128();
        }            

        /// <summary>
        /// Produces a random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> BitVector<T>(this IRandomSource random, BitSize len)
            where T : struct
                => BV.FromCells<T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(len)));

        /// <summary>
        /// Produces a stream random generic bitvector of specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector<T>> BitVectors<T>(this IRandomSource random, BitSize len)
            where T : struct
        {
            var cells = BV.CellCount<T>(len);
            var src = random.Stream<T>();
            while(true)
                yield return BV.FromCells(src.TakeSpan(cells));
        }
                        
        /// <summary>
        /// Produces a stream random bitvectors of generic type and varying lengths
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="minlen">The minimum length</param>
        /// <param name="maxlen">The maximum length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector<T>> BitVectors<T>(this IRandomSource random, BitSize minlen, BitSize maxlen)
            where T : struct
        {
            var counts = random.Stream<int>(minlen, maxlen);
            var src = random.Stream<T>();
            while(true)
            {
                var bitcount = counts.First();
                var cellcount = BV.CellCount<T>(bitcount);
                yield return BV.FromCells(bitcount, src.TakeArray(cellcount));
            }
        }

        /// <summary>
        /// Produces a stream random bitvectors of generic type and varying lengths
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The range of vector lengths</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<BitVector<T>> BitVectors<T>(this IRandomSource random, Interval<int> length)
            where T : struct
                => random.BitVectors<T>(length.Left, length.Right);

        /// <summary>
        /// Produces a random bitvector of natural length and generic type
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVector<N,T>(this IRandomSource random, N len = default)
            where T : struct
            where N : ITypeNat, new()
                => BV.FromCells<N,T>(random.Stream<T>().TakeSpan(BV.CellCount<T>(nati<N>())));

        /// <summary>
        /// Produces a stream random bitvectors of natural length and generic type
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The bitvector length</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> BitVectors<N,T>(this IRandomSource random, N len = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var cells = BV.CellCount<T>(len.value);
            var src = random.Stream<T>();
            while(true)
                BV.FromCells(src.TakeSpan(cells),len);
        }
    }

}