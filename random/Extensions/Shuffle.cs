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

    public static class ShuffleX
    {
        public static Span<T> Shuffle<T>(this Span<T> io, IRandomSource random = null)
        {
            random = random ?? RNG.Default;
            var last = io.Length - 1;
            for (int i = last; i > 0; i--)
            {
                int j = random.NextInt(i + 1);
                var temp = io[i];
                io[i] = io[j];
                io[j] = temp;
            }
            return io;
        }

        [MethodImpl(Inline)]
        public static Span<T> Shuffle<T>(this ReadOnlySpan<T> src, IRandomSource random = null)
            => src.Replicate().Shuffle(random ?? RNG.Default);
 
        public static Perm Shuffle(this Perm src, IRandomSource random = null)
        {
            random = random ?? RNG.Default;
            var last = src.Length - 1;
            for (int i = last; i > 0; i--)
            {
                int j = random.NextInt(i + 1);
                src.Transpose(i,j);
            }
            return src;            
        }
    }
}