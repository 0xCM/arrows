//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public static class Num
    {
        /// <summary>
        /// Constructs a contiguous range of integers inclusively between specified bounds
        /// If the first value is greater than the last, the range will be constructed
        /// in descending order.
        /// </summary>
        /// <param name="first">The first integer to yield</param>
        /// <param name="last">The last integer to yield</param>
        /// <typeparam name="T">The underlying integer type</typeparam>
        public static IEnumerable<num<T>> range<T>(T from, T to)
            where T : struct
        {
            var first = num(from);
            var last = num(to);
            var current = first;
            if(first < last)
                while(current<= last)
                    yield return current++;
            else
                while(current >= last)
                    yield return current--;
        }


        [MethodImpl(Inline)]
        public static num<T>[] alloc<T>(int len)
            where T : struct
                => new num<T>[len];

        [MethodImpl(Inline)]
        public static num<T> single<T>(T src)
            where T : struct
                => Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref num<T> single<T>(ref T src)
            where T : struct
                => ref Unsafe.As<T,num<T>>(ref src);


        [MethodImpl(Inline)]
        public static num<T>[] many<T>(params T[] src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(ref src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<num<T>> many<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var dst = span<num<T>>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<num<T>> many<T>(Span<T> src)
            where T : struct
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = single(ref src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<T> zero<T>()
                where T : struct
            => single(gmath.zero<T>());

        [MethodImpl(Inline)]
        public static num<T> one<T>()
                where T : struct
            => single(gmath.one<T>());

        [MethodImpl(Inline)]
        public static ref T scalar<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static ref readonly T immutable<T>(ref num<T> src)
            where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static num<T> abs<T>(num<T> lhs)
            where T : struct
                =>  lhs.Abs();

        [MethodImpl(Inline)]
        public static ref num<T> add<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.add(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> sub<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.sub(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));

        [MethodImpl(Inline)]
        public static ref num<T> mul<T>(ref num<T> lhs, in num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.mul(ref Num.scalar(ref lhs), Num.scalar(ref As.asRef(in rhs))));

        [MethodImpl(Inline)]
        public static ref num<T> div<T>(ref num<T> lhs, num<T> rhs)
            where T : struct
                =>  ref Num.single(ref gmath.div(ref Num.scalar(ref lhs), Num.scalar(ref rhs)));
 
        [MethodImpl(Inline)]
        public static num<T> num<T>(T src)
            where T : struct
                => Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static num<T> sqrt<T>(num<T> src)
            where T : struct
                => src.Sqrt();

        [MethodImpl(Inline)]
        public static num<T> add<T>(num<T> lhs, num<T> rhs)
            where T : struct
                => lhs.Add(rhs);
        
        [MethodImpl(Inline)]
        public static num<T> mul<T>(num<T> lhs, num<T> rhs)
            where T : struct
                => lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static num<T> div<T>(num<T> lhs, num<T> rhs)
            where T : struct
                => lhs.Div(rhs);
    
        [MethodImpl(Inline)]
        public static num<T> mod<T>(num<T> lhs, num<T> rhs)
            where T : struct
                => lhs.Mod(rhs);



    }
}