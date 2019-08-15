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
        public static Span128<T> FromParts<T>(params T[] src)
            where T : struct
                => Span128<T>.Load(src);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> AllocBlocks<T>(int blocks)
            where T : struct        
                => Span128<T>.AllocBlocks(blocks);


        /// <summary>
        /// Loads a blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Load<T>(Span<T> src, int offset = 0)
            where T : struct
                => Span128<T>.Load(src, offset);

        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => Span128<T>.Load(src, offset);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int CellSize<T>()
            where T : struct        
                => Span128<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int BlockSize<T>()
            where T : struct        
                => Span128<T>.BlockSize;

        /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Head<T>(in Span128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T Head<T>(in ReadOnlySpan128<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);


        [MethodImpl(Inline)]
        public static ref T Offset<T>(in Span128<T> src, int index)
            where T : struct
        {
            ref var first = ref Head(in src);
            return ref Unsafe.Add(ref first, index);
        }

        [MethodImpl(Inline)]
        public static ref T BlockedOffset<T>(in Span128<T> src, int blocks)
            where T : struct
        {
            ref var first = ref Head(in src);
            var index = blocks * Span128<T>.BlockLength;
            return ref Unsafe.Add(ref first, index);
        }

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int BlockLength<T>(int blocks = 1)
            where T : struct        
                => blocks * Span128<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int WholeBlocks<T>(int length)
            where T : struct  
                => length / BlockLength<T>();

        /// <summary>
        /// Calculates the number of bytes consumed by a specified number of cells
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize CellBytes<T>(int count)
            where T : struct        
            => count * CellSize<T>();

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by 128-bit
        /// primal blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsAligned<T>(int length)
            where T : struct        
                => Span128<T>.Aligned(length);


        [MethodImpl(Inline)]
        public static int Align<T>(int length)
            where T : struct        
        {
            var remainder = length % BlockLength<T>();
            if(remainder == 0)
                return length;
            else
                return (length - remainder) + BlockLength<T>();
        }                    


        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int Blocks<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                where S : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int Blocks<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                where S : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file,line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int Length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs, [CallerFilePath] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)        
            where T : struct
            where S : struct
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw CountMismatch(lhs.Length, rhs.Length, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int Length<S,T>(Span128<S> lhs, Span128<T> rhs, [CallerFilePath] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : struct
                where T : struct
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw CountMismatch(lhs.Length, rhs.Length, caller, file, line);
   
    }
}