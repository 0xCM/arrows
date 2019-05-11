//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

using Z0;
using static zfunc;

partial class mfunc
{
    public static num<T> num<T>(T src)
        where T : struct, IEquatable<T>
            => src;
 
    /// <summary>
    /// Constructs a contiguous range of integers inclusively between specified bounds
    /// If the first value is greater than the last, the range will be constructed
    /// in descending order.
    /// </summary>
    /// <param name="first">The first integer to yield</param>
    /// <param name="last">The last integer to yield</param>
    /// <typeparam name="T">The underlying integer type</typeparam>
    public static IEnumerable<num<T>> range<T>(T from, T to)
        where T : struct, IEquatable<T>
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

    public static num<T>[] range<T>(num<T> first, num<T> last)
        where T : struct, IEquatable<T>
    {
        var dst = alloc<num<T>>((uint)(last - first + 1));        
        
        var current = first;
        var it = -1;
        while(++it < dst.Length)
        {
            dst[it] = current++;
        }

        return dst;            
    }


}