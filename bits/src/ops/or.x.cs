//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static dinx;
    using static As;
    
    
    partial class BitsX
    {
        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Or<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => gbits.or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Or<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => gbits.or(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static void Or<T>(this Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
                => gbits.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or<T>(this Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
                => gbits.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static Span128<T> Or<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
                => gbits.or(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span256<T> Or<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
                => gbits.or(lhs,rhs,dst);
 
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> Or<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Unsized.ReadOnly().Or(rhs.Unsized, lhs.Unsized);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Or<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gbits.or(in x, y);
            return ref lhs;
        }

   }
}