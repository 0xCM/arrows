//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static math;

    public static class RngSuites
    {
        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static Span<T> Next<T>(this Span<IPointSource<T>> generators)
            where T : struct
        {
            Span<T> dst = new T[generators.Length];
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static Span<T> Next<T>(this Span<IStepwiseSource<T>> generators)
            where T : struct
        {
            Span<T> dst = new T[generators.Length];
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static T[] Next<T>(this IPointSource<T>[] sources)
            where T : struct
        {
            var dst = new T[sources.Length];
            for(var i=0; i<sources.Length; i++)
                dst[i] = sources[i].Next();
            return dst;
        }

        /// <summary>
        /// Samples one point from each generator
        /// </summary>
        /// <param name="sources">A set of random point sources</param>
        public static T[] Next<T>(this IStepwiseSource<T>[] sources)
            where T : struct
        {
            var dst = new T[sources.Length];
            for(var i=0; i<sources.Length; i++)
                dst[i] = sources[i].Next();
            return dst;
        }

    }

}