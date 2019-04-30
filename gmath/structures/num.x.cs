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
    
    using static zcore;

    public static class numx
    {

        public static num<T> Sum<T>(this num<T>[] src)        
            where T : struct, IEquatable<T>
                => num.sum(src);

        public static num<T> Sum<T>(this IEnumerable<num<T>> src)        
            where T : struct, IEquatable<T>
                => num.sum(src);

        public static void Scale<T>(this num<T>[] src, num<T> factor, num<T>[] dst)        
            where T : struct, IEquatable<T>
        {
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i] * factor;            
        }

        public static num<T>[] Scale<T>(this num<T>[] src, num<T> factor)        
            where T : struct, IEquatable<T>
        {
            var dst = num.alloc<T>(src.Length);
            src.Scale(factor, dst);
            return dst;
        }

        public static IEnumerable<num<T>> Scale<T>(this IEnumerable<num<T>> src, num<T> factor)        
            where T : struct, IEquatable<T>
                => src.Select(x => x * factor);

    }


}