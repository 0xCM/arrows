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


    public static class VectorX
    {
        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.add(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Add<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            gmath.add(ref x, rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Vector<N,T> Sub<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.sub(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Mul<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mul(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Div<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.div(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Mod<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.mod(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> And<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.and(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> And<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.and(ref x, rhs);
            return ref lhs;
        }


        [MethodImpl(Inline)]
        public static ref Vector<N,T> Or<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.or(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Or<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.or(ref x, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> XOr<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.xor(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> XOr<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.xor(ref x, rhs);
            return ref lhs;
        }

       [MethodImpl(Inline)]
        public static ref Vector<N,T> Pow<N,T>(this ref Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            gmath.pow(ref x, y);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Pow<N,T>(this ref Vector<N,T> lhs, in T rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            gmath.pow(ref x, rhs);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Flip<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.flip(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Negate<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    
        {
            var x = src.Unsize();
            gmath.negate(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Inc<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.inc(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Dec<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.dec(ref x);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> Sqrt<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.sqrt(ref x);
            return ref src;
        }

       [MethodImpl(Inline)]
        public static ref Vector<N,T> Abs<N,T>(this ref Vector<N,T> src)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = src.Unsize();
            gmath.abs(ref x);
            return ref src;
        }


       [MethodImpl(Inline)]
        public static Vector<N,bool> Eq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.eq<T>(x, y).ToNatSpan<N,bool>();            
        }

       [MethodImpl(Inline)]
        public static Vector<N,bool> NEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.neq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Vector<N,bool> Gt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Vector<N,bool> GtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.gteq<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Vector<N,bool> Lt<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lt<T>(x, y).ToNatSpan<N,bool>();            
        }

        [MethodImpl(Inline)]
        public static Vector<N,bool> LtEq<N,T>(this in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    

        {
            var x = lhs.Unsize();
            var y = rhs.Unsize();
            return gmath.lteq<T>(x, y).ToNatSpan<N,bool>();            
        }


        [MethodImpl(Inline)]
        public static T Dot<N,T>(in Vector<N,T> lhs, in Vector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsize(),rhs.Unsize());

    }


}