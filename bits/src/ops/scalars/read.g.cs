//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    partial class gbits
    {
        /// <summary>
        /// Reads a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static Bit read<T>(in T src, in int pos)
            where T : struct
                => test(in src, in pos);

        /// <summary>
        /// Reads a position-identified bit
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="pos">The bit position</param>
        /// <typeparam name="T">The primal value type</typeparam>
        [MethodImpl(Inline)]
        public static Bit read<T>(in T src, in byte pos)
            where T : struct
                => test(in src, in pos);

    }

}