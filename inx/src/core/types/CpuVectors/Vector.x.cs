//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static zfunc;    
    
    partial class dinxx
    {
        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec128<T> src)
            where T : struct            
                => Vec128<T>.Length;

        /// <summary>
        /// Specifies the length, i.e. the number of components, of an
        /// intrnsic vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static int Length<T>(this in Vec256<T> src)
            where T : struct            
                => Vec256<T>.Length;    

        /// <summary>
        /// Loads a 256-bit cpu vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToCpuVec256<T>(this Span256<T> src, int block = 0)
            where T : struct
                => Vec256.Load(ref src.Block(block));

        /// <summary>
        /// Loads a 128-bit cpu vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToCpuVec128<T>(this Span128<T> src, int block = 0)
            where T : struct
                => Vec128.Load(ref src.Block(block));

        /// <summary>
        /// Projects a 128-bit source vector into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec128<T> Map128<S,T>(this Vec128<S> src, Func<S,T> f)
            where T : struct
            where S : struct
        {
            var xLen = Math.Min(Vec128<S>.Length, Vec128<T>.Length);
            var dstLen = Vec128<T>.Length;
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(src[i]);
            return Vec128.Load(ref head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec128<T> Map128<S,T>(this Vec128<S> lhs, Vec128<S> rhs, Func<S,S,T> f)
            where T : struct
            where S : struct
        {
            var xLen = Math.Min(Vec128<S>.Length, Vec128<T>.Length);
            var dstLen = Vec128<T>.Length;
            var data = lhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhs[i],rhs[i]);
            return Vec128.Load(ref head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 256-bit target vector via alternating application of a mapping function
        /// dst[j] = f(lhs[i])
        /// dst[j+1] = f(rhs[i])
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec256<T> Map256<T>(this Vec128<T> lhs, Vec128<T> rhs, Func<T,T> f)
            where T : struct
        {
            var srcLen = Vec128<T>.Length;
            var dstLen = 2*srcLen;
            var data = lhs.ToSpan();
            Span<T> dst = new T[dstLen];
            var j=0;
            for(var i=0; i< srcLen; i++)
            {
                dst[j++] = f(lhs[i]);
                dst[j++] = f(rhs[i]);
            }
            
            return Vec256.Load(ref head(dst));        
        } 

        /// <summary>
        /// Projects a source vector into a target vector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec256<T> Map256<S,T>(this Vec256<S> src, Func<S,T> f)
            where T : struct
            where S : struct
        {
            var xLen = Math.Min(Vec256<S>.Length, Vec256<T>.Length);
            var dstLen = Vec256<T>.Length;
            var data = src.ToSpan();            
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(src[i]);            
            return Vec256.Load(ref head(dst));        
        } 

        /// <summary>
        /// Combines two 128-bit source vectors into a 128-bit target vector via a mapping function
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec256<T> Map256<S,T>(this Vec256<S> lhs, Vec256<S> rhs, Func<S,S,T> f)
            where T : struct
            where S : struct
        {
            var xLen = Math.Min(Vec256<S>.Length, Vec256<T>.Length);
            var dstLen = Vec256<T>.Length;
            var data = lhs.ToSpan();
            Span<T> dst = new T[dstLen];
            for(var i=0; i< xLen; i++)
                dst[i] = f(lhs[i],rhs[i]);
            return Vec256.Load(ref head(dst));        
        } 
    }
}
