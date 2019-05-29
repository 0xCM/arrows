//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    public const sbyte I8Zero = 0;    

    public const byte U8Zero = 0;

    public const short I16Zero = 0;

    public const ushort U16Zero = 0;

    public const int I32Zero = 0;

    public const uint U32Zero = 0u;

    public const long I64Zero = 0L;

    public const ulong U64Zero = 0ul;

    public const float F32Zero = 0.0f;
    
    public const double F64Zero = 0.0;

    public const sbyte I8One = 1;

    public const byte U8One = 1;

    public const short I16One = 1;
    
    public const ushort U16One = 1;

    public const int I32One = 1;

    public const uint U32One = 1u;

    public const long I64One = 1L;

    public const ulong U64One = 1UL;

    public const float F32One = 1.0f;
    
    public const double F64One = 1.0;

    public const int I8BitCount = Pow2.T03;

    public const int U8BitCount = Pow2.T03;
    
    public const int I16BitCount = Pow2.T04;

    public const int U16BitCount = Pow2.T04;

    public const int I32BitCount = Pow2.T05;

    public const int U32BitCount = Pow2.T05;

    public const int I64BitCount = Pow2.T06;

    public const int U64BitCount = Pow2.T06;

    public const int F32BitCount = Pow2.T05;

    public const int F64BitCount = Pow2.T06;

    public const sbyte I8Min = sbyte.MinValue;

    public const byte U8Min = byte.MinValue;

    public const short I16Min = short.MinValue;
    
    public const ushort U16Min = ushort.MinValue;

    public const int I32Min = int.MinValue;

    public const uint U32Min = uint.MinValue;

    public const long I64Min = long.MinValue;

    public const ulong U64Min = ulong.MinValue;

    public const float F32Min = float.MinValue;
    
    public const double F64Min = double.MinValue;

    public const sbyte I8Max = sbyte.MaxValue;

    public const byte U8Max = byte.MaxValue;

    public const short I16Max = short.MaxValue;
    
    public const ushort U16Max = ushort.MaxValue;

    public const int I32Max = int.MaxValue;

    public const uint U32Max = uint.MaxValue;

    public const long I64Max = long.MaxValue;

    public const ulong U64Max = ulong.MaxValue;

    public const float F32Max = float.MaxValue;
    
    public const double F64Max = double.MaxValue;

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<T>(long len)
        => new T[len];

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] alloc<T>(uint len)
        => new T[len];

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] alloc<T>(long len)
        => new T[len];

    /// <summary>
    /// Creates, but does not populate, a mutable array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] alloc<T>(int len)
        => new T[len];

    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static T[] alloc<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
        where T : struct
            => alloc<T>(length(lhs,rhs));

    [MethodImpl(Inline)]   
    public static T[] alloc<T>(ReadOnlySpan<T> src)
        where T : struct
            => alloc<T>(src.Length);

    /// <summary>
    /// Constructs an array filled with a replicated value
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <param name="count">The number of replicants</param>
    /// <typeparam name="T">The replicant type</typeparam>
    public static T[] repeat<T>(T value, ulong count)
    {
        var dst = alloc<T>((uint)count);
        for(var idx = 0U; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, int count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, uint count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static void copy<T>(T[] src, T[] dst)
        => Array.Copy(src,dst,length(src,dst));

    /// <summary>
    /// Partitions an array into a sequence of segments
    /// </summary>
    /// <typeparam name="T">The array element type</typeparam>
    /// <param name="items">The source array</param>
    /// <param name="width">The width of each subarray</param>
    public static IEnumerable<ArraySegment<T>> partition<T>(T[] items, int width)
        => items.Partition(width);

    /// <summary>
    /// Constructs an array from a stream and a transformation function
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <param name="f">The transfomer</param>
    /// <typeparam name="S">The source element type</typeparam>
    /// <typeparam name="T">The target element type</typeparam>
    [MethodImpl(Inline)]
    public static T[] array<S,T>(IEnumerable<S> src, Func<S,T> f)
        => src.Select(f).ToArray();

    [MethodImpl(Inline)]
    public static IEnumerable<T> concat<T>(params IEnumerable<T>[] src)
        where T : struct
        => src.SelectMany(x => x);

    /// <summary>
    /// Concatentates two byte arrays
    /// </summary>
    /// <param name="first">The first array of bytes</param>
    /// <param name="second">The second array of bytes</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    [MethodImpl(Inline)]
    public static byte[] concat(byte[] first, byte[] second)
    {
        byte[] ret = new byte[first.Length + second.Length];
        Buffer.BlockCopy(first, 0, ret, 0, first.Length);
        Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
        return ret;
    }


    /// <summary>
    /// Concatentates a parameter array of byte arrays
    /// </summary>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static byte[] concat(params byte[][] src)
    {
        byte[] ret = new byte[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (byte[] data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of byte arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static byte[] concat(IEnumerable<byte[]> src)
    {
        byte[] ret = new byte[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (byte[] data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of parameter arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static T[] concat<T>(params T[][] src)
        where T : struct
    {
        var ret = new T[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (var data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

    /// <summary>
    /// Concatenates a sequence of arrays
    /// </summary>
    /// <param name="src">The source arrays</param>
    /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
    public static T[] concat<T>(IEnumerable<T[]> src)
        where T : struct
    {
        var ret = new T[src.Sum(x => x.Length)];
        int offset = 0;
        foreach (var data in src)
        {
            Buffer.BlockCopy(data, 0, ret, offset, data.Length);
            offset += data.Length;
        }
        return ret;
    }

}