//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    /// <summary>
    /// Defines varies array-related operations
    /// </summary>
    public static partial class Arr
    {

        [MethodImpl(Inline)]
        public static bool equals<T>(T[] lhs, T[] rhs)
            where T: IEquatable<T>
        {
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
        /// Creates a new array from a (contiguous) subset of an existing array
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="src">The source array</param>
        /// <param name="startpos">The position of the first element of the source array </param>
        /// <param name="endpos">The position of the last element of the source array</param>
        /// <returns></returns>
        public static T[] subset<T>(this T[] src, int startpos, int endpos)
        {
            var len = endpos - startpos + 1;
            var dst = new T[len];
            Array.Copy(src, startpos, dst, 0, len);
            return dst;
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
        /// Partitions an array into a sequence of subarrays
        /// </summary>
        /// <typeparam name="T">The array element type</typeparam>
        /// <param name="items">The source array</param>
        /// <param name="width">The width of each subarray</param>
        public static IEnumerable<T[]> Partition<T>(this T[] items, int width)
        {
            var dst = array<T>(width);
            var idx = 0;
            foreach (var item in items)
            {
                dst[idx++] = item;
                if (width - idx == 1)
                {
                    yield return dst;
                    dst = array<T>(width);
                    idx = 0;
                }
            }
            
            if (idx != 0)
                yield return dst;
        }

    }


}

