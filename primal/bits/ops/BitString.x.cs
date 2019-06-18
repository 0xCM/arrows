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
    using static Bits;

    public static class BitStringX
    {
        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this sbyte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this byte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this short src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ushort src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this int src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this uint src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this long src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this ulong src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this float src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        /// <summary>
        /// Encodes the source value as a <see cref= 'BitString' />
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static BitString ToBitString(this double src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        [MethodImpl(Inline)]        
        public static BitString ToBitString(this Span<byte> src)
        {
            var dst = span<char>(src.Length);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = src[i] == 1 ? '1' : '0';
            return new string(dst);
        }

        [MethodImpl(Optimize)]
        public static ref Span<byte> BitStringBytes(this ReadOnlySpan<char> src, out Span<byte> dst)
        {
            dst = span<byte>(src.Length/8);
            for(var i=0; i<src.Length; i++)
            for(var j=0; j < 8; j++)
               if(src[i] == Bit.One) enable(ref dst[i], j);
            return ref dst;
        }
 
 
    }
}