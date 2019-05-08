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
    using System.Runtime.InteropServices;    
    using System.Diagnostics;
    
    
    using static mfunc;
    using static Span128;

    public static class Span128
    {

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> blockalloc<T>(int blocks)
            where T : struct, IEquatable<T>        
                =>Span128<T>.BlockAlloc(blocks);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(Span<T> src)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(Span<T> src, int offset, int length)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src, offset,length);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(ReadOnlySpan<T> src, int offset, int length)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src, offset,length);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(T[] src)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(T[] src, int offset, int length)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src,offset, length);

        [MethodImpl(Inline)]
        public static Span128<T> single<T>(params T[] src)
            where T : struct, IEquatable<T>
                => Span128<T>.Load(src);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : struct, IEquatable<T>        
                => Span128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : struct, IEquatable<T>        
                => Span128<T>.BlockSize;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklength<T>(int blocks = 1)
            where T : struct, IEquatable<T>        
                => blocks * Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<T>(int length)
            where T : struct, IEquatable<T>  
                => length / blocklength<T>();

        /// <summary>
        /// Calculates the number of bytes represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int bytes<T>(in Span<T> src)
            where T : struct, IEquatable<T>        
            => src.Length * cellsize<T>();

        /// <summary>
        /// Calculates the number of blocks represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The span constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<T>(in Span<T> src)
            where T : struct, IEquatable<T>  
                =>  blockcount<T>(src.Length);

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int length)
            where T : struct, IEquatable<T>        
            => Span128<T>.Aligned(length);


        [MethodImpl(Inline)]
        public static int align<T>(int length)
            where T : struct, IEquatable<T>        
        {
            var remainder = length % blocklength<T>();
            if(remainder == 0)
                return length;
            else
                return (length - remainder) + blocklength<T>();
        }                    
    }
}