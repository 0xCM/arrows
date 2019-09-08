//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static zfunc;    

    public static class PermG
    {
        /// <summary>
        /// Defines an untyped identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        [MethodImpl(Inline)]
        public static PermG<T> Identity<T>(T n)
            where T : unmanaged
            => PermG<T>.Identity(n);
        
        /// <summary>
        /// Allocates an empty permutation of specified length
        /// </summary>
        [MethodImpl(Inline)]
        public static PermG<T> Alloc<T>(int n)
            where T : unmanaged
                => new PermG<T>(new T[n]);

        /// <summary>
        /// Creates a permutation by apply a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermG<T> FromSwaps<T>(T n, params (T i, T j)[] swaps)
            where T : unmanaged
                => new PermG<T>(n,swaps);

        /// <summary>
        /// Creates a permutation by apply a sequence of transpositions to the identity permutation
        /// </summary>
        /// <param name="n">The permutation length</param>
        /// <param name="swaps">Pairs of permutation indices (i,j) to be transposed</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermG<T> FromSwaps<T>(T n, params SwapG<T>[] swaps)
            where T : unmanaged
                => new PermG<T>(n,swaps);

        /// <summary>
        /// Creates a permutation from the elements in a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermG<T> From<T>(params T[] src)
            where T : unmanaged
            => new PermG<T>(src);

        /// <summary>
        /// Creates a permutation from the elements in a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The integral type</typeparam>
        [MethodImpl(Inline)]
        public static PermG<T> From<T>(ReadOnlySpan<T> src)
            where T : unmanaged
            => new PermG<T>(src.ToArray());

        /// <summary>
        /// Defines a transposition for a permutation of natural length
        /// </summary>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static SwapG<N,T> Swap<N,T>(T i, T j, N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => (i,j);

    }

}