//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using Z0;
    using static zcore;

    partial class xcore
    {


        [MethodImpl(Inline)]   
        public static T[] Unwrap<T>(this intg<T>[] src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);


        [MethodImpl(Inline)]   
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<intg<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IReadOnlyList<intg<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);


        [MethodImpl(Inline)]   
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<real<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static T[] Unwrap<T>(this real<T>[] src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> Unwrap<T>(this IReadOnlyList<real<T>> src)
            where T : struct, IEquatable<T>
                => map(src, unwrap);

        [MethodImpl(Inline)]
        public static T Sum<T>(this IEnumerable<T> src)
            where T : Structures.Additive<T>, Structures.Nullary<T>, new()
                => sum(src);

        [MethodImpl(Inline)]
        public static T Sup<T>(this IEnumerable<T> src)
            where T : struct, Structures.Orderable<T>
                => max(src);

        [MethodImpl(Inline)]
        public static T Inf<T>(this Index<T> src)
            where T : struct, Structures.Orderable<T>
                => min(src);

        [MethodImpl(Inline)]
        public static IEnumerable<T> Pow<T>(this IEnumerable<T> src, int exp)
            where T : Structures.NaturallyPowered<T>, new() 
                => pow(src,exp);

        [MethodImpl(Inline)]
        public static Slice<T> Pow<T>(this Slice<T> src, int exp)
            where T : struct, Structures.NaturallyPowered<T>
                => slice(pow(src,exp));

        [MethodImpl(Inline)]
        public static T Avg<T>(this IEnumerable<T> src)
            where T : Structures.RealNumber<T>,new()
                => avg(src);

        [MethodImpl(Inline)]   
        public static string ToHexString(this byte x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this sbyte x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this short x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this ushort x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this int x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this uint x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this long x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this ulong x)
            => hexstring(x);


        [MethodImpl(Inline)]   
        public static string ToHexString(this BigInteger x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this decimal src)
            => hexstring(src);
 
        public static IEnumerable<T> Collapse<T>(IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(x => x);


        /// <summary>
        /// Determines whether a double value is equivalent to the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNaN(this float src)
            => NaN(src);

        /// <summary>
        /// Determines whether a value is equivalent to the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNaN(this double src)
            => NaN(src);

        /// <summary>
        /// Determines whether a double value is bounded 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsFinite(this double src)
            => finite(src);

        /// <summary>
        /// Determines whether a value is negative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNegative(this double src)
            => double.IsNegative(src);

        /// <summary>
        /// Determines whether a value is positive
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsPositive(this double src)
            => src > 0;

        /// <summary>
        /// Determines whether a value is nonzero
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNonzero(this double src)
            => nonzero(src);
   }
}