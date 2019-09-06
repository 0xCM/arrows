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
        /// Encodes span content as a bitstring
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Span<T> src)
            where T : struct
                => BitString.FromScalars(src); 

        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this Memory<T> src)
            where T : struct
                => BitString.FromScalars(src); 

        [MethodImpl(Inline)]        
        public static BitString ToBitString<T>(this ReadOnlyMemory<T> src)
            where T : struct
                => BitString.FromScalars(src); 

        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<Bit> src)
            => BitString.FromBits(src);

        [MethodImpl(Inline)]        
        public static BitString ToBitString(this ReadOnlySpan<Bit> src)
            => BitString.FromBits(src);

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
        /// Reverses the order of bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]   
        public static BitString Reverse(this BitString src)
        {
            src.BitSeq.Reverse();
            return src;
        }

        /// <summary>
        /// Encodes the source value as a reversed <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToReversedBitString(this byte src)
        {
            var bs = src.ToBitString();
            bs.Reverse();
            return bs;
        }

        /// <summary>
        /// Encodes the source value as a reversed <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToReversedBitString(this ushort src)
        {
            var bs = src.ToBitString();
            bs.Reverse();
            return bs;
        }

        /// <summary>
        /// Encodes the source value as a reversed <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToReversedBitString(this uint src)
        {
            var bs = src.ToBitString();
            bs.Reverse();
            return bs;
        }

        /// <summary>
        /// Encodes the source value as a reversed <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitString ToReversedBitString(this ulong src)
        {
            var bs = src.ToBitString();
            bs.Reverse();
            return bs;
        }

        /// <summary>
        /// Computes the width of the range, including the endpoints
        /// </summary>
        /// <param name="src">The source range</param>
        [MethodImpl(Inline)]
        public static int Width(this Range src)
            => src.End.Value - src.Start.Value + 1;

        [MethodImpl(Inline)]
        public static BitString ToBitString(this UInt128 src)
            => BitString.FromScalar(src.hi) + BitString.FromScalar(src.lo);
    }
}