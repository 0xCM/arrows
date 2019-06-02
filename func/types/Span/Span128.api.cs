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
        
    using static zfunc;    
    using static Span128;

    public static class Span128
    {
        /// <summary>
        /// Loads a single blocked span from a parameter array
        /// </summary>
        /// <param name="src">The source parameters</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> single<T>(params T[] src)
            where T : struct
                => Span128<T>.Load(src);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(int blocks)
            where T : struct        
                => Span128<T>.Alloc(blocks);

        /// <summary>
        /// Allocates a blocked span of lenth N iff supplied left and right spans are
        /// of common length N
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> alloc<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            where T : struct
                => alloc<T>(length(lhs,rhs));

        /// <summary>
        /// Loads a blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> load<T>(Span<T> src, int offset = 0)
            where T : struct
                => Span128<T>.Load(src, offset);

        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => Span128<T>.Load(src, offset);

        [MethodImpl(Inline)]
        public static Span128<T> load<T>(T[] src, int offset = 0)
            where T : struct
                => Span128<T>.Load(src, offset);


        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : struct        
                => Span128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : struct        
                => Span128<T>.BlockSize;

        /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(in Span128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(in ReadOnlySpan128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);


        [MethodImpl(Inline)]
        public static ref T offset<T>(in Span128<T> src, int index)
            where T : struct
        {
            ref var first = ref head(in src);
            return ref Unsafe.Add(ref first, index);
        }

        [MethodImpl(Inline)]
        public static ref T blockedOffset<T>(in Span128<T> src, int blocks)
            where T : struct
        {
            ref var first = ref head(in src);
            var index = blocks * Span128<T>.BlockLength;
            return ref Unsafe.Add(ref first, index);
        }

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklength<T>(int blocks = 1)
            where T : struct        
                => blocks * Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocks<T>(int length)
            where T : struct  
                => length / blocklength<T>();

        /// <summary>
        /// Calculates the number of blocks represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The span constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocks<T>(in ReadOnlySpan<T> src)
            where T : struct  
                =>  blocks<T>(src.Length);

        /// <summary>
        /// Calculates the number of bytes represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize bytes<T>(in ReadOnlySpan<T> src)
            where T : struct        
            => src.Length * cellsize<T>();

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int length)
            where T : struct        
                => Span128<T>.Aligned(length);

        /// <summary>
        /// Determines whether an unblocked span is block-aligned
        /// </summary>
        /// <param name="src">The span to examine</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(ReadOnlySpan<T> src)
            where T : struct        
                => aligned<T>(src.Length);

        [MethodImpl(Inline)]
        public static int align<T>(int length)
            where T : struct        
        {
            var remainder = length % blocklength<T>();
            if(remainder == 0)
                return length;
            else
                return (length - remainder) + blocklength<T>();
        }                    
    
        /// <summary>
        /// Returns the common number of 128-bit blocks in the supplied spans, if possible. Otherwise,
        /// raises an exception
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<T>(Span128<T> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw Errors.CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

        /// <summary>
        /// Returns the /// length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
            where T : struct
            where S : struct
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : struct
                where T : struct
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
   
    }
}