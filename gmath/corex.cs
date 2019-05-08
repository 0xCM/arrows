namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static mfunc;

    public static class corex
    {
        public static bool IsNaN(this float src)
            => float.IsNaN(src);

        public static bool IsNaN(this double src)
            => double.IsNaN(src);

        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this T? x, T @default = default)
            where T : struct
                => x != null ? x.Value : @default;

        /// <summary>
        /// Produces an array of bits from a stream of binary digits
        /// </summary>
        /// <param name="src">The source digits</param>
        public static Bit[] ToBits(this IEnumerable<BinaryDigit> src)
            => src.Select(d => d == BinaryDigit.B0 ? Bit.Off : Bit.On).ToArray();

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



        //Prime numbers to use when generating a hash code. Taken from John Skeet's answer on SO:
        //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
        const int P1 = 17;
        const int P2 = 23;

        /// <summary>
        /// Helper to compute hash code from a collection of items
        /// </summary>
        /// <typeparam name="S">The item type</typeparam>
        /// <param name="items">The items</param>
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