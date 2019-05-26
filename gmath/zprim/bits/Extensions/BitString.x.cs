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

    partial class BitX
    {
        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in sbyte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 8 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in byte src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in short src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 16 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in ushort src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in int src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 32 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in uint src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src,tlz,pfs);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in long src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);

        /// <summary>
        /// Produces a string 64 characters in length that encodes the bits in the source
        /// where set bits are represented with the character '1' and unset bits are
        /// represented with the character '0;
        /// </summary>
        /// <param name="src">The value for which a bitstring will be produced</param>
        /// <param name="tlz">Specifies whether to trim leading zeros from the representation</param>
        /// <param name="pfs">Specifies whether to prepend the '0b' format specifier to the representation</param>
        [MethodImpl(Inline)]
        public static string ToBitString(this in ulong src, bool tlz = false, bool pfs = false)
            => gbits.bitstring(src, tlz, pfs);


        [MethodImpl(Inline)]
        public static string ToBitString<T>(this num<T> src, bool tlz = false, bool pfs = false)
            where T : struct
                => gbits.bitstring<T>(src.Scalar(), tlz, pfs);

        [MethodImpl(Inline)]        
        public static string ToBitString(this Span<byte> src)
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