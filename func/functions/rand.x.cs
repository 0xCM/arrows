//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {

        /// <summary>
        /// Shuffles span content in-place via the provided source
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="io">The input/output span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> Shuffle<T>(this IRandomSource random, Span<T> io)
        {
            for (int i = 0; i < io.Length; i++)
                swap(ref io[i], ref io[i + random.NextInt32(io.Length - i)]);
            return io;
        }

        /// <summary>
        /// Shuffles array content in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="io">The input/output span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Shuffle<T>(this IRandomSource random, T[] io)
        {
            for (int i = 0; i < io.Length; i++)
                swap(ref io[i], ref io[i + random.NextInt32(io.Length - i)]);
            return io;
        }

        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IRandomSource random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());    

        /// <summary>
        /// Shuffles a permutation in-place
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Permutation Shuffle(this IRandomSource random, Permutation src)
        {
            random.Shuffle(src.Data);
            return src;
        }

        /// <summary>
        /// Shuffles a copy of the source permutatiion, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Permutation Shuffle(this IRandomSource random, in Permutation src)  
            => Permutation.Define(random.Shuffle(src.Replicate().Data));

    
        [MethodImpl(Inline)]
        public static Permutation<N,T> Shuffle<N,T>(this IRandomSource random, Permutation<N,T> src)
            where N : ITypeNat, new()
            where T : struct
        {
            random.Shuffle(src.Terms);
            return src;
        }
        
    }

}
