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
        public static Perm Shuffle(this IRandomSource random, Perm src)
        {
            src.Shuffle(random);
            return src;
        }

        /// <summary>
        /// Shuffles a copy of the source permutatiion, leaving the original intact.
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="src">The permutation</param>
        [MethodImpl(Inline)]
        public static Perm Shuffle(this IRandomSource random, in Perm src) 
        { 
            var copy = src.Replicate();
            copy.Shuffle(random);
            return copy;
        }

    
        [MethodImpl(Inline)]
        public static Perm<N,T> Shuffle<N,T>(this IRandomSource random, Perm<N,T> src)
            where N : ITypeNat, new()
            where T : struct
        {
            src.Shuffle(random);
            return src;
        }
        
    }

}
