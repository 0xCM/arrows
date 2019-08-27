//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    partial class ginxs
    {

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this ReadOnlySpan<T> src, bool vectorize = false, char? sep = null)
            where T : struct
        {
            var delimiter = sep ?? (vectorize ? AsciSym.Comma : AsciSym.Space);
            var fmt = sbuild();
            if(vectorize)
                fmt.Append(AsciSym.Lt);

            for(var i = 0; i<src.Length; i++)
            {
                fmt.Append(gmath.hexstring(src[i], true, false));
                if(i != src.Length - 1)
                    fmt.Append((char)delimiter);
            }
            
            if(vectorize)
                fmt.Append(AsciSym.Gt);
            
            return fmt.ToString();

        }

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this T[] src, bool vectorize = false, char? sep = null)
            where T : struct
                => FormatHex(src.ToReadOnlySpan(),vectorize,sep);

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Span<T> src, bool vectorize = false, char? sep = null)
            where T : struct
                => src.ReadOnly().FormatHex(vectorize, sep);

       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this Span<N,T> src, bool vectorize = false, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize, sep);

        /// <summary>
        /// Formats the span cell values in base-16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="vectorize">Whether to render to content as a vector, i.e. components comma-separated 
        /// and enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <typeparam name="T">The primal cell type</typeparam>
       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this ReadOnlySpan<N,T> src, bool vectorize = false, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize, sep);

        /// <summary>
        /// Formats the vector component values in base-16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render to content as a vector, i.e. components comma-separated 
        /// and enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec128<T> src, bool vectorize = true, char? sep = null)
            where T : struct
                => src.ToSpan().FormatHex(vectorize, sep);

        /// <summary>
        /// Formats the vector component values in base-16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render to content as a vector, i.e. components comma-separated 
        /// and enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec256<T> src, bool vectorize = true, char? sep = null)
             where T : struct
                => src.ToSpan().FormatHex(vectorize,sep); 

        /// <summary>
        /// Formats the vector component values in base-16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render to content as a vector, i.e. components comma-separated 
        /// and enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec512<T> src, bool vectorize = true, char? sep = null)
            where T : struct
                => src.ToSpan().FormatHex(vectorize,sep);

        /// <summary>
        /// Formats vector component values in base-16
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="vectorize">Whether to render to content as a vector, i.e. components comma-separated 
        /// and enclosed by angular brackets</param>
        /// <param name="sep">The character to use as a separator, if applicable</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<T>(this Vec1024<T> src, bool vectorize = true, char? sep = null)
            where T : struct
                => src.ToSpan().FormatHex(vectorize,sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this ReadOnlySpan<T> src, int? width = null, char? sep = null)
                where T : struct
                    => src.FormatHex().SeparateBlocks(width ?? Unsafe.SizeOf<T>(), sep ?? AsciSym.Space);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Span<T> src, int? width = null, char? sep = null)
                where T : struct
                    => src.ReadOnly().FormatHexBlocks(width, sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this Span<N,T> src, int? width = null, char? sep = null)
                where N : ITypeNat, new()
                where T : struct
                    => src.Unsize().FormatHexBlocks(width,sep);

        /// <summary>
        /// Formats span cells as blocked hex
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<N,T>(this ReadOnlySpan<N,T> src, int? width = null, char? sep = null)
                where N : ITypeNat, new()
                where T : struct
                    => src.Unsize().FormatHexBlocks(width,sep);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vec256<T> src)
            where T : struct
                => src.FormatHex(false, AsciSym.Space);

        /// <summary>
        /// Formats vector components as blocked hex
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="width">The block width</param>
        /// <param name="sep">The block delimiter</param>
        /// <typeparam name="T">The cell component type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHexBlocks<T>(this Vec512<T> src)
                where T : struct
                    => src.FormatHex(false, AsciSym.Space);

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