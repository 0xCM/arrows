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

    public static numbers<T> numbers<T>(Span<T> src)
        where T : struct
            => src;

    public static numbers<T> numbers<T>(ReadOnlySpan<T> src)
        where T : struct
            => src.ToArray();

    [MethodImpl(Inline)]
    public static ref num<T> num<T>(ref T src)
        where T : struct
            => ref Unsafe.As<T,num<T>>(ref src);

    [MethodImpl(Inline)]
    public static num<T> num<T>(T src)
        where T : struct
            => Unsafe.As<T,num<T>>(ref src);

    [MethodImpl(Inline)]
    public static ref T scalar<T>(ref num<T> src)
        where T : struct
            => ref Unsafe.As<num<T>,T>(ref src);

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

    public static num<T>[] range<T>(num<T> first, num<T> last)
        where T : struct
    {
        var dst = alloc<num<T>>((uint)((uint)last - (uint)first + 1));        
        
        var current = first;
        var it = -1;
        while(++it < dst.Length)
        {
            dst[it] = current++;
        }

        return dst;            
    }

    [MethodImpl(Inline)]
    public static num<T> abs<T>(num<T> src)
        where T : struct
            => src.Abs();

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

    [MethodImpl(Inline)]
    public static num<T> and<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.And(rhs);

    [MethodImpl(Inline)]
    public static num<T> or<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.Or(rhs);

    [MethodImpl(Inline)]
    public static num<T> xor<T>(num<T> lhs, num<T> rhs)
        where T : struct
            => lhs.XOr(rhs);

}