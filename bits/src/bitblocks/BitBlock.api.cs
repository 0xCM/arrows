//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public static class BitBlock
    {
        /// <summary>
        /// Presents a non-generic block as a generic block
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The source block type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitBlock<T> AsGeneric<T>(ref T src)
            where T : unmanaged, IBitBlock
                => ref Unsafe.As<T, BitBlock<T>>(ref src);
        
        /// <summary>
        /// Loads a bitblock from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The block type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> FromSpan<T>(Span<byte> src)
            where T : unmanaged, IBitBlock
                => BitBlock<T>.FromSpan(src.Slice(0, Unsafe.SizeOf<T>()));

        /// <summary>
        /// Loads a bitblock from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The block type</typeparam>
        [MethodImpl(Inline)]
        public static ref T FromSpan<T>(Span<byte> src, out T dst)
            where T : unmanaged, IBitBlock
        {
            dst = FromSpan<T>(src).Data;
            return ref dst;
        }

        /// <summary>
        /// Allocates a bitblock
        /// </summary>
        /// <typeparam name="T">The block type</typeparam>
        [MethodImpl(Inline)]
        public static BitBlock<T> Alloc<T>()
            where T : unmanaged, IBitBlock
                => BitBlock<T>.Alloc();

        /// <summary>
        /// Presents the bitblock as a bytespan
        /// </summary>
        /// <param name="src">The source block</param>
        /// <typeparam name="T">The block type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsSpan<T>(ref T src)
            where T : unmanaged, IBitBlock
                => BitView.ViewBits(ref src).Bytes;        

        [MethodImpl(Inline)]        
        public static void CopyTo<T>(ref T src, Span<byte> dst)        
            where T : unmanaged, IBitBlock
                => BitView.ViewBits(ref src).CopyTo(dst);            

    }


    public interface IBitBlock
    {
        
        /// <summary>
        /// Gets the value of an index-identified bit
        /// </summary>
        /// <param name="i">The 0-based index in the interval [0,Length - 1]</param>
        byte GetPart(int i);

        /// <summary>
        /// Sets the value of an index-identified bit
        /// </summary>
        /// <param name="i">The 0-based index in the interval [0,Length - 1]</param>
        /// <param name="value">A value of either 0 or 1</param>
        void SetPart(int i, byte value);

        /// <summary>
        /// Indexer that is functionally equivalent to the get/set part operations
        /// </summary>
        byte this [int i] {get; set;}

    }

    public interface IBitBlock<T> : IBitBlock
        where T : unmanaged, IBitBlock
    {
        /// <summary>
        /// The number of represented bits
        /// </summary>
        int Length {get;}


        /// <summary>
        /// Copies block data to a target span
        /// </summary>
        /// <param name="dst">The target span</param>
        void CopyTo(Span<byte> dst);
        
        /// <summary>
        /// Presents the block as a span of bytes
        /// </summary>
        Span<byte> AsSpan();
                
    }

}