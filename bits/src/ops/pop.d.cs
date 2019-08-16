//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                
        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(sbyte src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(byte src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(short src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(ushort src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(int src)
            => Popcnt.PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(uint src)
            => Popcnt.PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(long src)
            => Popcnt.X64.PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ulong pop(ulong src)
            => Popcnt.X64.PopCount(src);
 
        public static ulong pop(Span<byte> src)
        {
            var count = U64Zero;
            var blocksize = Pow2.T03;
            math.quorem(src.Length, blocksize, out Quorem<int> qr);
            for(var i = 0; i < src.Length; i+=blocksize)
            {
                Bytes.read(src, i, out ulong data);
                count += Popcnt.X64.PopCount(data);
            }
            return count;
        }

        /// <summary>
        /// Counts the total population of enabled bits in the source
        /// </summary>
        /// <param name="src">The bit source</param>
        public static ulong pop(Span<ulong> src)
        {
            var count = U64Zero;
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
            var count = U64Zero;
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
            var count = U64Zero;
            for(var i=0; i<src.Length; i++)
                count += Popcnt.PopCount(src[i]);
            return count;
        }
    }
}