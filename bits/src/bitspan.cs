//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;
    using static As;
    using static AsIn;

    public static class bitspan
    {


 

        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<byte> src)
        {
            var count = 0ul;            
            for(var i = 0; i < src.Length; i++)
                count += Bits.pop(src[i]);
            return count;
        }

        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<ulong> src)
        {
            var count = 0u;
            for(var i=0; i<src.Length; i++)
                count += Bits.pop(src[i]);
            return count;
        }

        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<uint> src)
        {
            var count = 0u;
            for(var i=0; i<src.Length; i++)
                count += Popcnt.PopCount(src[i]);
            return count;
        }

        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<ushort> src)
        {
            var count = 0u;
            for(var i=0; i<src.Length; i++)
                count += Popcnt.PopCount(src[i]);
            return count;
        }


        public static Span<byte> rotr(ReadOnlySpan<byte> src, byte offset, Span<byte> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], offset);                            
            return dst;
        }

        public static Span<ushort> rotr(ReadOnlySpan<ushort> src, ushort offset, Span<ushort> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], offset);                            
            return dst;
        }

        public static Span<uint> rotr(ReadOnlySpan<uint> src, uint offset, Span<uint> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], offset);                            
            return dst;
        }

        public static Span<ulong> rotr(ReadOnlySpan<ulong> src, ulong offset, Span<ulong> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], offset);                            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> rotr(ReadOnlySpan<byte> src, byte offset)
            => rotr(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ushort> rotr(ReadOnlySpan<ushort> src, ushort offset)
            => rotr(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<uint> rotr(ReadOnlySpan<uint> src, uint offset)
            => rotr(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ulong> rotr(ReadOnlySpan<ulong> src, ulong offset)
            => rotr(src,offset,src.Replicate(true));


        public static Span<byte> rotl(ReadOnlySpan<byte> src, byte offset, Span<byte> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], offset);                            
            return dst;
        }

        public static Span<ushort> rotl(ReadOnlySpan<ushort> src, ushort offset, Span<ushort> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], offset);                            
            return dst;
        }

        public static Span<uint> rotl(ReadOnlySpan<uint> src, uint offset, Span<uint> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], offset);                            
            return dst;
        }

        public static Span<ulong> rotl(ReadOnlySpan<ulong> src, ulong offset, Span<ulong> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], offset);                            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> rotl(ReadOnlySpan<byte> src, byte offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ushort>  rotl(ReadOnlySpan<ushort> src, ushort offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<uint>  rotl(ReadOnlySpan<uint> src, uint offset)
            => rotl(src,offset,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ulong>  rotl(ReadOnlySpan<ulong> src, ulong offset)
            => rotl(src,offset,src.Replicate(true));
 
    }


}