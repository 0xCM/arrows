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
        public static Span<T> Shuffle<T>(this IRandomSource random, Span<T> io)
        {
            var last = io.Length - 1;
            for (int i = last; i > 0; i--)
            {
                int j = random.NextInt32(i + 1);
                var temp = io[i];
                io[i] = io[j];
                io[j] = temp;
            }
            return io;
        }

        public static Permutation<N,T> Shuffle<N,T>(this IRandomSource random, Permutation<N,T> src)
            where N : ITypeNat, new()
            where T : struct
        {            
            for (var i = src.Length; i >= 1; i--)
                src.Transpose((uint)i, random.Next(leftclosed(1u, (uint)i + 1u)));
            return src;            
        }

        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this IRandomSource random, ReadOnlySpan<T> src)
            => random.Shuffle(src.Replicate());
 
        public static Permutation Shuffle(this IRandomSource random, Permutation src)
        {
            var last = src.Length - 1;
            for (int i = last; i > 0; i--)
            {
                int j = random.NextInt32(i + 1);
                src.Transpose(i,j);
            }
            return src;            

        }
    }
}