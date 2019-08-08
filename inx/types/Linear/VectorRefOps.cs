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

    public static class VectorRefOps
    {
        [MethodImpl(Inline)]
        public static ref Covector<N,T> Add<N,T>(ref Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.add(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(ref Vector<N,T> x, in Vector<N,T> y)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(x.Unsized, y.Unsized);
            return ref x;
        }

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(in Vector<N,T> x, in Vector<N,T> y, ref Vector<N,T> z)
            where N : ITypeNat, new()
            where T : struct    
        {
            gmath.add(x.Unsized, y.Unsized, z.Unsized);
            return ref z;
        }
    }
}