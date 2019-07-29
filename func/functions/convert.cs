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

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src)
    {
        ref var dst = ref Unsafe.As<S,T>(ref src);
        return ref dst;
    }

    [MethodImpl(Inline)]   
    public static ref T imagine<S,T>(ref S src, out T dst)
    {
        dst = Unsafe.As<S,T>(ref src);
        return ref dst;
    }

    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src, out T dst)
        where T : struct
        where S : struct
            => dst = Converter.convert(src, out T target);  
           
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : struct
        where S : struct
           => Converter.convert(src, out T dst);  

    [MethodImpl(Inline)]   
    public static Span<T> convert<S,T>(ReadOnlySpan<S> src)
        where T : struct
        where S : struct
    {
        var dst = span<T>(src.Length);
        for(var i=0; i<src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    [MethodImpl(Inline)]   
    public static T convert<T>(sbyte src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(byte src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(short src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(ushort src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<int> src)
        where T : struct
            => convert<int,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<uint> src)
        where T : struct
            => convert<uint,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<long> src)
        where T : struct
            => convert<long,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<ulong> src)
        where T : struct
            => convert<ulong,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<float> src)
        where T : struct
            => convert<float,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : struct
            => Converter.convert(src, out T dst);

    [MethodImpl(Inline)]   
    public static Span<T> convert<T>(ReadOnlySpan<double> src)
        where T : struct
            => convert<double,T>(src);

}