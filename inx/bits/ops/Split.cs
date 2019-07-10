//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {                
        
        /// <summary>
        /// Partitions a 16-bit signed integer into into two signed 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">The lower 8 bits of the source</param>
        /// <param name="x1">The higher 8 bits for the source</param>
        [MethodImpl(Inline)]
        public static (sbyte x0, sbyte x1) split(short src, N2 parts = default)
          => (lo(src), hi(src));

        /// <summary>
        /// Partitions a 16-bit unsigned integer into into two unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">The lower 8 bits of the source</param>
        /// <param name="x1">The higher 8 bits for the source</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1) split(ushort src, N2 parts = default)
          => (lo(src), hi(src));

        /// <summary>
        /// Partitions a 32-bit signed integer into into two signed 16-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static (short x0, short x1) split(int src, N2 parts = default)
          => (lo(src), hi(src));

        /// <summary>
        /// Partitions a 32-bit unsigned integer into two unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-15 of the source value</param>
        /// <param name="x1">Taken from bits 16-31 of the source value</param>
        [MethodImpl(Inline)]
        public static (ushort x0, ushort x1) split(uint src, N2 parts = default)
          => ((ushort)(src >> 0 * 16), 
              (ushort)(src >> 1 * 16));

        /// <summary>
        /// Partitions a 64-bit signed integer into two signed 32-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-31 of the source value</param>
        /// <param name="x1">Taken from bits 32-63 of the source value</param>
        [MethodImpl(Inline)]
        public static (int x0, int x1) split(long src, N2 parts = default)
          => (lo(src), hi(src));

        /// <summary>
        /// Partitions a 64-bit unsigned integer into two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-31 of the source value</param>
        /// <param name="x1">Taken from bits 32-63 of the source value</param>
        [MethodImpl(Inline)]
        public static (uint x0, uint x1) split(ulong src, N2 parts = default)
            => ((uint)src, (uint)(src >> 32));

        /// <summary>
        /// Partitions a 32-bit unsigned integer int four unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-7 of the source value</param>
        /// <param name="x1">Taken from bits 8-15 of the source value</param>
        /// <param name="x2">Taken from bits 16-23 of the source value</param>
        /// <param name="x3">Taken from bits 24-31 of the source value</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1, byte x2, byte x3) split(uint src, N4 parts)
          => (
              (byte)(src >> 0*8), 
              (byte)(src >> 1*8), 
              (byte)(src >> 2*8), 
              (byte)(src >> 3*8)
              );

        /// <summary>
        /// Partitions a 64-bit unsigned integer int eight unsigned 8-bit integers
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="x0">Taken from bits 0-7 of the source value</param>
        /// <param name="x1">Taken from bits 8-15 of the source value</param>
        /// <param name="x2">Taken from bits 16-23 of the source value</param>
        /// <param name="x3">Taken from bits 24-31 of the source value</param>
        /// <param name="x4">Taken from bits 32-39 of the source value</param>
        /// <param name="x5">Taken from bits 40-47 of the source value</param>
        /// <param name="x6">Taken from bits 48-57 of the source value</param>
        /// <param name="x7">Take from bits 58-63 of the source value</param>
        [MethodImpl(Inline)]
        public static (byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7) split(ulong src, N8 parts)
            => (
            (byte)(src >> 0*8),
            (byte)(src >> 1*8),
            (byte)(src >> 2*8),
            (byte)(src >> 3*8),
            (byte)(src >> 4*8),
            (byte)(src >> 5*8),
            (byte)(src >> 6*8),
            (byte)(src >> 7*8)
            );


    }

}