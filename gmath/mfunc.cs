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
using static zcore;

public static partial class mfunc
{

    static Exception lengthMismatch(int lhs, int rhs)
        => throw new Exception($"Length mismatch, {lhs} != {rhs}");

    static Exception countMismatch(int lhs, int rhs)
        => throw new Exception($"Count mismatch, {lhs} != {rhs}");

    [MethodImpl(Inline)]
    public static T component<T>(Vector128<T> src, int ix)
        where T : struct, IEquatable<T>
            => src.GetElement(ix);


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


    /// <summary>
    /// Returns true if a value is the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(float src)
        => float.IsNaN(src);

    /// <summary>
    /// Returns true if one of the supplied values is the NaN representative
    /// </summary>
    /// <param name="x0">The first source value</param>
    /// <param name="x1">The second source value</param>
    /// <param name="x2">The third source value</param>
    /// <param name="x3">The fourth source value</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(float x0, float x1, float x2, float x3)
        => isNaN(x0) || isNaN(x1) || isNaN(x2) || isNaN(x3);

    /// <summary>
    /// Returns true if a value is the NaN representative
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(double src)
        => double.IsNaN(src);

    /// <summary>
    /// Returns true if one of the supplied values is the NaN representative
    /// </summary>
    /// <param name="x0">The first source value</param>
    /// <param name="x1">The second source value</param>
    [MethodImpl(Inline)]
    public static bool anyNan(double x0, double x1)
        => isNaN(x0) || isNaN(x1);

    /// <summary>
    /// Returns true if the value of an identified component the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    /// <param name="ix">The 0-based component index</param>
    [MethodImpl(Inline)]
    public static bool isNaN(Vector128<float> src, int ix)
        => float.IsNaN(src.GetElement(ix));

    /// <summary>
    /// Returns true if any component of the source vector is the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(Vector128<float> src)
        => anyNaN(component(src,0), component(src, 1), component(src,2), component(src,3));

    /// <summary>
    /// Returns true if the value of a component the NaN representative
    /// </summary>
    /// <param name="x">The source value</param>
    [MethodImpl(Inline)]
    public static bool isNaN(Vector128<double> src, int index)
        => double.IsNaN(src.GetElement(index));

    /// <summary>
    /// Returns true if any component of the source vector is the NaN representative
    /// </summary>
    /// <param name="src">The source vector</param>
    [MethodImpl(Inline)]
    public static bool anyNaN(Vector128<double> src)
        => anyNan(component(src,0), component(src, 1));


    /// <summary>
    /// Replaces a NaN representive value with 0
    /// </summary>
    /// <param name="src">The source value to sanitize</param>
    [MethodImpl(Inline)]
    public static double clearNaN(double x, double replacement = -1)
        => isNaN(x) ? replacement : x;


    /// <summary>
    /// Replaces a NaN representive value with 0
    /// </summary>
    /// <param name="src">The source value to sanitize</param>
    [MethodImpl(Inline)]
    public static float clearNaN(float x, float replacement = -1)
        => isNaN(x) ? replacement : x;

    /// <summary>
    /// Replaces an identified NaN component with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<float> clearNaN(Vector128<float> src, int ix, float replacement = -1)
        => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

    /// <summary>
    /// Replaces any NaN components with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<float> clearNaN(Vector128<float> src, float replacement = -1)
    {
        var lolo = clearNaN(src.GetElement(0), replacement);
        var lohi = clearNaN(src.GetElement(1), replacement);
        var hilo = clearNaN(src.GetElement(2), replacement);
        var hihi = clearNaN(src.GetElement(3), replacement);
        return Vector128.Create(lolo,lohi,hilo,hihi);
    }

