//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class xfunc
    {
        /// <summary>
        /// Constructs an array of specified length from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] TakeArray<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToArray();

        /// <summary>
        /// Constructs a readonly list from from the entirety of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Freeze<T>(this IEnumerable<T> src)
                => src.ToArray();

        /// <summary>
        /// Constructs an array from from the a specified number of
        /// elmements from the head of a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Freeze<T>(this IEnumerable<T> src, int length)
                => src.TakeArray(length);

        /// <summary>
        /// Constructs an index of specified length from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Freeze<T>(this IEnumerable<T> src, uint count)
            => src.TakeArray((int)count);

        /// <summary>
        /// Constructs a readonly list from from the a specified number of
        /// elmements from stream after a skip
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Freeze<T>(this IEnumerable<T> src, int skip, int count)
            => src.Skip(skip).TakeArray(count);

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="offset">The position of the first element of the source array </param>
        /// <param name="count">The number of elements to take from the source array following the offset</param>
        public static T[] SubArray<T>(this T[] src, int offset, int count)
        {
            var dst = new T[count];
            Array.Copy(src, offset, dst, 0, count);
            return dst;
        } 

        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        public static T[] ToArray<S, T>(this IEnumerable<S> src, Func<S, T> transform)
            => src.Select(transform).ToArray();

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="offset">The position of the first element of the source array </param>
        /// <param name="length">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] Subset<T>(this T[] src, int offset, int length)
            => src.SubArray(offset,length);

        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ArraySegment<T> Segment<T>(this T[] src, uint start, uint len)
            => new ArraySegment<T>(src, (int)start, (int)len);

        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ArraySegment<T> Segment<T>(this T[] src, ulong start, ulong len)
            => new ArraySegment<T>(src, (int)start, (int)len);
 
        /// <summary>
        /// Copies a source list to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void CopyTo<T>(this IReadOnlyList<T> src, T[] dst)
        {
            if(src.Count > dst.Length)
                throw new ArgumentException("The source list is bigger than the target array");

            for(var i=0; i< src.Count; i++)
                dst[i] = src[i];
        }

        /// <summary>
        /// Reverses an array in-place
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Reverse<T>(this T[] src)
        {
            Array.Reverse(src);
            return src;
        }

        [MethodImpl(Inline)]
        public static bool ReallyEqual<T>(this T[] lhs, T[] rhs, Func<T,T,bool> predicate = null)
        {
            bool test(T x, T y)
                => predicate?.Invoke(x,y) ?? x.Equals(y);
                
            if(lhs.Length != rhs.Length)
                return false;
            for(var i = 0; i<lhs.Length; i++)
            {
                if(!lhs[i].Equals(rhs[i]))
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Concatenates two arrays
        /// </summary>
        public static T[] ConcatArrays<T>(this T[] first, T[] second)
        {
            var dst = new T[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, dst, 0, first.Length);
            Buffer.BlockCopy(second, 0, dst, first.Length, second.Length);
            return dst;
        }

        [MethodImpl(Inline)]
        public static T[] Replicate<T>(this T[] src)
        {
            var dst = array<T>(src.Length);
            Array.Copy(src, dst, src.Length);
            return dst;
        }

        /// <summary>
        /// Returns the index of the first value that matches a specified value, if any. Otherwise, returns -1
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="value">The value to match in the source</param>
        /// <typeparam name="T">The element type</typeparam>
        public static int FirstIndexOf<T>(this T[] src, T value)
        {
            for(var i=0; i<src.Length; i++)
                if(src[i].Equals(value))
                    return i;
            return -1;
        }

        /// <summary>
        /// Creates a new array by sampling the source array at each specified index
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="indices">The indices that define the values to be extracted from the source</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Values<T>(this T[] src, int[] indices)
        {
            var dst = new T[indices.Length];
            for(var i=0; i< indices.Length; i++)
                dst[i] = src[indices[i]];
            return dst;
        }

        /// <summary>
        /// Fills an array, in-place, with a specified value
        /// </summary>
        /// <param name="src">The input array</param>
        /// <param name="value">The fill value</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Fill<T>(this T[] src, T value)
        {
            for(var i=0; i<src.Length; i++)
                src[i] = value;
            return src;
        }

        /// <summary>
        /// Replicates a source value a specified number of times and returns an array with the result
        /// </summary>
        /// <param name="src">The value to replicate</param>
        /// <param name="count">The number of clones</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Replicate<T>(this T src, int count)
            where T : struct
                => array<T>(count).Fill(src);

    }
}