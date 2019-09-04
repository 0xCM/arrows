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


    public static partial class RngX
    {
        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand ToPolyrand(this IPointSource<ulong> source)        
            => new Polyrand(source);

        /// <summary>
        /// Creates a System.Random rng from a random source
        /// </summary>
        /// <param name="rng"></param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand rng)
            => SysRand.Derive(rng);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="random">The random source</param>
        public static IPolyrand ToPolyrand(this IStepwiseSource<ulong> random)
            => new Polyrand(random);

    }


}