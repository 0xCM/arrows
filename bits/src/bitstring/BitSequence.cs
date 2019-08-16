//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    partial class Bits
    {        
        /// <summary>
        /// Constructs a sequence of 8 bytes {bi} := [b7,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(byte value)
            => ByteIndex.BitSeq(value);

        /// <summary>
        /// Constructs a sequence of 8 signed bytes {bi} := [b7,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled. The uppermost bit b7 determines
        /// the sign
        /// </summary>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(sbyte value)
            => MemoryMarshal.Cast<sbyte,byte>(ByteIndex.BitSeq(value));

        /// <summary>
        /// Constructs a sequence of 16 bytes {bi} := [b15,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(ushort value)
        {
            (var lo, var hi) = split(value);
            Span<byte> dst = new byte[16];
            bitseq(lo).CopyTo(dst,0);
            bitseq(hi).CopyTo(dst,8);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(short value)
        {
            (var lo, var hi) = split(value);
            Span<byte> dst = new byte[16];
            bitseq((byte)lo).CopyTo(dst,0);
            bitseq((byte)hi).CopyTo(dst,8);
            return dst;            
        }

        /// <summary>
        /// Constructs a sequence of 32 bytes {bi} := [b31,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(uint value)
        {
            (var lo, var hi) = split(value);
            Span<byte> dst = new byte[32];
            bitseq(lo).CopyTo(dst,0);
            bitseq(hi).CopyTo(dst,16);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(int value)
        {
            (var lo, var hi) = split(value);
            Span<byte> dst = new byte[32];
            bitseq((ushort)lo).CopyTo(dst,0);
            bitseq((ushort)hi).CopyTo(dst,16);
            return dst;            
        }

        /// <summary>
        /// Constructs a sequence of 64 bytes {bi} := [b63,...b0] over the domain {0,1} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(ulong src)
        {
            (var lo, var hi) = Bits.split(src);
            Span<byte> dst = new byte[64];
            bitseq(lo).CopyTo(dst,0);
            bitseq(hi).CopyTo(dst,32);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> bitseq(long src)
        {
            (var lo, var hi) = Bits.split(src);
            Span<byte> dst = new byte[64];
            bitseq((uint)lo).CopyTo(dst,0);
            bitseq((uint)hi).CopyTo(dst,32);
            return dst;            
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 8 (or fewer) bytes from the source into a single byte
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
        {
            dst = 0;
            var count = Math.Min(8, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (byte)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 16 (or fewer) bytes from the source into an unsigned short
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
        {
            dst = 0;
            var count = Math.Min(16, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (ushort)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 32 (or fewer) bytes from the source into an unsigned int
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
        {
            dst = 0u;
            var count = Math.Min(32, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1u << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 64 (or fewer) bytes from the source into an unsigned long
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
        {
            dst = 0ul;
            var count = Math.Min(64, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1ul << i);
            return ref dst;
        }
    }
}