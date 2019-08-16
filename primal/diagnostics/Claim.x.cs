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
    using System.Runtime.Serialization;
        
    using static zfunc;

    using static ErrorMessages;
    using Member = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;


    public static class RequireX
    {
        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void CLaimEqual(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.yea(lhs.ContentEqual(rhs), null, caller, file, line);

        /// <summary>
        /// Asserts content equality for two character spans
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void CLaimEqual(Span<char> lhs, ReadOnlySpan<char> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            => Claim.yea(lhs.ContentEqual(rhs), null, caller, file, line);

        /// <summary>
        /// Asserts content equality for two blocked spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEqual<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< Span128.Length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two blocked spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void ClaimEqual<T>(this Span128<T> lhs, Span128<T> rhs,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ReadOnly().ClaimEqual(rhs, caller, file, line);

        /// <summary>
        /// Asserts content equality for two blocked spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEqual<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two blocked spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void ClaimEqual<T>(this Span256<T> lhs, Span256<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ReadOnly().ClaimEqual(rhs, caller, file, line);

        /// <summary>
        /// Asserts content equality for two spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEqual<T>(this Span<T> lhs, Span<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.eq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        public static void ClaimEqual<T>(this Span<T> lhs, Span<T> rhs, T tolerance, Action<int,T,T> handler,  [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                {
                    handler(i, lhs[i], rhs[i]);
                    break;                    
                }  
        }

        public static void ClaimEqual<T>(this Span<T> lhs, Span<T> rhs, T tolerance, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {
            for(var i = 0; i< length(lhs,rhs); i++)
                if(!gmath.within(lhs[i],rhs[i],tolerance))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }


        /// <summary>
        /// Asserts content equality for two spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void ClaimEqual<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
        {            
            for(var i = 0; i< length(lhs,rhs); i++)
                if(gmath.neq(lhs[i],rhs[i]))
                    throw Errors.ItemsNotEqual(i, lhs[i], rhs[i], caller, file, line);
        }

        /// <summary>
        /// Asserts content equality for two spans of primal type
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void ClaimEqual<T>(this Span<T> lhs, ReadOnlySpan<T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : struct 
                => lhs.ReadOnly().ClaimEqual(rhs, caller, file, line);

        /// <summary>
        /// Asserts content equality for two primal spans of coincident natural dimension
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void ClaimEqual<M,N,T>(Span<M,N,T> lhs, Span<M,N,T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct 
                => lhs.Unsized.ClaimEqual(rhs.Unsized, caller, file, line);

        /// <summary>
        /// Asserts content equality for two primal spans of coincident natural length
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <param name="caller">The invoking function</param>
        /// <param name="file">The file in which the invoking function is defined </param>
        /// <param name="line">The file line number of invocation</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void ClaimEqual<N,T>(Span<N,T> lhs, Span<N,T> rhs, [Member] string caller = null, [File] string file = null, [Line] int? line = null)
            where N : ITypeNat, new()
            where T : struct 
                => lhs.Unsized.ClaimEqual(rhs.Unsized, caller, file, line);
    }

}