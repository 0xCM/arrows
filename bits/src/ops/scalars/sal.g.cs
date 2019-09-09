//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    
    partial class gbits
    {
        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(T src, int offset)
            where T : struct
                => gmath.sal(src,offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards in-place by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sal<T>(ref T src, int offset)
            where T : struct
                => ref gmath.sal(ref src,offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(in T src, in uint offset)
            where T : struct
                => sal(src, (int)offset);

        /// <summary>
        /// Shifts the source value arithmetically leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The offset</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sal<T>(in T src, in ulong offset)
            where T : struct
                => sal(src, (int)offset);
    }

}