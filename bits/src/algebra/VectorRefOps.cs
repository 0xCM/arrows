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
        public static ref Vector<N,T> Add<N,T>(ref Vector<N,T> x, in Vector<N,T> y)
            where N : ITypeNat, new()
            where T : struct    
        {
            ginx.add<T>(x,y,x);
            return ref x;
        }

        [MethodImpl(Inline)]
        public static Covector<N,T> Add<N,T>(Covector<N,T> lhs, in Covector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => lhs.Transpose().Add(rhs.Transpose()).Transpose();

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

        [MethodImpl(Inline)]
        public static ref Vector<T> Add<T>(ref Vector<T> lhs, Vector<T> rhs)            
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gmath.add(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Sub<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gmath.sub(x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Mul<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gmath.mul(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Div<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                gfp.div(lhs.Unblocked, rhs.Unblocked);
            else
                gmath.idiv(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Mod<T>(ref Vector<T> lhs, Vector<T> rhs)
            where T : struct
        {
            var x = lhs.Unblocked;
            var y = rhs.Unblocked;
            gmath.mod(ref x, y);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Vector<T> Negate<T>(ref Vector<T> src)
            where T : struct
        {
            var x = src.Unblocked;
            gmath.negate(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Inc<T>(ref Vector<T> src)
            where T : struct
        {
            var x = src.Unblocked;
            gmath.inc(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Dec<T>(ref Vector<T> src)
            where T : struct
        {
            var x = src.Unblocked;
            gmath.dec(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<T> Abs<T>(ref Vector<T> src)
            where T : struct

        {
            var x = src.Unblocked;
            gmath.abs(x, x);
            return ref src;
        }


        [MethodImpl(Inline)]
        public static T Dot<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
            => gmath.dot<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> EqV<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
                => gmath.eq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> Gt<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
            => gmath.gt<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> GtEq<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
            => gmath.gteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> Lt<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
                => gmath.lt<T>(lhs.Unblocked, rhs.Unblocked);            

        [MethodImpl(Inline)]
        public static Span<bool> LtEq<T>(Vector<T> lhs, Vector<T> rhs)
            where T : struct
                => gmath.lteq<T>(lhs.Unblocked, rhs.Unblocked);

    }
}