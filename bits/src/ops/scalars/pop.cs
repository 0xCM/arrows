//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(sbyte src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(byte src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(short src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ushort src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(int src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(uint src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(long src)
            => (uint)Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ulong src)
            => (uint)Popcnt.X64.PopCount(src);
 
        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<byte> src)
        {
            var count = 0ul;            
            for(var i = 0; i < src.Length; i++)
                count += pop(src[i]);
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
                count += pop(src[i]);
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
    }
}