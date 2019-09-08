//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    public static class BitFormatX
    {
        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this byte src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this sbyte src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this short src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this ushort src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this uint src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this int src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this ulong src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this long src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier,blockWidth);

        /// <summary>
        /// Formats the source value as a bitstring
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        [MethodImpl(Inline)]
        public static string FormatBits(this UInt128 src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            => src.ToBitString().Format(tlz, specifier, blockWidth);

        /// <summary>
        /// Formats span cells as bitstrings
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="tlz">Whether to trim leading zeros from the cell values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static string FormatBits<T>(this ReadOnlySpan<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : struct
        {
            var sb = sbuild();
            for(var i=0; i<src.Length; i++)
            {
                var bs = BitString.FromScalar(in src[i]).Format(tlz,specifier,blockWidth);
                sb.Append(bs);
                if(i != src.Length - 1)
                    sb.Append(AsciSym.Space);                    
            }
            return sb.ToString();

        }

        /// <summary>
        /// Formats vector components as bitstrings
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="tlz">Whether to trim leading zeros from the component values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<T>(this Vec128<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : struct
                => src.ToReadOnlySpan().FormatBits(tlz,specifier, blockWidth);

        /// <summary>
        /// Formats the vector content as bitstring(s)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="tlz">Whether to trim leading zeros from the component values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<T>(this Vec256<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : struct
                => src.ToReadOnlySpan().FormatBits(tlz,specifier, blockWidth);

        /// <summary>
        /// Formats the vector content as bitstring(s)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="tlz">Whether to trim leading zeros from the component values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<T>(this Vec512<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : struct
                => src.ToReadOnlySpan().FormatBits(tlz,specifier, blockWidth);

        /// <summary>
        /// Formats the vector content as bitstring(s)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="tlz">Whether to trim leading zeros from the component values</param>
        /// <param name="specifier">Whether to prefix rendered bitstrings with the '0b' specifier</param>
        /// <param name="blockWidth">The number of binary digits per block, if specified</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatBits<T>(this Vec1024<T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where T : struct
                => src.ToReadOnlySpan().FormatBits(tlz,specifier, blockWidth);

    }

}