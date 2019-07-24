//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class BitStringX
    {
        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this float src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this double src)
            => BitString.FromScalar(src);

        /// <summary>
        /// Converts a readonly span of bytes to a bitstring
        /// </summary>
        /// <param name="src">The source bytes</param>
        public static BitString ToBitString(this ReadOnlySpan<byte> src, int? bitcount = null)
            => BitString.FromScalars(gbits.bitchars(src, bitcount));

        /// <summary>
        /// Converts a span of bytes to a bitstring
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<byte> src, int? bitcount = null)
            => src.ReadOnly().ToBitString(bitcount);

        /// <summary>
        /// Converts a span of bytes to span of bit characters
        /// </summary>
        /// <param name="src">The source bytes</param>
        [MethodImpl(Inline)]        
        public static Span<char> ToBitChars(this Span<byte> src, int? bitcount = null)
            => gbits.bitchars(src.ReadOnly(), bitcount);

        [MethodImpl(Inline)]        
        public static Span<char> ToBitChars<T>(this Span<T> src, int? bitcount = null)
            where T : struct
                => gbits.bitchars(src.AsBytes(), bitcount);

        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Span<T> src, int? bitcount = null)
            where T : struct
                => gbits.bitchars(src.AsSBytes(), bitcount).ToBitString();

        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<Bit> src)
                => BitString.FromBits(src);

        [MethodImpl(Inline)]        
        public static BitString ToBitString(this ReadOnlySpan<Bit> src)
                => BitString.FromBits(src);

        /// <summary>
        /// Converts a generic number to a bitstring
        /// </summary>
        /// <param name="src">The source number</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString ToBitString<T>(this num<T> src)
            where T : struct
                => BitString.FromScalar<T>(src.Scalar());

        /// <summary>
        /// Converts a number to a string of decimal digits
        /// </summary>
        /// <param name="src">The source integer</param>
        /// <typeparam name="T">The underlying primitive type</typeparam>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<BinaryDigit> ToBinaryDigits<T>(this num<T> src)
            where T : struct    
                =>  BitString.FromScalar(src.Scalar()).ToDigits();

        /// <summary>
        /// Converts an 128-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vec128<T> src)
            where T : struct        
                => BitString.FromScalars(src.Extract());
        
        /// <summary>
        /// Converts an 256-bit intrinsic vector representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this Vec256<T> src)
            where T : struct        
            => BitString.FromScalars(src.Extract());        

        /// <summary>
        /// Converts an 256-bit intrinsic integer representation to a bistring
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this __m256i src)
            where T : struct
                => src.ToVec256<T>().ToBitString();

        /// <summary>
        /// Converts a bitview to a bitstring
        /// </summary>
        /// <param name="src">The view source</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]   
        public static BitString ToBitString<T>(this BitView<T> src)
            where T : struct
                => src.ToSpan().ToBitString();

        /// <summary>
        /// Explicitly invokes a <see cref='BitString'/> implicit constructor
        /// </summary>
        /// <param name="src">The source bitchars</param>
        [MethodImpl(Inline)]   
        public static BitString ToBitString(this Span<char> src)
            => BitString.FromScalars(src);
    }
}