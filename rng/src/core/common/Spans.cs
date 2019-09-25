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

    partial class RngX
    {

        /// <summary>
        /// Produces a span of random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            Span<T> dst = new T[length];
            random.StreamTo(domain.Configure(), length,ref head(dst), filter);
            return dst;
        }

        /// <summary>
        /// Produces a span of random values constraint to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">The interval domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
                => random.Span<T>(length,domain,null);

        /// <summary>
        /// Allocates and produces a readonly span populated with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnlySpan<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        /// <summary>
        /// Allocates and produces a punctured span populated with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The length of the produced data</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);        

        /// <summary>
        /// Allocates a span of natural dimensions and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="length">The natural length of the produced span</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<N,T> Span<N,T>(this IPolyrand random, N length = default, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct  
            where N : ITypeNat, new()
                => NatSpan.Load<N,T>(random.Span<T>((int)length.value, domain, filter));                                    

        /// <summary>
        /// Allocates a table span of natural dimensions and populates the cells with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The column count</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows = default, N cols = default)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols)), rows, cols);

        /// <summary>
        /// Allocates a table span of natural dimensions and populates the cells with random values that
        /// are confined to a specified domain
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rows">The row count</param>
        /// <param name="cols">The column count</param>
        /// <param name="cols">The interval domain to which values are confined</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows, N cols, Interval<T> domain)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols),domain), rows, cols);

        /// <summary>
        /// Allocates a 128-bit blocked span and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeSpan(Z0.Span128.BlockLength<T>(blocks)).ToSpan128(); 

        /// <summary>
        /// Allocates a 128-bit blocked span and populates it with random values and returns a readonly view to the caller
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> ReadOnlySpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span128<T>(blocks, domain, filter);

        /// <summary>
        /// Allocates a punctured 128-bit blocked span and populates it with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 128-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> NonZeroSpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        /// <summary>
        /// Allocates a 256-bit blocked span and populates it with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Span256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct       
            => random.Stream(domain,filter).TakeSpan(Z0.Span256.BlockLength<T>(blocks)).ToSpan256();       

        /// <summary>
        /// Allocates populates a 256-bit blocked readonly span with random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <param name="filter">An optional filter that refines the domain</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> ReadOnlySpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span256<T>(blocks, domain, filter);

        /// <summary>
        /// Allocates a punctured 256-bit blocked span and populates it with nonzero random values
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="blocks">The number of 256-bit blocks to allocate and fill</param>
        /// <param name="domain">An optional domain to which values are constrained</param>
        /// <typeparam name="T">The primal random value type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> NonZeroSpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero); 


    }

}