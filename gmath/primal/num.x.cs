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
    
    
    using static mfunc;

    public static class NumberX
    {

        [MethodImpl(Inline)]
        public static num<T> Sum<T>(this num<T>[] src)        
            where T : struct, IEquatable<T>
                => Number.sum(src);

        [MethodImpl(NotInline)]
        public static void Scale<T>(this num<T>[] src, num<T> factor, num<T>[] dst)        
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i] * factor;            
        }

        [MethodImpl(Inline)]
        public static num<T>[] Scale<T>(this num<T>[] src, num<T> factor)        
            where T : struct, IEquatable<T>
        {
            var dst = Number.alloc<T>(src.Length);
            src.Scale(factor, dst);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static T[] Data<T>(this num<T>[] src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<num<T>[], T[]>(ref src);
        
        [MethodImpl(NotInline)]
        public static IEnumerable<num<T>> Scale<T>(this IEnumerable<num<T>> src, num<T> factor)        
            where T : struct, IEquatable<T>        
                => src.Select(x => x * factor);

        [MethodImpl(NotInline)]
        public static void CopyTo<T>(this numbers<T> src, T[] dst)
            where T : struct, IEquatable<T>
                =>  src.Extract().CopyTo(dst);
                
        [MethodImpl(NotInline)]
        public static numbers<T> To<T>(this num<T> first, num<T> last)
            where T : struct, IEquatable<T>
                =>  new numbers<T>(range(first, last));
    }
}