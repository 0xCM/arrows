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
    using static mfunc;
    using static zfunc;

    public static class num
    {
        [MethodImpl(Inline)]
        public static num<T>[] alloc<T>(int len)
            where T : struct, IEquatable<T>
                => new num<T>[len];

        [MethodImpl(Inline)]
        public static num<T>[] numbers<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static void copy<T>(T[] src, num<T>[] dst)
            where T : struct, IEquatable<T>
        {            
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            
        }

        [MethodImpl(Inline)]
        public static void copy<T>(IEnumerable<T> src, num<T>[] dst)
            where T : struct, IEquatable<T>
        {            
            var i = 0;
            var len = dst.Length;
            var last = len - 1;
            foreach(var item in src)
            {
                while(i <= last)
                    dst[i] = item;
            }            
        }

        [MethodImpl(Inline)]
        public static void add<T>(num<T>[] lhs, num<T>[] rhs, num<T>[] dst)
            where T : struct, IEquatable<T>
        {
            var xLhs = As.data(lhs);
            var xRhs = As.data(rhs);
            var xDst = As.data(dst);
            gmath.add(xLhs, xRhs, xDst);
        }

        [MethodImpl(Inline)]
        public static num<T>[] add<T>(num<T>[] lhs, num<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(length(lhs,rhs));
            add(lhs,rhs,dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static void sub<T>(num<T>[] lhs, num<T>[] rhs, num<T>[] dst)
            where T : struct, IEquatable<T>
        {
            var xLhs = As.data(lhs);
            var xRhs = As.data(rhs);
            var xDst = As.data(dst);
            gmath.sub(xLhs, xRhs, xDst);
        }

        [MethodImpl(Inline)]
        public static num<T>[] sub<T>(num<T>[] lhs, num<T>[] rhs)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(length(lhs,rhs));
            sub(lhs,rhs,dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static num<T> sum<T>(num<T>[] src)
            where T : struct, IEquatable<T>
        {
            var result = num<T>.Zero;
            for(var i = 0; i< src.Length; i++)
                result += src[i];
            return result;
        }

        public static num<T> sum<T>(IEnumerable<T> src)
            where T : struct, IEquatable<T>
        {
            var result = num<T>.Zero;
            foreach(var value in src)
            result += value;
            return result;
        }

    }


}