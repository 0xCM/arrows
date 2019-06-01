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

    partial class xfunc
    {
        public static Span<Bit> ToBits(this ReadOnlySpan<char> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<char> src, out Span<Bit> dst)
            => src.ToReadOnlySpan().ToBits(out dst);


        [MethodImpl(Inline)]
        public static Bit ToBit(this BinaryDigit digit)
            => digit == BinaryDigit.One;

        public static Span<Bit> ToBits(this ReadOnlySpan<BinaryDigit> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i].ToBit();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit> ToBits(this Span<BinaryDigit> src, out Span<Bit> dst)
            => src.ToReadOnlySpan().ToBits(out dst);

        /// <summary>
        /// Consructs a bit sream from a stream of bools
        /// </summary>
        /// <param name="src">The bitstring source</param>
        public static Span<Bit> ToBits(this ReadOnlySpan<bool> src, out Span<Bit> dst)
        {
            dst = span<Bit>(src.Length);
            for(var i = 0; i < src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

    }


}