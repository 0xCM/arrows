//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Diagnostics;
    
    using static zfunc;
    
    partial class xfunc
    {

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this float src)
            => float.IsNaN(src);

        /// <summary>
        /// Returns true if one of the supplied values is the NaN representative
        /// </summary>
        /// <param name="x0">The first source value</param>
        /// <param name="x1">The second source value</param>
        /// <param name="x2">The third source value</param>
        /// <param name="x3">The fourth source value</param>
        [MethodImpl(Inline)]
        public static bool AnyNaN(this float x0, float x1, float x2, float x3)
            => IsNaN(x0) || IsNaN(x1) || IsNaN(x2) || IsNaN(x3);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(this double src)
            => double.IsNaN(src);

        /// <summary>
        /// Replaces a NaN representive value with 0
        /// </summary>
        /// <param name="src">The source value to sanitize</param>
        [MethodImpl(Inline)]
        public static double ClearNaN(this double x, double replacement = -1)
            => x.IsNaN() ? replacement : x;

        /// <summary>
        /// Replaces a NaN representive value with 0
        /// </summary>
        /// <param name="src">The source value to sanitize</param>
        [MethodImpl(Inline)]
        public static float ClearNaN(this float x, float replacement = -1)
            => x.IsNaN() ? replacement : x;

        [MethodImpl(Inline)]
        public static bool IsPosInf(this float src)
            => float.IsPositiveInfinity(src);

        [MethodImpl(Inline)]
        public static bool IsPosInf(this double src)
            => double.IsPositiveInfinity(src);

        [MethodImpl(Inline)]
        public static bool IsNegInf(this float src)
            => float.IsNegativeInfinity(src);

        [MethodImpl(Inline)]
        public static bool IsNegInf(this double src)
            => double.IsNegativeInfinity(src);

        public static IEnumerable<ulong> ToLongs(this IEnumerable<Guid> guids)
        {
            foreach(var guid in guids)
            {
                var bytes = guid.ToByteArray();      
                yield return BitConverter.ToUInt64(bytes,0);
                yield return BitConverter.ToUInt64(bytes,4);
            }            
        }

        [MethodImpl(Inline)]
        public static ulong[] ToLongArray(this IEnumerable<Guid> guids)
            => guids.ToLongs().ToArray();


        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this T? x, T @default = default)
            where T : struct
                => x != null ? x.Value : @default;

        /// <summary>
        /// Produces an array of bits from a stream of binary digits
        /// </summary>
        /// <param name="src">The source digits</param>
        public static Bit[] ToBits(this IEnumerable<BinaryDigit> src)
            => src.Select(d => d == BinaryDigit.Zed ? Bit.Off : Bit.On).ToArray();

    }

}