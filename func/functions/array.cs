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
    public const sbyte ZeroI8 = 0;

    public const byte ZeroU8 = 0;

    public const short ZeroI16 = 0;

    public const ushort ZeroU16 = 0;

    public const int ZeroI32 = 0;

    public const uint ZeroU32 = 0u;

    public const long ZeroI64 = 0L;

    public const ulong ZeroU64 = 0ul;

    public const sbyte OneI8 = 1;

    public const byte OneU8 = 1;

    public const short OneI16 = 1;
    
    public const ushort OneU16 = 1;

    public const int OneI32 = 1;

    public const uint OneU32 = 1u;

    public const long OneI64 = 1L;

    public const ulong OneU64 = 1UL;

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

        public static void copy<T>(T[] src, T[] dst)
        {
            if(src.Length > dst.Length)
                throw new ArgumentException("The source array is bigger than the target array");

            Array.Copy(src,dst,src.Length);
        }

        /// <summary>
        /// Concatentates two byte arrays
        /// </summary>
        /// <param name="first">The first array of bytes</param>
        /// <param name="second">The second array of bytes</param>
        /// <remarks>See https://stackoverflow.com/questions/415291/best-way-to-combine-two-or-more-byte-arrays-in-c-sharp</remarks>
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
            => src.SelectMany(x => x);

}