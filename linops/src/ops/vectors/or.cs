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
            gbitspan.or(x.Data,y.Data,dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static BlockVector<T> or<T>(BlockVector<T> lhs, BlockVector<T> rhs)
            where T : unmanaged
        {
            var dst = lhs.Replicate(true);
            gbitspan.or(lhs.Data, rhs.Data, dst.Data);
            return dst;
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
        /// <param name="x">The left operand which will be updated in-place</param>
        /// <param name="k">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> or<N,T>(BlockVector<N,T> x, T k, ref BlockVector<N,T> z)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            gbitspan.or(x.Unsized, k, z.Unsized);
            return ref z;
        }

    }

}