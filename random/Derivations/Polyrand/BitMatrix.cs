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
        [MethodImpl(Inline)]
        public static BitMatrix4 BitMatrix4(this IPolyrand random)
            => Z0.BitMatrix4.Define(random.Next<ushort>());

        [MethodImpl(Inline)]
        public static BitMatrix8 BitMatrix8(this IPolyrand random)
            => Z0.BitMatrix8.Load(random.Next<ulong>());

        [MethodImpl(Inline)]
        public static BitMatrix16 BitMatrix16(this IPolyrand random)
            => Z0.BitMatrix16.Load(random.Span<ushort>(16));

        [MethodImpl(Inline)]
        public static BitMatrix32 BitMatrix32(this IPolyrand random)
            => Z0.BitMatrix32.Load(random.Memory<uint>(32));

        [MethodImpl(Inline)]
        public static BitMatrix64 BitMatrix64(this IPolyrand random)
            => Z0.BitMatrix64.Load(random.Span<ulong>(64));        
    
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> BitMatrix<M,N,T>(this IPolyrand random, M m = default, N n = default, T x = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BM.Load(random.Memory<T>(BitGrid.Specify(m,n,x).TotalCellCount),m,n);

        /// <summary>
        /// Produces an N-square natural bitmatrix
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The matrix order</param>
        /// <param name="rep">A scalar representative</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> BitMatrix<N,T>(this IPolyrand random, N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : struct
                => BM.Load(random.Memory<T>(BitGrid.Specify(n,n,rep).TotalCellCount), n);
                
    }

}