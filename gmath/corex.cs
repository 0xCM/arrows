namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zcore;

    public static class corex
    {
        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this T? x, T @default = default)
            where T : struct
                => x != null ? x.Value : @default;


        /// <summary>
        /// Produces an array of bits from a stream of binary digits
        /// </summary>
        /// <param name="src">The source digits</param>
        public static bit[] ToBits(this IEnumerable<BinaryDigit> src)
            => src.Select(d => d == BinaryDigit.B0 ? bit.off() : bit.on()).ToArray();

        public static IEnumerable<ulong> ToLongs(this IEnumerable<Guid> guids)
        {
            foreach(var guid in guids)
            {
                var bytes = guid.ToByteArray();      
                yield return BitConverter.ToUInt64(bytes,0);
                yield return BitConverter.ToUInt64(bytes,4);
            }
            
        }

        public static ulong[] ToLongArray(this IEnumerable<Guid> guids)
            => guids.ToLongs().ToArray();



        /// <summary>
        /// Constructs an array of specified length from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] TakeArray<T>(this IEnumerable<T> src, int length)
            => src.Take(length).ToArray();


        [MethodImpl(Inline)]
        public static string DisplayName(this MethodBase src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            return attrib != null ? attrib.DisplayName.TrimEnd('/') : src.Name;
        }

        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if (attrib != null)
                return attrib.DisplayName;

            if (!src.IsGenericType)
                return src.Name;

            if (src.IsConstructedGenericType)
            {
                var typeArgs = src.GenericTypeArguments;
                var argFmt = string.Join(",", typeArgs.Select(a => a.DisplayName()).ToArray());
                var typeName = src.Name.Replace($"`{typeArgs.Length}", string.Empty);
                return append(typeName, "<", argFmt, ">");
            }
            else
            {
                var typeArgs = src.GetGenericTypeDefinition().GetGenericArguments();
                var argFmt = string.Join(",", typeArgs.Select(a => a.DisplayName()).ToArray());
                var typeName = src.Name.Replace($"`{typeArgs.Length}", string.Empty);
                return append(typeName, "<", argFmt, ">");
            }
        }


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
        public static bool ReallyEqual<T>(this T[] lhs, T[] rhs)
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
        /// <param name="offset">The position of the first element of the source array </param>
        /// <param name="count">The number of elements to take from the source array following the offset</param>
        public static T[] SubArray<T>(this T[] src, int offset, int count)
        {
            var dst = new T[count];
            Array.Copy(src, offset, dst, 0, count);
            return dst;
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

        //Prime numbers to use when generating a hash code. Taken from John Skeet's answer on SO:
        //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        const int P1 = 17;
        const int P2 = 23;

        /// <summary>
        /// Helper to compute hash code from a collection of items
        /// </summary>
        /// <typeparam name="S">The item type</typeparam>
        /// <param name="items">The items</param>
        /// <returns></returns>
        public static int HashCode<S>(this IEnumerable<S> items)
        {
            if (items == null)
                return 0;

            unchecked
            {
                var hash = P1;
                foreach (var item in items)
                    hash = hash * P2 + item.GetHashCode();
                return hash;
            }
        }

    }
}