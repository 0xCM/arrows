//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    partial class BitsX
    {        
        /// <summary>
        /// Allocates a target span that receives a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        static Span<byte> range<T>(in T src, BitIndex i0, BitIndex i1)
            where T : struct
        {
            var dst = Alloc(i0,i1);
            gbits.range(in src, i0, i1, dst, 0);
            return dst;
        }

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this byte src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this sbyte src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this ushort src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this short src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this int src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this uint src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this long src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Allocates and returns a target span populated with a contiguous range of bits from source 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits(this ulong src, BitIndex i0, BitIndex i1)
            => range(in src, i0, i1);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this byte src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this sbyte src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this ushort src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this short src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this int src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this uint src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this long src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        /// <summary>
        /// Copies a contiguous range of bits from source into the target span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static void ReadBits(this ulong src, BitIndex i0, BitIndex i1, Span<byte> dst, int offset = 0)
            => gbits.range(in src, i0, i1, dst, offset);

        [MethodImpl(Inline)]
        static ByteSize ByteCount(BitIndex i0, BitIndex i1)
            => ((uint)((i1 - i0) + 1)).ByteCount();

        [MethodImpl(Inline)]
        static Span<byte> Alloc(BitIndex i0, BitIndex i1)        
            => new byte[ByteCount(i0,i1)];        

        [MethodImpl(Inline)]
        static ByteSize ByteCount(this uint bitcount)
            => (uint)(Mod<N8>.div(bitcount) + (Mod<N8>.mod(bitcount) == 0 ? 0 : 1));
    }

}