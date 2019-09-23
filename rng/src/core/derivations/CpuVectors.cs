//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class RngX
    {        
        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVec128();

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> CpuVec128<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, closed(min,max), filter).LoadVec128();
                
        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, Interval<T> domain)        
            where T : unmanaged
                => random.Span256<T>(1, domain).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random)        
            where T : unmanaged
                => random.Span256<T>(1).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, Interval<T> domain, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, domain, filter).LoadVec256();

        /// <summary>
        /// Produces a random 256-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> CpuVec256<T>(this IPolyrand random, T min, T max, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span256<T>(1, closed(min,max), filter).LoadVec256();

        /// <summary>
        /// Produces a stream of random 256-bit cpu vectors
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static IRandomStream<Vec256<T>> CpuVec256Stream<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
        {
            IEnumerable<Vec256<T>> produce()
            {
                while(true)            
                    yield return random.CpuVec256(domain,filter);
            }

            return stream(produce(), random.RngKind);
        }

        /// <summary>
        /// Produces a random 512-bit pseudo-cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec512<T> CpuVec512<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
        {
            var v1 = random.CpuVec256(domain,filter);
            var v2 = random.CpuVec256(domain,filter);
            return Vec512.FromParts(v1,v2);
        }

        /// <summary>
        /// Produces a random 1024-bit pseudo-cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec1024<T> CpuVec1024<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
        {
            var v1 = random.CpuVec256(domain,filter);
            var v2 = random.CpuVec256(domain,filter);
            var v3 = random.CpuVec256(domain,filter);
            var v4 = random.CpuVec256(domain,filter);
            return Vec1024.Define(v1,v2,v3,v4);
        }

        /// <summary>
        /// Produces a random 128-bit cpu vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="domain">The domain from which the vector components will be chosen</param>
        /// <param name="filter">If specified, component values for which the predicate returns false are excluded</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> CpuVector128<T>(this IPolyrand random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : unmanaged
                => random.Span128<T>(1, domain, filter).LoadVector128();

 
    }
}