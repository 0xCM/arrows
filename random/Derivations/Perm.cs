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
        /// Produces a random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        [MethodImpl(Inline)]
        public static Perm Perm(this IRandomSource random, int len)
            => Z0.Perm.Identity(len).Shuffle(random);

        /// <summary>
        /// Produces a stream of random permutation of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<Perm> Perms(this IRandomSource random, int len)
        {
            while(true)
                yield return random.Perm(len);
        }

        /// <summary>
        /// Produces a random permutation of natural length N
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        [MethodImpl(Inline)]
        public static Perm<N> Perm<N>(this IRandomSource random, N n = default)
            where N : ITypeNat, new()
                => Z0.Perm.Identity(n).Shuffle(random);

        /// <summary>
        /// Produces a stream of random permutation of natural length N
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="n">The length representative</param>
        /// <param name="rep">A primal type representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal symbol type</typeparam>
        public static IEnumerable<Perm<N>> Perms<N>(this IRandomSource random, N n = default)
            where N : ITypeNat, new()
        {
            while(true)
                yield return random.Perm(n);
        }
                
    }

}