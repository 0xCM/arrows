//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static As;

    public static class RandSynth
    {
        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand ToPolyrand(this IPointSource<ulong> source)        
            => RNG.Polyrand(source);

        /// <summary>
        /// Creates a polyrand rng from a random source
        /// </summary>
        /// <param name="rng">The source rng</param>
        [MethodImpl(Inline)]
        public static IPolyrand ToPolyrand(this IRandomSource rng)
            => new Polyrand(rng);

        /// <summary>
        /// Derives a rng source from a uint64 point source
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The range of potential values</param>
        public static IRandomSource ToRandSource(this IPointSource<ulong> src)
            => new RandomSource(src);

        /// <summary>
        /// Creates a System.Random rng from a random source
        /// </summary>
        /// <param name="rng"></param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IRandomSource rng)
            => new SysRand(rng);        

    }


}