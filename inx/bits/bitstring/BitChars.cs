//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    partial class Bits
    {        
        /// <summary>
        /// Constructs a sequence of 8 characters {ci} := [c7,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(byte src)
            => ByteIndex.BitChars(src);

        /// <summary>
        /// Constructs a sequence of 8 characters {ci} := [c7,...c0] over the domain {'0','1'} according to whether the
        /// bit in the i'th position of the source is respecively disabled/enabled
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(sbyte src)
            => ByteIndex.BitChars(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(ushort src)
        {
            const int len = 16;
            const int midpoint = 8;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(short src)
        {
            const int len = 16;
            const int midpoint = 8;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(uint src)
        {
            const int len = 32;
            const int midpoint = 16;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(int src)
        {
            const int len = 32;
            const int midpoint = 16;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(ulong src)
        {
            const int len = 64;
            const int midpoint = 32;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> bitchars(long src)
        {
            const int len = 64;
            const int midpoint = 32;
            (var lo, var hi) = Bits.split(src);
            Span<char> dst = new char[len];
            bitchars(lo).CopyTo(dst,0);
            bitchars(hi).CopyTo(dst,midpoint);
            return dst;            
        }


    }

}