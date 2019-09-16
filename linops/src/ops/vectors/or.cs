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

        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> or<N,T>(BlockVector<N,T> x, BlockVector<N,T> y, ref BlockVector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gbits.or(x.Data,y.Data,dst.Data);
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static BlockVector<N,T> or<N,T>(BlockVector<N,T> x, BlockVector<N,T> y)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            return or(x,y,ref dst);
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] | rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> or<N,T>(ref BlockVector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            gbits.or(lhs.Unsized, in rhs);
            return ref lhs;
        }

    }

}