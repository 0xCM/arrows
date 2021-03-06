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

        /// <summary>
        /// Returns true if a floating point value represents positive infinity, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsPosInf(this float src)
            => float.IsPositiveInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents positive infinity, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsPosInf(this double src)
            => double.IsPositiveInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents negative infinity, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNegInf(this float src)
            => float.IsNegativeInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents negative infinity, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNegInf(this double src)
            => double.IsNegativeInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents an infinite value, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Infinite(this float src)
            => float.IsPositiveInfinity(src) || float.IsNegativeInfinity(src);

        /// <summary>
        /// Returns true if a floating point value represents an infinite value, false otherwise
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Infinite(this double src)
            => double.IsPositiveInfinity(src) || double.IsNegativeInfinity(src);


        /// <summary>
        /// Returns true if a floating point value is non-infinite
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Finite(this float src)
            => !float.IsPositiveInfinity(src) && !float.IsNegativeInfinity(src) && !float.IsNaN(src);

        /// <summary>
        /// Returns true if a floating point value is non-infinite
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool Finite(this double src)
            => !double.IsPositiveInfinity(src) && !double.IsNegativeInfinity(src) && !double.IsNaN(src);

        public static IEnumerable<ulong> ToU64Stream(this IEnumerable<Guid> guids)
        {
            foreach(var guid in guids)
            {
                var bytes = guid.ToByteArray();      
                yield return BitConverter.ToUInt64(bytes,0);
                yield return BitConverter.ToUInt64(bytes,4);
            }            
        }

        [MethodImpl(Inline)]
        public static ulong[] ToU64Array(this IEnumerable<Guid> guids)
            => guids.ToU64Stream().ToArray();

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

        /// <summary>
        /// Formats the supplied decimal value as currency to two decimal places
        /// </summary>
        /// <param name="d">The decimal value</param>
        public static string FormatAsCurrency(this decimal src, int scale = 2)
            => String.Format(embrace($"0:C{scale}"), src);

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this short src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this ushort src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this int src)
                => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this uint src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this long src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this ulong src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this float src)
            => src.ToString("#,#");

        /// <summary>
        /// Formamats a number with comma separators
        /// </summary>
        /// <param name="src">The source number</param>
        [MethodImpl(Inline)]
        public static string CommaSeparated(this double src)
            => src.ToString("#,#");

        [MethodImpl(Inline)]
        public static char ToCharDigit(this byte src)
        {
            if(src == 0)
                return '0';
            else if(src == 1)
                return '1';
            else if(src == 2)
                return '2';
            else if(src == 3)
                return '3';
            else if(src == 4)
                return '4';
            else if(src == 5)
                return '5';
            else if(src == 6)
                return '6';
            else if(src == 7)
                return '7';
            else if(src == 8)
                return '8';
            else if(src == 9)
                return '9';
            else
                return '∅';                        
        }
                        
        public static IEnumerable<char> ToCharDigits(this IEnumerable<byte> src)
        {
            foreach(var item in src)
                yield return item.ToCharDigit();
        }

        public static IEnumerable<char> ToCharDigits(this IEnumerable<sbyte> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<short> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<ushort> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<int> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<uint> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<long> src)
            => src.Convert<byte>().ToCharDigits();

        public static IEnumerable<char> ToCharDigits(this IEnumerable<ulong> src)
            => src.Convert<byte>().ToCharDigits();
    }
}