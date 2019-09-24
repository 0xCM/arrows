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
        public static ref Vector<N,T> idiv<N,T>(Vector<N,T> lhs, Vector<N,T> rhs, ref Vector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            mathspan.idiv<T>(lhs.Data, rhs.Data, dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> fdiv<N,T>(Vector<N,T> lhs, Vector<N,T> rhs, ref Vector<N,T> dst)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            mathspan.fdiv<T>(lhs.Data, rhs.Data, dst.Data);
            return ref dst;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] / rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<T> div<T>(ref BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                mathspan.fdiv(lhs.Unblocked, rhs.Unblocked);
            else
                mathspan.idiv(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] / rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> div<N,T>(ref BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : unmanaged    
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                mathspan.fdiv(lhs.Unsized, rhs.Unsized);
            else
                mathspan.idiv(lhs.Unsized, rhs.Unsized);
            return ref lhs;
        }

    }

}