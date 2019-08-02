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

    public static class GetNext
    {

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static byte Next(this IRandomSource<byte> src, byte max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ushort Next(this IRandomSource<ushort> src, ushort max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static uint Next(this IRandomSource<uint> src, uint max)
            => src.Next().Contract(max);

        /// <summary>
        /// Yields the next random value from the source that conforms to a specified upper bound
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="max">The exclusive upper bound</param>
        [MethodImpl(Inline)]
        public static ulong Next(this IRandomSource<ulong> src, ulong max) 
            => src.Next().Contract(max);


        /// <summary>
        /// Generates a psedorandom int in the interval [0, max) if max >= 0
        /// </summary>
        /// <param name="random">The stateful source on which the generation is predicated</param>
        /// <param name="max">The exclusive maximum</param>
        [MethodImpl(Inline)]
        internal static int NextInt32(this IRandomSource<ulong> random, int max)
            => max >= 0 ? (int)random.Next((ulong)max) 
                : - (int)random.Next((ulong) (Int32.MaxValue + max));        

    }

}