    /// <summary>
    /// Replaces an identified NaN component with a specified value
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vector128<double> clearNaN(Vector128<double> src, int ix, double replacement = -1)
        => src.WithElement(ix,clearNaN(src.GetElement(ix), replacement));

    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec128<double> clearNaN(Vector128<double> src, double replacement = -1)
    {
        var lo = clearNaN(src.GetElement(0),replacement);
        var hi = clearNaN(src.GetElement(1),replacement);
        return Vector128.Create(lo,hi);
    }


    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec256<double> clearNaN(Vector256<double> src, double replacement = -1)
    {
        var x0 = clearNaN(src.GetElement(0),replacement);
        var x1 = clearNaN(src.GetElement(1),replacement);
        var x2 = clearNaN(src.GetElement(2),replacement);
        var x3 = clearNaN(src.GetElement(3),replacement);
        return Vector256.Create(x0,x1,x2,x3);
    }


    /// <summary>
    /// Replaces any NaN components with -1
    /// </summary>
    /// <param name="src">The source vector to sanitize</param>
    [MethodImpl(Inline)]
    public static Vec256<float> clearNaN(Vector256<float> src, float replacement = -1)
    {
        var x0 = clearNaN(src.GetElement(0),replacement);
        var x1 = clearNaN(src.GetElement(1),replacement);
        var x2 = clearNaN(src.GetElement(2),replacement);
        var x3 = clearNaN(src.GetElement(3),replacement);
        var x4 = clearNaN(src.GetElement(4),replacement);
        var x5 = clearNaN(src.GetElement(5),replacement);
        var x6 = clearNaN(src.GetElement(6),replacement);
        var x7 = clearNaN(src.GetElement(7),replacement);
        return Vector256.Create(x0,x1,x2,x3,x4,x5,x6,x7);
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
    public static Span128<T> cast<S,T>(Span128<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (Span128<T>)MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan128<T> cast<S,T>(ReadOnlySpan128<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (ReadOnlySpan128<T>)MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static Span256<T> cast<S,T>(Span256<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (Span256<T>)MemoryMarshal.Cast<S,T>(src);

    [MethodImpl(Inline)]
    public static ReadOnlySpan256<T> cast<S,T>(ReadOnlySpan256<S> src)                
        where S : struct, IEquatable<S>
        where T : struct, IEquatable<T>
            => (ReadOnlySpan256<T>)MemoryMarshal.Cast<S,T>(src);


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
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static byte[] digits(byte src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(ushort src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(uint src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(Inline)]
    public static byte[] digits(ulong src)
        => src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();

    /// <summary>
    /// Converts from one value to another, provided the 
    /// required conversion operation is defined; otherwise,
    /// raises an error
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : struct, IEquatable<T>
        where S : struct, IEquatable<S>
            => ClrConverter.convert<S,T>(src);

    /// <summary>
    /// Vectorized conversion
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    /// <param name="src">The source array</param>
    [MethodImpl(Inline)]   
    public static T[] convert<S,T>(S[] src)
        => ClrConverter.convert<S,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<int,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<uint,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<long,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<ulong,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<float,T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : struct, IEquatable<T>
            => ClrConverter.convert<double,T>(src);

    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlyMemory<T> lhs, ReadOnlyMemory<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, Span<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Span128<T> lhs, Span128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span128<T> lhs, Span128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(Span256<T> lhs, Span256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    /// <summary>
    /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
    /// raises an exception
    /// </summary>
    /// <param name="lhs">The left source</param>
    /// <param name="rhs">The right source</param>
    /// <typeparam name="T">The span element type</typeparam>
    [MethodImpl(Inline)]   
    public static int blocks<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : throw countMismatch(lhs.BlockCount,rhs.BlockCount);

    [MethodImpl(Inline)]   
    public static int length<T>(Span256<T> lhs, Span256<T> rhs)
        where T : struct, IEquatable<T>
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

    [MethodImpl(Inline)]   
    public static int length<T>(Index<T> lhs, Index<T> rhs)
        => lhs.Length == rhs.Length ? lhs.Length : throw lengthMismatch(lhs.Length,rhs.Length);

}