//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    public static class HashCodeX
    {
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

    /// <summary>
    /// Represents a (.Net) hash code and defines related operations
    /// </summary>
    public readonly struct HashCode : IEquatable<HashCode>
    {
        public static readonly HashCode Zero = new HashCode(0);

        [MethodImpl(Inline)]
        static HashCode hash<X1>(X1 x1)
            => new HashCode(x1?.GetHashCode() ?? 0);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2>(X1 x1, X2 x2)
            => hash(x1) + hash(x2);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <typeparam name="X3">The type of the third value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <param name="x3">The third value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2, X3>(X1 x1, X2 x2, X3 x3)
            => hash(x1) + hash(x2) + hash(x3);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <typeparam name="X3">The type of the third value</typeparam>
        /// <typeparam name="X4">The type of the fourth value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <param name="x3">The third value</param>
        /// <param name="x4">The fourth value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2, X3, X4>(X1 x1, X2 x2, X3 x3, X4 x4)
            => hash(x1) + hash(x2) + hash(x3) + hash(x4);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <typeparam name="X3">The type of the third value</typeparam>
        /// <typeparam name="X4">The type of the fourth value</typeparam>
        /// <typeparam name="X5">The type of the fifth value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <param name="x3">The third value</param>
        /// <param name="x4">The fourth value</param>
        /// <param name="x5">The fifth value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2, X3, X4, X5>(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5)
            => hash(x1) + hash(x2) + hash(x3) + hash(x4) + hash(x5);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <typeparam name="X3">The type of the third value</typeparam>
        /// <typeparam name="X4">The type of the fourth value</typeparam>
        /// <typeparam name="X5">The type of the fifth value</typeparam>
        /// <typeparam name="X6">The type of the sixth value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <param name="x3">The third value</param>
        /// <param name="x4">The fourth value</param>
        /// <param name="x5">The fifth value</param>
        /// <param name="x6">The sixth value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2, X3, X4, X5, X6>(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6)
            => hash(x1) + hash(x2) + hash(x3) + hash(x4) + hash(x5) + hash(x6);

        /// <summary>
        /// Computes the hash code of each component value and combines the result
        /// </summary>
        /// <typeparam name="X1">The type of the first value</typeparam>
        /// <typeparam name="X2">The type of the second value</typeparam>
        /// <typeparam name="X3">The type of the third value</typeparam>
        /// <typeparam name="X4">The type of the fourth value</typeparam>
        /// <typeparam name="X5">The type of the fifth value</typeparam>
        /// <typeparam name="X6">The type of the sixth value</typeparam>
        /// <typeparam name="X7">The type of the seventh value</typeparam>
        /// <param name="x1">The first value</param>
        /// <param name="x2">The second value</param>
        /// <param name="x3">The third value</param>
        /// <param name="x4">The fourth value</param>
        /// <param name="x5">The fifth value</param>
        /// <param name="x6">The sixth value</param>
        /// <param name="x7">The seventh value</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X1, X2, X3, X4, X5, X6, X7>(X1 x1, X2 x2, X3 x3, X4 x4, X5 x5, X6 x6, X7 x7)
            => hash(x1) + hash(x2) + hash(x3) + hash(x4) + hash(x5) + hash(x6) + hash(x7);

        /// <summary>
        /// Computes the hash of each item and folds the results into a single <see cref="HashCode"/> value
        /// </summary>
        /// <typeparam name="X">The item type</typeparam>
        /// <param name="stream">The items to be hashed</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static HashCode hash<X>(IEnumerable<X> stream)
            => stream.Aggregate(Zero, (x, y) => hash(x) + hash(y));

        [MethodImpl(Inline)]
        public static implicit operator int(HashCode h)
            => h.Value;

        [MethodImpl(Inline)]
        public static implicit operator HashCode(int h)
            => new HashCode(h);

        static readonly int RandomSeed = Guid.NewGuid().GetHashCode();        

        [MethodImpl(Inline)]
        public static HashCode operator +(HashCode h1, HashCode h2)
        {
            //Taken from .net framework source: System/Numerics/Hashing/HashHelpers.cs
            unchecked
            {
                // RyuJIT optimizes this to use the ROL instruction
                // Related GitHub pull request: dotnet/coreclr#1830
                uint rol5 = ((uint)h1.Value << 5) | ((uint)h1.Value >> 27);
                return ((int)rol5 + h1) ^ h2;
            }
        }


        [MethodImpl(Inline)]
        public HashCode(int Value)
            => this.Value = Value;

        public int Value { get; }

        [MethodImpl(Inline)]
        public bool Equals(HashCode other)
            => Value == other.Value;

        public override string ToString()
            => Value.ToString();

        public override bool Equals(object obj)
            => (obj is HashCode h) ? Equals(h) : false;

        public override int GetHashCode()
            => Value;
    }
}