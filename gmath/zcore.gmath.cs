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
using System.Diagnostics;

using Z0;

partial class zcore
{

    [MethodImpl(Inline)]
    public static void assert(bool condition, string msg = null, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
    {
        if(!condition)
            throw new Exception( $"{caller} {file} line{line}: {msg ?? "Assertion Failed" }" );
    }
         

    [MethodImpl(Inline)]
    public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
        where T : struct
            => MemoryMarshal.AsBytes(src);

    [MethodImpl(Inline)]
    public static Span<byte> bytes<T>(Span<T> src)
        where T : struct
            => MemoryMarshal.AsBytes(src);

    [MethodImpl(Inline)]
    public static Memory<T> memory<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.AsMemory(src);

    [MethodImpl(Inline)]
    public static T read<T>(ReadOnlySpan<byte> src)
        where T : struct
            =>  MemoryMarshal.Read<T>(src);

    [MethodImpl(Inline)]
    public static void read<T>(ReadOnlySpan<byte> src, out T dst)
        where T : struct
            => dst = read<T>(src);

    [MethodImpl(Inline)]
    public static void write<T>(ref T src, Span<byte> dst)
        where T : struct
            => MemoryMarshal.Write(dst, ref src);


    [MethodImpl(Inline)]
    public static ref T first<T>(Span<T> src)
        where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan<T> src)
        where T : struct
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref T first<T>(Span128<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan128<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref T first<T>(Span256<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan256<T> src)
        where T : struct, IEquatable<T>
            =>  ref MemoryMarshal.GetReference<T>(src);

    [MethodImpl(Inline)]
    public static ref readonly T first<T>(ReadOnlySpan<byte> src)
        where T : struct
            =>  ref MemoryMarshal.AsRef<T>(src);


    [MethodImpl(Inline)]
    public static ref T first<T>(Span<byte> src)
        where T : struct
            =>  ref MemoryMarshal.AsRef<T>(src);


    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
        where S : struct
        where T : struct
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<T> dst)                
        where S : struct
        where T : struct
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src)                
        where S : struct
        where T : struct
            => MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span<T> cast<S,T>(Span<S> src, out Span<T> dst)                
        where S : struct
        where T : struct
            => dst = MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]   
    public static ReadOnlySpan<T> rospan<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static ReadOnlySpan<T> rospan<T>(ref T first, int length)
        => MemoryMarshal.CreateReadOnlySpan(ref first, length);

    [MethodImpl(Inline)]   
    public static ReadOnlySpan<T> rospan<T>(T[] src, int offset, int len)
        => new ReadOnlySpan<T>(src, offset, len);


    /// <summary>
    /// Constructs a span from an array
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static Span<T> span<T>(ref T first, int length)
        => MemoryMarshal.CreateSpan(ref first, length);

    /// <summary>
    /// Constructs an unpopulated span of a specified length
    /// </summary>
    /// <param name="length">The number of T-sized cells to allocate</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(int length)
        => new Span<T>(new T[length]);

    /// <summary>
    /// Constructs a span from an array selection
    /// </summary>
    /// <param name="src">The source array</param>
    /// <param name="offset">The array index where the span is to begin</param>
    /// <param name="length">The number of elements to cover from the aray</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(T[] src, int offset, int length)
        => new Span<T>(src,offset, length);

    /// <summary>
    /// Constructs a span from the entireity of a sequence
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src)
        => span(src.ToArray());

    [MethodImpl(Inline)]
    public static Span<T> span<T>(ReadOnlySpan<T> src)
    {
        var dst = span<T>(src.Length);
        src.CopyTo(dst);
        return dst;
    }

    /// <summary>
    /// Constructs a span from a sequence selection
    /// </summary>
    /// <param name="src">The source sequence</param>
    /// <param name="offset">The number of elements to skip from the head of the sequence</param>
    /// <param name="length">The number of elements to take from the sequence</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]
    public static Span<T> span<T>(IEnumerable<T> src, int? offset = null, int? length = null)
        => span(length == null ? src.Skip(offset ?? 0) : src.Skip(offset ?? 0).Take(length.Value));


    [MethodImpl(Inline)]
    public static unsafe sbyte* stackI8<T>(int length, T value  = default)
    {
        var dst =  stackalloc sbyte[length];
        dst[0] = As.int8(value);
        return dst;
    }

    [MethodImpl(Inline)]
    public static unsafe byte* stackU8<T>(int length, T value  = default)
    {
        var dst =  stackalloc byte[length];
        dst[0] = As.uint8(value);
        return dst;
    }

    [MethodImpl(Inline)]
    public static unsafe short* stackI16<T>(int length, T value  = default)
    {
        var dst =  stackalloc short[length];
        dst[0] = As.int16(value);
        return dst;
    }

    [MethodImpl(Inline)]
    public static unsafe ushort* stackU16<T>(int length, T value  = default)
    {
        var dst =  stackalloc ushort[length];
        dst[0] = As.uint16(value);
        return dst;
    }

}