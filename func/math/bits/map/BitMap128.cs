//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a 128-bit bitmap over cells of unmanaged parameteric type
    /// </summary>
    public readonly struct BitMap128<T> : IBitMap<T>
        where T : unmanaged
    {
        readonly BitMap Data;        

        public static readonly BitMap128<T> TheOnly = Create();

        [MethodImpl(Inline)]
        public static implicit operator BitMap<T>(BitMap128<T> src)
            => new BitMap<T>(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator BitMap(BitMap128<T> src)
            => src.Data;

        [MethodImpl(Inline)]
        BitMap128(BitMap src)
        {
            this.Data = src;
        }
        
        public ref readonly BitIndex this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => ref Data.Index(pos);
        }

        public BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => Data.BitCount;
        }

        /// <summary>
        /// The size of a storage cell in bits
        /// </summary>
        public BitSize CellWidth 
            => Data.CellWidth;
        
        /// <summary>
        /// The number of cells in the maping range
        /// </summary>
        public int CellCount 
        {
            [MethodImpl(Inline)]
            get => Data.CellCount;        
        }

        [MethodImpl(Inline)]
        public ref readonly BitIndex Index(BitPos pos)
            => ref Data.Index(pos);

        [MethodImpl(Inline)]
        public ref readonly uint Cell(BitPos pos)
            => ref Data.Cell(pos);

        [MethodImpl(Inline)]
        public ref readonly byte Offset(BitPos pos)
            => ref Data.Offset(pos);

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        /// <summary>
        /// Creates the mapping specialized for the parameteric closure
        /// </summary>
        static BitMap128<T> Create()        
        {
            const int bitcount = 128;
            var cellwidth = bitsize<T>();
            var cellcount = Vec128<T>.Length;
            var indices = new BitIndex[bitcount];
            for(var cell = 0u; cell < cellcount; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);            
            return new BitMap128<T>(BitMap.FromIndices(cellcount, cellwidth, indices));
        } 
    }
}