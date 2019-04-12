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

    /// <summary>
    /// Provies access to all primitive operations that are defined
    /// </summary>
    public static class primops
    {
        /// <summary>
        /// Returns the primitive operations available for a speicified type, if any; otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        [MethodImpl(Inline)]    
        public static Operative.PrimOps<T> typeops<T>()
            where T : struct, IEquatable<T>
                => Z0.Reify.PrimOps<T>.Inhabitant;

        /// <summary>
        /// Returns the primitive operations available for a speicified type, if any; otherwise,
        /// raises an error
        /// </summary>
        /// <param name="specimen">A value of the type to drive type inference</param>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        [MethodImpl(Inline)]    
        public static Operative.PrimOps<T> typeops<T>(T specimen)
            where T : struct, IEquatable<T>
                => Z0.Reify.PrimOps<T>.Inhabitant;

        /// <summary>
        /// Returns a primitive's zero value
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T zero<T>()        
            where T : struct, IEquatable<T>
                => typeops<T>().zero;

        /// <summary>
        /// Returns a primitive's zero value
        /// </summary>
        /// <param name="any">A value of the type to drive type inference</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T zero<T>(T any)        
            where T : struct, IEquatable<T>
                => typeops<T>().zero;

        /// <summary>
        /// Returns a primitive's one value
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T one<T>()        
            where T : struct, IEquatable<T>
                => typeops<T>().one;

        /// <summary>
        /// Returns a primitive's one value
        /// </summary>
        /// <param name="any">A value of the type to drive type inference</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T one<T>(T any)        
            where T : struct, IEquatable<T>
                => typeops<T>().one;

        /// <summary>
        /// For fixed-size types, returns the number of storage bits required;
        /// otherwise, returns 0.
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static uint bitsize<T>()        
            where T : struct, IEquatable<T>
                => typeops<T>().bitsize;

        /// <summary>
        /// For fixed-size types, returns the number of storage bits required;
        /// otherwise, returns 0.
        /// </summary>
        /// <param name="any">A value of the type to drive type inference</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static uint bitsize<T>(T any)        
            where T : struct, IEquatable<T>
                => typeops<T>().bitsize;

        /// <summary>
        /// Returns the smallest value that can be attained via the type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T minval<T>()
            where T : struct, IEquatable<T>
                => typeops<T>().numinfo.MinVal;
 

        /// <summary>
        /// Returns the greatest value that can be attained via the type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T maxval<T>()
            where T : struct, IEquatable<T>
                => typeops<T>().numinfo.MaxVal;
 

        /// <summary>
        /// Negates the source value for signable types; for unsignable types,
        /// reverses the bits in the underlying representation
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T negate<T>(T src)        
            where T : struct, IEquatable<T>
                => typeops<T>().negate(src);

        /// <summary>
        /// Negates the source value sfor signable types; for unsignable types,
        /// reverses the bits in the underlying representations
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> negate<T>(IReadOnlyList<T> src)        
            where T : struct, IEquatable<T>
                => typeops<T>().negate(src);

        /// <summary>
        /// Calculates the absolute value of the operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T abs<T>(T src)        
            where T : struct, IEquatable<T>
                => typeops<T>().abs(src);
        
        /// <summary>
        /// Calculates the absolute value of each item in a list
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> abs<T>(IReadOnlyList<T> src)        
            where T : struct, IEquatable<T>
                => typeops<T>().abs(src);

        /// <summary>
        /// Calculates the value of the operand incremented by one
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T inc<T>(T src)        
            where T : struct, IEquatable<T>
                => typeops<T>().inc(src);


        /// <summary>
        /// Calculates the value of each item incremented by one
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> inc<T>(IReadOnlyList<T> src)        
            where T : struct, IEquatable<T>
                => typeops<T>().inc(src);


        /// <summary>
        /// Calculates the value of the operand decremented by one
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T dec<T>(T src)        
            where T : struct, IEquatable<T>
                => typeops<T>().dec(src);

        /// <summary>
        /// Calculates the value of each item decremented by one
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> dec<T>(IReadOnlyList<T> src)        
            where T : struct, IEquatable<T>
                => typeops<T>().dec(src);

        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().add(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> add<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
            => typeops<T>().add(lhs,rhs);

        [MethodImpl(Inline)]
        public static T sub<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
            => typeops<T>().sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> sub<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> mul<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static T div<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().div(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> div<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().div(lhs,rhs);

        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> mod<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static T gcd<T>(T lhs, T rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> gcd<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)        
            where T : struct, IEquatable<T>
                => typeops<T>().gcd(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool eq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> eq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> neq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool lt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> lt<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> lteq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
            => typeops<T>().lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool gt<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
            => typeops<T>().gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> gt<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
            => typeops<T>().gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
            => typeops<T>().gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> gteq<T>(IReadOnlyList<T> lhs, IReadOnlyList<T> rhs)
            where T : struct, IEquatable<T>
            => typeops<T>().gteq(lhs,rhs);
                
        [MethodImpl(Inline)]   
        public static T and<T>(T lhs, T rhs) 
            where T : struct, IEquatable<T>
            => typeops<T>().and(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T or<T>(T lhs, T rhs) 
            where T : struct, IEquatable<T>
            => typeops<T>().or(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T xor<T>(T lhs, T rhs) 
            where T : struct, IEquatable<T>
            => typeops<T>().xor(lhs,rhs);

        [MethodImpl(Inline)]   
        public static T lshift<T>(T lhs, int rhs) 
            where T : struct, IEquatable<T>
            => typeops<T>().lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> lshift<T>(IReadOnlyList<T> src, int rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().lshift(src,rhs);

        [MethodImpl(Inline)]   
        public static T rshift<T>(T lhs, int rhs) 
            where T : struct, IEquatable<T>
                => typeops<T>().rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static IReadOnlyList<T> rshift<T>(IReadOnlyList<T> src, int rhs)
            where T : struct, IEquatable<T>
                => typeops<T>().rshift(src,rhs);

        [MethodImpl(Inline)]   
        public static T flip<T>(T src) 
            where T : struct, IEquatable<T>
                => typeops<T>().flip(src);

        [MethodImpl(Inline)]   
        public static BitString bitstring<T>(T src) 
            where T : struct, IEquatable<T>
                => typeops<T>().bitstring(src);

        [MethodImpl(Inline)]   
        public static IReadOnlyList<BitString> bitstring<T>(IReadOnlyList<T> src) 
            where T : struct, IEquatable<T>
                => map(src,bitstring);
            
        [MethodImpl(Inline)]
        public static bool testbit<T>(T src, int pos)
            where T : struct, IEquatable<T>
                => typeops<T>().testbit(src,pos);

        [MethodImpl(Inline)]
        public static IReadOnlyList<bool> testbit<T>(IReadOnlyList<T> src, int pos)
            where T : struct, IEquatable<T>
                => typeops<T>().testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit[] bits<T>(T src)
            where T : struct, IEquatable<T>
                => typeops<T>().bits(src);

        [MethodImpl(Inline)]
        public static T sqrt<T>(T src)
            where T : struct, IEquatable<T>
                => typeops<T>().sqrt(src);

        [MethodImpl(Inline)]
        public static T floor<T>(T src)
            where T : struct, IEquatable<T>
                => typeops<T>().floor(src);

        [MethodImpl(Inline)]
        public static T ceiling<T>(T src)
            where T : struct, IEquatable<T>
                => typeops<T>().ceiling(src);

        [MethodImpl(Inline)]
        public static T pow<T>(T src, int exp)
            where T : struct, IEquatable<T>
                => typeops<T>().pow(src,exp);
 
        [MethodImpl(Inline)]
        public static bool even<T>(T src)
            where T : struct, IEquatable<T>
                => typeops<T>().even(src);

        [MethodImpl(Inline)]
        public static T sin<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().sin(x);

        [MethodImpl(Inline)]
        public static T sinh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().sinh(x);

        [MethodImpl(Inline)]
        public static T asin<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().asin(x);

        [MethodImpl(Inline)]
        public static T asinh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().asinh(x);

        [MethodImpl(Inline)]
        public static T cos<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().cos(x);

        [MethodImpl(Inline)]
        public static T cosh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().cosh(x);

        [MethodImpl(Inline)]
        public static T acos<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().acos(x);

        [MethodImpl(Inline)]
        public static T acosh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().acosh(x);

        [MethodImpl(Inline)]
        public static T tan<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().tan(x);

        [MethodImpl(Inline)]
        public static T tanh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().tanh(x);

        [MethodImpl(Inline)]
        public static T atan<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().atan(x);

        [MethodImpl(Inline)]
        public static T atanh<T>(T x)
            where T : struct, IEquatable<T>
                => typeops<T>().atanh(x); 
    }
}