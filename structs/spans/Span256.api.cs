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
        /// Allocates a span to hold a specified number of blocks
        /// </summary>
        /// <param name="blocks">The number of blocks for which memory should be alocated</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> AllocBlocks<T>(int blocks, T? fill = null)
            where T : struct        
                => Span256<T>.AllocBlocs(blocks, fill);

        /// <summary>
        /// Allocates a 256-bit blocked span of a specified minimum length which may not
        /// partition evently into 256-bit blocks
        /// </summary>
        /// <param name="minlen">The minimum allocation length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> AllocUnaligned<T>(int minlen, T? fill = null)
            where T : struct        
        {
            Span256.Alignment<T>(minlen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return AllocBlocks<T>(fullBlocks, fill);
            else
                return Span256.AllocBlocks<T>(fullBlocks + 1, fill);
        }
        
        /// <summary>
        /// Allocates the minimum amount of memory required to align data of natural length in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> AllocUnaligned<N,T>(T? fill = null)
            where N : ITypeNat, new()
            where T : struct
        {
            var dataLen = nati<N>();
            Span256.Alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return AllocBlocks<T>(fullBlocks);
            else
                return AllocBlocks<T>(fullBlocks + 1);
        }

        /// <summary>
        /// Allocates the minimum amount of memory required to align matrix/tabular data in 256-bit blocks
        /// </summary>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> AllocUnaligned<M,N,T>(T? fill = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var dataLen = nati<M>() * nati<N>();
            Span256.Alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return AllocBlocks<T>(fullBlocks,fill);
            else
                return AllocBlocks<T>(fullBlocks + 1,fill);
        }

        /// <summary>
        /// Loads a blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> LoadAligned<T>(Span<T> src, int offset = 0)
            where T : struct
                => Span256<T>.LoadAligned(src, offset);
                
        /// <summary>
        /// Loads an unsized 256-bit blocked span from a sized unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> LoadAligned<N,T>(Span<N,T> src, int offset = 0)
            where T : struct
            where N : ITypeNat,new()
                => Span256<T>.LoadAligned(src, offset);

        /// <summary>
        /// Loads a 256-bit blocked span from a memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="length">The (256-bit aligned) length of the span </param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> LoadAligned<T>(ref T src, int length)
            where T : struct
                => Span256<T>.LoadAligned(ref src, length);

        /// <summary>
        /// Loads (potentially) unaligned data
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> LoadUnaligned<T>(Span<T> src)
            where T : struct
        {
            var bz = BlockCount<T>(src.Length, out int remainder);
            if(remainder == 0)
                return LoadAligned(src);
            else
            {
                var dst = AllocBlocks<T>(bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> LoadUnaligned<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var bz = BlockCount<T>(src.Length, out int remainder);
            if(remainder == 0)
                return LoadAligned(src);
            else
            {
                var dst = AllocBlocks<T>(bz + 1);
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
        public static Span256<T> LoadAligned<T>(T[] src, int offset = 0)
            where T : struct
                => Span256<T>.LoadAligned(src, offset);
                
        /// <summary>
        /// Loads a blocked readonly span from an unblocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> LoadAligned<T>(ReadOnlySpan<T> src, int offset = 0)
            where T : struct
                => Span256<T>.LoadAligned(src ,offset);

        /// <summary>
        /// Computes the minimum number of blocks that can hold data of a specified byte length
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int MinBlocks<T>(ByteSize srclen)
            where T : struct        
        {
            var bz = BlockCount<T>(srclen, out int remainder);
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
        public static int MinBlocks<M,N,T>()
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct        
        {
            var srclen = nati<M>() * nati<N>();
            var bz = BlockCount<T>(srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize CellSize<T>()
            where T : struct        
                => Span256<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static ByteSize BlockSize<T>()
            where T : struct        
                => Span256<T>.BlockSize;

        /// <summary>
        /// Calculates the number of cells that comprise a specified number of block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int BlockLength<T>(int blocks = 1)
            where T : struct        
                => blocks * Span256<T>.BlockLength;

        /// <summary>
        /// Calculates the number of whole blocks into which a sequence of cells may be partitioned
        /// </summary>
        /// <param name="length">The length of the cell sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int WholeBlockCount<T>(int length)
            where T : struct  
                => length / BlockLength<T>();

        /// <summary>
        /// Calculates the number of blocks represented by the span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The span constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int WholeBlockCount<T>(ReadOnlySpan<T> src)
            where T : struct  
                =>  WholeBlockCount<T>(src.Length);

        [MethodImpl(Inline)]
        public static int BlockCount<T>(int length, out int remainder)
            where T : struct          
            => Math.DivRem(length, BlockLength<T>(), out remainder);
        
        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsAligned<T>(int length)
            where T : struct        
            => Span256<T>.Aligned(length);
        
        /// <summary>
        /// Determines whether an unblocked span is block-aligned
        /// </summary>
        /// <param name="src">The span to examine</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsAligned<T>(ReadOnlySpan<T> src)
            where T : struct        
                => IsAligned<T>(src.Length);

        /// <summary>
        /// Calculates alignment attributes predicated on a source length and element type
        /// </summary>
        /// <param name="srcLen">The source length</param>
        /// <param name="blocklen">The number of cells in a block</param>
        /// <param name="fullBlocks">The number of whole blocks into which the source length can be partitioned</param>
        /// <param name="remainder">The number of cells that cannot fit into a sequence of full blocks</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Alignment<T>(int srcLen, out int blocklen, out int fullBlocks, out int remainder)
            where T : struct        
        {
            blocklen = BlockLength<T>();
            fullBlocks = srcLen / blocklen;
            remainder = srcLen % BlockLength<T>();
        } 

        /// <summary>
        /// Loads a single blocked span from a parameter array
        /// </summary>
        /// <param name="src">The source parameters</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Single<T>(params T[] src)
            where T : struct
                => Span256<T>.Load(src);

   }
}