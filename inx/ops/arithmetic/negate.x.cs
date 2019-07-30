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
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        public static Vec128<T> Negate<T>(in this Vec128<T> src)
            where T : struct
                => ginx.negate(in src);

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        public static Vec256<T> Negate<T>(in this Vec256<T> src)
            where T : struct
                => ginx.negate(in src);
    }
}
