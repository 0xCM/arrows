//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {
        /// <summary>
        /// Negates the value of each source vector component in-place
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> negate<T>(ref BlockVector<T> src)
            where T : struct
        {
            gmath.negate(src.Unblocked);
            return ref src;
        }

        /// <summary>
        /// Negates the value of each source vector component in-place
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> negate<N,T>(ref BlockVector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsized;
            gmath.negate(src.Unsized);
            return ref src;
        }

    }

}