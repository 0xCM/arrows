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
    using static zfunc;

    public static class Number
    {

        [MethodImpl(Inline)]
        public static num<T>[] alloc<T>(int len)
            where T : struct, IEquatable<T>
                => new num<T>[len];

        [MethodImpl(Inline)]
        public static num<T>[] many<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }


        [MethodImpl(Inline)]
        public static num<T>[] add<T>(num<T>[] lhs, num<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var len = length(lhs,rhs);
            var dst = alloc<T>(len);
            var it = -1;
            while(++it < len)
                dst[it] = lhs[it] + rhs[it];
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<T>[] sub<T>(num<T>[] lhs, num<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var len = length(lhs,rhs);
            var dst = alloc<T>(len);
            var it = -1;
            while(++it < len)
                dst[it] = lhs[it] + rhs[it];
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<T> sum<T>(num<T>[] src)
            where T : struct, IEquatable<T>
        {
            var result = num<T>.Zero;
            var len = src.Length;
            var it = -1;
            while(++it < len)
                result += src[it];                    
            return result;
        }
    }
}