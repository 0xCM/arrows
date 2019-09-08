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
    using BM = Z0.BitMatrix;

    partial class RngX
    {
        /// <summary>
        /// Produces a 4x4 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 BitMatrix4(this IPolyrand random)
            => Z0.BitMatrix4.Define(random.Next<ushort>());

        /// <summary>
        /// Produces a 8x8 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix8(this IPolyrand random)
            => Z0.BitMatrix8.From(random.Next<ulong>());

        /// <summary>
        /// Produces a 16x16 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix16(this IPolyrand random)
            => Z0.BitMatrix16.From(random.MemorySpan<ushort>(16));

        /// <summary>
        /// Produces a 32x32 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix32(this IPolyrand random)
            => Z0.BitMatrix32.From(random.MemorySpan<uint>(32));

        /// <summary>
        /// Produces a 64x64 bitmatrix from a random source
        /// </summary>
        /// <param name="random">The random source</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix64(this IPolyrand random)
            => Z0.BitMatrix64.From(random.MemorySpan<ulong>(64));        
    
        /// <summary>
        /// Produces a generic bitmatrix of natural dimensions
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> BitMatrix<M,N,T>(this IPolyrand random, M m = default, N n = default, T rep = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BM.Load(random.Memory<T>(BitGrid.Specify(m,n,rep).TotalCellCount),m,n);

        /// <summary>
        /// Produces an generic bitmatrix of natural order
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> BitMatrix<N,T>(this IPolyrand random, N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BM.Load(random.Memory<T>(BitGrid.Specify(n,n,rep).TotalCellCount), n);                
    }
}