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
    using static Span256;
    using static nfunc;

    public static class Span256
    {
        /// <summary>
        /// Loads a single blocked span from a parameter array
        /// </summary>
        /// <param name="src">The source parameters</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> single<T>(params T[] src)
            where T : struct
                => Span256<T>.Load(src);

        /// <summary>
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(int blocks)
            where T : struct        
                => Span256<T>.Alloc(blocks);

        /// <summary>
        /// Allocates the minimum amount of memory required to align matrix/tabular data in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<M,N,T>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var dataLen = nati<M>() * nati<N>();
            Span256.alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return alloc<T>(fullBlocks);
            else
                return Span256.alloc<T>(fullBlocks + 1);
        }

        /// <summary>
        /// Computes the minimum number of blocks that can hold data of a specified byte length
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int minblocks<T>(ByteSize srclen)
            where T : struct        
        {
            var bz = blocks<T>(srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Computes the minimum number of 256-bit blocks that can hold a table of data
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int minblocks<M,N,T>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct        
        {
            var srclen = nati<M>() * nati<N>();
            var bz = blocks<T>(srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Allocates a blocked span of lenth N iff supplied left and right spans are
        /// of common length N
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> alloc<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                => Span256<T>.Alloc(blocks(lhs,rhs));

        /// <summary>
        /// Loads a blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(Span<T> src, int offset = 0)
            where T : struct
                => Span256<T>.Load(src, offset);

        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> loadu<T>(Span<T> src)
            where T : struct
        {
            var bz = blocks<T>(src.Length, out int remainder);
            if(remainder == 0)
                return load(src);
            else
            {
                var dst = alloc<T>(bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads a blocked span from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(T[] src, int offset = 0)
            where T : struct
                => Span256<T>.Load(src, offset);
                
        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> load<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => Span256<T>.Load(src ,offset);

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : struct        
                => Span256<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : struct        
                => Span256<T>.BlockSize;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocklength<T>(int blocks = 1)
            where T : struct        
                => blocks * Span256<T>.BlockLength;

        /// <summary>
        /// Calculates the number of blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int blocks<T>(int length)
            where T : struct  
                => length / blocklength<T>();
        
        [MethodImpl(Inline)]
        public static int blocks<T>(int length, out int remainder)
            where T : struct  
        {
            return Math.DivRem(length, blocklength<T>(), out remainder);
        }

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
        /// Calculates the number of blocks represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The span constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocks<T>(in ReadOnlySpan<T> src)
            where T : struct  
                =>  blocks<T>(src.Length);

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int length)
            where T : struct        
            => Span256<T>.Aligned(length);
        
        /// <summary>
        /// Determines whether an unblocked span is block-aligned
        /// </summary>
        /// <param name="src">The span to examine</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(ReadOnlySpan<T> src)
            where T : struct        
                => aligned<T>(src.Length);

        /// <summary>
        /// Returns a reference to the first element of a span
        /// </summary>
        /// <param name="src">The span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(in Span256<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        /// <summary>
        /// Returns a readonly reference to the first element of a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T head<T>(in ReadOnlySpan256<T> src)
            where T : struct
                =>  ref MemoryMarshal.GetReference<T>(src);

        [MethodImpl(Inline)]
        public static ref T offset<T>(in Span256<T> src, int index)
            where T : struct
        {
            ref var first = ref head(in src);
            return ref Unsafe.Add(ref first, index);
        }

        [MethodImpl(Inline)]
        public static ref T blockedOffset<T>(in Span256<T> src, int blocks)
            where T : struct
        {
            ref var first = ref head(in src);
            var index = blocks * Span256<T>.BlockLength;
            return ref Unsafe.Add(ref first, index);
        }
 
        [MethodImpl(Inline)]
        public static void alignment<T>(int srcLen, out int blocklen, out int fullBlocks, out int remainder)
            where T : struct        
        {
            blocklen = blocklength<T>();
            fullBlocks = srcLen / blocklen;
            remainder = srcLen % blocklength<T>();
        } 


        /// <summary>
        /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
        /// raises an exception
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,  
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : struct
                where T : struct                
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

        /// <summary>
        /// Returns the common number of 256-bit blocks in the supplied spans, if possible. Otherwise,
        /// raises an exception
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blocks<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs, [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where S : struct
                where T : struct
                    => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount 
                        : throw CountMismatch(lhs.BlockCount, rhs.BlockCount, caller, file, line);

        /// <summary>
        /// Returns the length of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]   
        public static int length<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                where T : struct
                where S : struct
                    => lhs.Length == rhs.Length ? lhs.Length 
                        : throw CountMismatch(lhs.Length, rhs.Length, caller, file, line);
   }
}