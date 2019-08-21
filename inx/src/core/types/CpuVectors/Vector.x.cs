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
        public static Vec256<T> ToVec256<T>(this Span256<T> src, int block = 0)
            where T : struct
                => Vec256.Load(ref src.Block(block));

        /// <summary>
        /// Loads a 128-bit cpu vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this Span128<T> src, int block = 0)
            where T : struct
                => Vec128.Load(ref src.Block(block));

        public static Vec128<T> Map<S,T>(this Vec128<S> src, Func<S,T> f)
            where T : struct
            where S : struct
        {
            var data = src.ToSpan();
            Span<T> dst = new T[data.Length];
            for(var i=0; i< data.Length; i++)
                dst[i] = f(src[i]);
            return Vec128.Load(ref head(dst));        
        } 

        public static Vec128<T> Map<S,T>(this Vec128<S> lhs, Vec128<S> rhs, Func<S,S,T> f)
            where T : struct
            where S : struct
        {
            var data = lhs.ToSpan();
            Span<T> dst = new T[data.Length];
            for(var i=0; i< data.Length; i++)
                dst[i] = f(lhs[i],rhs[i]);
            return Vec128.Load(ref head(dst));        
        } 


        /// <summary>
        /// Transforms the source vector into a target fector via a mapping function
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source primal type</typeparam>
        /// <typeparam name="T">The target primal type</typeparam>
        public static Vec256<T> Map<S,T>(this Vec256<S> src, Func<S,T> f)
            where T : struct
            where S : struct
        {
            var data = src.ToSpan();
            Span<T> dst = new T[data.Length];
            for(var i=0; i< data.Length; i++)
                dst[i] = f(src[i]);
            return Vec256.Load(ref head(dst));        
        } 

        public static Vec256<T> Map<S,T>(this Vec256<S> lhs, Vec256<S> rhs, Func<S,S,T> f)
            where T : struct
            where S : struct
        {
            var data = lhs.ToSpan();
            Span<T> dst = new T[data.Length];
            for(var i=0; i< data.Length; i++)
                dst[i] = f(lhs[i],rhs[i]);
            return Vec256.Load(ref head(dst));        
        } 

    }
}


