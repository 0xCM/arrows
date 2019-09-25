//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    /// <summary>
    /// Implements component-wise vector contraction
    /// </summary>
    partial class RngX
    {        
        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static BlockVector<N,T> Contract<N,T>(this BlockVector<N,T> src, BlockVector<N,T> max)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = NatSpan.Alloc<N,T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contractors.Contract(src[i],max[i]);
            return dst;
        }

         public static Span<N,T> Contract<N,T>(this Span<N,T> src, Span<N,T> max)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = NatSpan.Alloc<N,T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contractors.Contract(src[i],max[i]);
            return dst;
        }

        /// <summary>
        /// Effects a component-wise contraction on the source vector on a source vector of unsigned primal type, 
        /// dst[i] = src[i].Contract(max[i])
        /// </summary>
        /// <param name="src">The vector to contract</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The unsigned primal type</typeparam>
         public static BlockVector<T> Contract<T>(this BlockVector<T> src, BlockVector<T> max)
            where T : struct
        {
            var len = src.Length;
            require(len == max.Length);
            var dst = BlockVector.Alloc<T>(len);
            for(var i=0; i<dst.Length; i++)
                dst[i] = Contractors.Contract(src[i],max[i]);
            return dst;
        }
 
        [MethodImpl(Inline)]
        internal static Interval<T> Configure<T>(this Interval<T>? domain)        
            where T : struct
                => domain.ValueOrElse(() => Rng.TypeDomain<T>());

        [MethodImpl(Inline)]
        static T TypeMin<T>()
            where T : struct
                => gmath.minval<T>();
        
        [MethodImpl(Inline)]
        static T TypeMax<T>()
            where T : struct
                => gmath.maxval<T>();

    }
}