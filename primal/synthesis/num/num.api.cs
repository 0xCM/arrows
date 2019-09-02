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
    using System.Runtime.InteropServices;    
        
    using static zfunc;
    using static As;
    

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
            where T : unmanaged
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
        public static Span<num<T>> alloc<T>(int len)
            where T : unmanaged
                => new num<T>[len];

        [MethodImpl(Inline)]
        public static num<T> from<T>(in T src)
            where T : unmanaged
                => Unsafe.As<T,num<T>>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static num<T> num<T>(T src)
            where T : unmanaged
                => Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref num<T> num<T>(ref T src)
            where T : unmanaged
                => ref Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static ref T scalar<T>(ref num<T> src)
            where T : unmanaged
                => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static num<T> zero<T>()
            where T : unmanaged
                => num(gmath.zero<T>());

        [MethodImpl(Inline)]
        public static num<T> one<T>()
            where T : unmanaged
                => num(gmath.one<T>());

        [MethodImpl(Inline)]
        public static Span<num<T>> numbers<T>(params T[] src)
            where T : unmanaged
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = num(ref src[i]);
            return dst;
        }
 
        [MethodImpl(Inline)]
        public static ReadOnlySpan<num<T>> load<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => MemoryMarshal.Cast<T,num<T>>(src);

        [MethodImpl(Inline)]
        public static Span<num<T>> load<T>(Span<T> src)
            where T : unmanaged
                => MemoryMarshal.Cast<T,num<T>>(src);
   }
}