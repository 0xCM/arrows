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


    public static class num
    {
        public static num<T>[] alloc<T>(int len)
            where T : struct, IEquatable<T>
                => new num<T>[len];

        public static num<T>[] numbers<T>(params T[] src)
            where T : struct, IEquatable<T>
        {
            var dst = alloc<T>(src.Length);
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        public static void copy<T>(T[] src, num<T>[] dst)
            where T : struct, IEquatable<T>
        {            
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            
        }

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