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

    partial class ginxs
    {
        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Next<T>(this Vec128<T> src)
            where T : unmanaged
                => ginx.next(src);

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Next<T>(this Vec256<T> src)
            where T : unmanaged
                => ginx.next(src);

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Prior<T>(this Vec128<T> src)
            where T : unmanaged
                => ginx.prior(src);

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Prior<T>(this Vec256<T> src)
            where T : unmanaged
                => ginx.prior(src);

    }
}
