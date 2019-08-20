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

    /// <summary>
    /// Converts a blocked span of one value type to a blocked span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span256<T> convert<S,T>(Span256<S> src)
        where T : struct
        where S : struct
    {
        var dst = Span256.Alloc<T>(src.Length);
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    /// <summary>
    /// Converts a span of one value type to a span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> convert<S,T>(Span<S> src)
        where T : struct
        where S : struct
    {
        Span<T> dst = new T[src.Length];
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }


    /// <summary>
    /// Converts a natural span of one value type to a natural span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> convert<N,S,T>(Span<N,S> src)
        where N : ITypeNat, new()
        where T : struct
        where S : struct
    {
        Span<T> dst = new T[src.Length];
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }


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

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(in T src)
        where T : struct
    {
        Span<T> s = new T[1]{src};
        return MemoryMarshal.AsBytes(s);
    }       

    /// <summary>
    /// Converts a source value of any value type to its bytespan representation
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The value type</typeparam>
    [MethodImpl(Inline)]
    public static void bytes<T>(in T src, Span<byte> dst)
        where T : struct
            => As.generic<T>(ref dst[0]) = src;

   /// <summary>
    /// Converts a parameter array to a span of 32-bit signed integers
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<int> ints<T>(params T[] src)
        where T : struct
            =>  convert<T,int>(src.ToReadOnlySpan());

    /// <summary>
    /// Converts a parameter array to a span of 32-bit unsigned integers
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<uint> uints<T>(params T[] src)
        where T : struct
            =>  convert<T,uint>(src.ToReadOnlySpan());

    /// <summary>
    /// Converts a parameter array to a span of 64-bit unsigned integers
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<ulong> ulongs<T>(params T[] src)
        where T : struct
            =>  convert<T,ulong>(src.ToReadOnlySpan());

    /// <summary>
    /// Converts a parameter array to a span of 64-bit signed integers
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<long> longs<T>(params T[] src)
        where T : struct
            =>  convert<T,long>(src.ToReadOnlySpan());

    /// <summary>
    /// Converts a parameter array to a span of 32-bit floats
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<float> floats<T>(params T[] src)
        where T : struct
            =>  convert<T,float>(src.ToReadOnlySpan());

    /// <summary>
    /// Converts a parameter array to a span of 64-bit floats
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Span<double> doubles<T>(params T[] src)
        where T : struct
            =>  convert<T,double>(src.ToReadOnlySpan());
 

}