//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    partial class RngX
    {        
        /// <summary>
        /// Produces a random 128-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a stream of random 128-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vec128<T>> CpuVec128Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            while(true)
                yield return random.CpuVec128(domain,filter);
        }

        /// <summary>
        /// Produces a random 256-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IRandomSource random, Interval<T> domain)        
            where T : struct
                => random.Span256<T>(1, domain).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IRandomSource random)        
            where T : struct
                => random.Span256<T>(1).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IRandomSource random, Interval<T>? domain, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).LoadVec256();

        /// <summary>
        /// Produces a random 512-bit pseudo-intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec512<T> CpuVec512<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            var v1 = random.CpuVec256(domain,filter);
            var v2 = random.CpuVec256(domain,filter);
            return Vec512.Define(v1,v2);
        }

        /// <summary>
        /// Produces a random 1024-bit pseudo-intrinsic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec1024<T> CpuVec1024<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            var v1 = random.CpuVec256(domain,filter);
            var v2 = random.CpuVec256(domain,filter);
            var v3 = random.CpuVec256(domain,filter);
            var v4 = random.CpuVec256(domain,filter);
            return Vec1024.Define(v1,v2,v3,v4);
        }

        /// <summary>
        /// Produces a stream of random 256-bit intrinsic vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IEnumerable<Vec256<T>> CpuVec256Stream<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
        {
            while(true)            
                yield return random.CpuVec256(domain,filter);
        }

        // /// <summary>
        // /// Produces a random <see cref='Z0.__m512'/> value
        // /// </summary>
        // /// <param name="random">The random source</param>
        // /// <param name="domain">The domain from which the vector components will be chosen</param>
        // /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        // /// <typeparam name="T">The vector component type</typeparam>
        // [MethodImpl(Inline)]
        // public static __m512i m512i<T>(this IRandomSource random, Interval<T> domain, Func<T,bool> filter = null)
        //     where T : struct
        //         => __m512i.Define(random.Stream(domain, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
        
        // /// <summary>
        // /// Produces a random <see cref='Z0.__m512'/> value
        // /// </summary>
        // /// <param name="random">The random source</param>
        // /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        // /// <typeparam name="T">The vector component type</typeparam>
        // [MethodImpl(Inline)]
        // public static __m512i m512i<T>(this IRandomSource random, Func<T,bool> filter = null)
        //     where T : struct
        //         => __m512i.Define(random.Stream<T>(null, filter).TakeSpan(64/SizeOf<T>.Size).ReadOnly());
    }
}