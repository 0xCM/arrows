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
        /// Computes the canonical scalar product between two blocked vectors
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <typeparam name="T">The common vector component type</typeparam>
        [MethodImpl(Inline)]
        public static T dot<T>(BlockVector<T> x, BlockVector<T> y)
            where T : unmanaged
                => gmath.dot<T>(x.Unblocked, y.Unblocked);

        /// <summary>
        /// Commputes the canonical scalar product btween two blocked vectors of natural length
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The common component type</typeparam>
        [MethodImpl(Inline)]
        public static T dot<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
                => gmath.dot<T>(x.Unsized,y.Unsized);


    }

}