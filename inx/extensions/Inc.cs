//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    partial class InXtend
    {
        /// <summary>
        /// Increments each component of the input vector by one
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Inc<T>(in this Vec128<T> src)
            where T : struct
                => ginx.inc(in src);

        /// <summary>
        /// Increments each component of the input vector by one
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Inc<T>(in this Vec256<T> src)
            where T : struct
                => ginx.inc(in src);
    }
}
