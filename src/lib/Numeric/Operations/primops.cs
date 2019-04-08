//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    public static class primops
    {
        /// <summary>
        /// Returns the primitive operations available for a speicified type, if any; otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        [MethodImpl(Inline)]    
        public static Operative.PrimOps<T> type<T>()
            => Z0.Reify.PrimOps<T>.Inhabitant;

        /// <summary>
        /// Returns the primitive operations available for a speicified type, if any; otherwise,
        /// raises an error
        /// </summary>
        /// <param name="specimen">A value of the type to drive type inference</param>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        [MethodImpl(Inline)]    
        public static Operative.PrimOps<T> type<T>(T specimen)
            => Z0.Reify.PrimOps<T>.Inhabitant;

        [MethodImpl(Inline)]
        public static T zero<T>()        
            => type<T>().zero;

        [MethodImpl(Inline)]
        public static T one<T>()        
            => type<T>().one;

        [MethodImpl(Inline)]
        public static uint bitsize<T>()        
            => type<T>().bitsize;

        [MethodImpl(Inline)]
        public static T negate<T>(T src)        
            => type<T>().negate(src);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> negate<T>(IReadOnlyList<T> src)        
            => type<T>().negate(src);

        [MethodImpl(Inline)]
        public static T abs<T>(T src)        
            => type<T>().abs(src);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> abs<T>(IReadOnlyList<T> src)        
            => type<T>().abs(src);

        [MethodImpl(Inline)]
        public static T inc<T>(T src)        
            => type<T>().inc(src);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> inc<T>(IReadOnlyList<T> src)        
            => type<T>().inc(src);

        [MethodImpl(Inline)]
        public static T dec<T>(T src)        
            => type<T>().dec(src);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> dec<T>(IReadOnlyList<T> src)        
            => type<T>().dec(src);

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)        
            => type<T>().add(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> add<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().add(lhs,rhs);

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)        
            => type<T>().sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> sub<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)        
            => type<T>().mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> mul<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)        
            => type<T>().div(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> div<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().div(lhs,rhs);

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)        
            => type<T>().mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> mod<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static T gcd<T>(T lhs, T rhs)        
            => type<T>().gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> gcd<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            => type<T>().gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            => type<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> eq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            => type<T>().neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> neq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            => type<T>().lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> lt<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            => type<T>().lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> lteq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            => type<T>().gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> gt<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            => type<T>().gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> gteq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().gteq(lhs,rhs);
                
        [MethodImpl(Inline)]   
        public static T and<T>(T lhs, T rhs) 
            => type<T>().and(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> and<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().and(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T or<T>(T lhs, T rhs) 
            => type<T>().or(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> or<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().or(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T xor<T>(T lhs, T rhs) 
            => type<T>().xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> xor<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            => type<T>().xor(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T lshift<T>(T lhs, int rhs) 
            => type<T>().lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> lshift<T>(IReadOnlyList<T> src, int rhs)
            => type<T>().lshift(src,rhs);

        [MethodImpl(Inline)]   
        public static T rshift<T>(T lhs, int rhs) 
            => type<T>().rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> rshift<T>(IReadOnlyList<T> src, int rhs)
            => type<T>().rshift(src,rhs);

        [MethodImpl(Inline)]   
        public static T flip<T>(T src) 
            => type<T>().flip(src);

        [MethodImpl(Inline)]   
        public static BitString bitstring<T>(T src) 
            => type<T>().bitstring(src);

        [MethodImpl(Inline)]   
        public static IReadOnlyList<BitString> bitstring<T>(IReadOnlyList<T> src) 
            => map(src,bitstring);
            
        [MethodImpl(Inline)]
        public static bool testbit<T>(T src, int pos)
            => type<T>().testbit(src,pos);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> testbit<T>(IReadOnlyList<T> src, int pos)
            => type<T>().testbit(src,pos);

        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            => type<T>().sqrt(src);

        [MethodImpl(Inline)]
        public static T floor<T>(T src)
            => type<T>().floor(src);

        [MethodImpl(Inline)]
        public static T ceiling<T>(T src)
            => type<T>().ceiling(src);

        [MethodImpl(Inline)]
        public static T pow<T>(T src, int exp)
            => type<T>().pow(src,exp);
 
        [MethodImpl(Inline)]
        public static bool even<T>(T src)
            => type<T>().even(src);

        [MethodImpl(Inline)]
        public static T sin<T>(T x)
            => type<T>().sin(x);

        [MethodImpl(Inline)]
        public static T sinh<T>(T x)
            => type<T>().sinh(x);

        [MethodImpl(Inline)]
        public static T asin<T>(T x)
            => type<T>().asin(x);

        [MethodImpl(Inline)]
        public static T asinh<T>(T x)
            => type<T>().asinh(x);

        [MethodImpl(Inline)]
        public static T cos<T>(T x)
            => type<T>().cos(x);

        [MethodImpl(Inline)]
        public static T cosh<T>(T x)
            => type<T>().cosh(x);

        [MethodImpl(Inline)]
        public static T acos<T>(T x)
            => type<T>().acos(x);

        [MethodImpl(Inline)]
        public static T acosh<T>(T x)
            => type<T>().acosh(x);

        [MethodImpl(Inline)]
        public static T tan<T>(T x)
            => type<T>().tan(x);

        [MethodImpl(Inline)]
        public static T tanh<T>(T x)
            => type<T>().tanh(x);

        [MethodImpl(Inline)]
        public static T atan<T>(T x)
            => type<T>().atan(x);

        [MethodImpl(Inline)]
        public static T atanh<T>(T x)
            => type<T>().atanh(x);

 
    }
}