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
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Replicate<T>(this Vec128<T> src)
            where T : struct
                => Vec128.Load(src.ToSpan128());

        /// <summary>
        /// Clones the source vector and returns the resul
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Replicate<T>(this Vec256<T> src)
            where T : struct
                => Vec256.Load(src.ToSpan256());    
    }
}