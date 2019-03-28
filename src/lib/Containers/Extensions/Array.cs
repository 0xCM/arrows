//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;



    using static Z0.Bibliography;
    using static zcore;


    partial class xcore
    {
        /// <summary>
        /// Creates a transformed array
        /// </summary>
        /// <typeparam name="S">The source item type</typeparam>
        /// <typeparam name="T">The target item type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="transform">The transformation function</param>
        /// <returns></returns>
        public static T[] ToArray<S, T>(this IEnumerable<S> src, Func<S, T> transform)
            => src.Select(transform).ToArray();

        /// <summary>
        /// Returns a segment of an array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static T[] SubArray<T>(this T[] input, int startIndex, int length)
        {
            var result = new List<T>();
            for (int i = startIndex; i < length; i++)
                result.Add(input[i]);
            return result.ToArray();
        }

        /// <summary>
        /// Creates a new array by appending the elements determined by the second array
        /// to the elements determined by the first array
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="head">The first array</param>
        /// <param name="tail">The second array</param>
        /// <returns></returns>
        public static X[] Append<X>(this X[] head, X[] tail)
        {
            var result = new X[head.Length + tail.Length];
            Array.Copy(head, 0, result, 0, head.Length);
            Array.Copy(tail, 0, result, head.Length, tail.Length);
            return result;
        }

        /// <summary>
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The position of the first element of the source array </param>
        /// <param name="endpos">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] Subset<T>(this T[] src, int startpos, int endpos)
        {
            var len = endpos - startpos + 1;
            var dst = new T[len];
            Array.Copy(src, startpos, dst, 0, len);
            return dst;
        } 

        /// <summary>
        /// Defines a window over a 1-d array beginning at a specified index 
        /// for a specified length
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The 0-based starting index</param>
        /// <param name="len">The length of the segment</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IReadOnlyList<T> Segment<T>(this T[] src, uint start, uint len)
            => new ArraySegment<T>(src, (int)start, (int)len);

    }
}