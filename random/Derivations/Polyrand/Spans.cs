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
        [MethodImpl(Inline)]
        public static T[] Array<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeArray(length);
         
        [MethodImpl(Inline)]
        public static T[] NonZeroArray<T>(this IPolyrand random, int length, Interval<T>? domain = null)
            where T : struct
                => random.Stream(domain, gmath.nonzero).TakeArray(length);        

        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            var stream = domain != null ? random.Stream<T>(domain.Value) : random.Stream<T>();
            return stream.TakeSpan(length);
        }

        [MethodImpl(Inline)]
        public static Span<T> Span<T>(this IPolyrand random, int length, Interval<T> domain)
            where T : struct
            => random.Stream<T>(domain).TakeSpan(length);

        [MethodImpl(Inline)]
        public static Span<N,T> Span<N,T>(this IPolyrand random, N length = default, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct  
            where N : ITypeNat, new()
                => NatSpan.Load<N,T>(random.Span<T>((int)length.value, domain, filter));                                    

        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows = default, N cols = default)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols)), rows, cols);

        [MethodImpl(Inline)]
        public static Span<M,N,T> Span<M,N,T>(this IPolyrand random, M rows, N cols, Interval<T> domain)
            where T : struct  
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => NatSpan.Load<M,N,T>(random.Span<T>(nfunc.muli(rows,cols),domain), rows, cols);

        [MethodImpl(Inline)]
        public static Span128<T> Span128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Stream(domain,filter).TakeSpan(Z0.Span128.BlockLength<T>(blocks)).ToSpan128(); 

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnlySpan<T>(this IPolyrand random, int length, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span<T>(length, domain, filter);

        [MethodImpl(Inline)]
        public static Span<T> NonZeroSpan<T>(this IPolyrand random, int samples, Interval<T>? domain = null)
                where T : struct
                    => random.Span<T>(samples, domain, gmath.nonzero);        

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> ReadOnlySpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span128<T>(blocks, domain, filter);

        [MethodImpl(Inline)]
        public static Span128<T> NonZeroSpan128<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span128(blocks, domain, gmath.nonzero);

        [MethodImpl(Inline)]
        public static Span256<T> Span256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct       
            => random.Stream(domain,filter).TakeSpan(Z0.Span256.BlockLength<T>(blocks)).ToSpan256();       

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> ReadOnlySpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
                => random.Span256<T>(blocks, domain, filter);

        [MethodImpl(Inline)]
        public static Span256<T> NonZeroSpan256<T>(this IPolyrand random, int blocks = 1, Interval<T>? domain = null)        
            where T : struct  
                => random.Span256(blocks, domain, gmath.nonzero); 


    }

}