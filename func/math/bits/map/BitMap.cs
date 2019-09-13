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

    public readonly struct BitMap : IBitMap
    {
        [MethodImpl(Inline)]
        public static BitMap FromIndices(int cellcount, BitSize cellwidth, params BitIndex[] indices)
            => new BitMap(cellcount,cellwidth, indices);

        /// <summary>
        /// Creates a bitmap over a specified number of cells of unmanaged type
        /// </summary>
        /// <param name="cellcount">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static BitMap<T> FromCells<T>(int cellcount)
            where T : unmanaged
        {
            var cellwidth = bitsize<T>();
            var bits = cellcount * cellwidth;
            var indices = new BitIndex[bits];
            for(var cell=0u; cell< cellcount; cell++)
            for(byte bit = 0; bit < bits; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);

            return new BitMap<T>(FromIndices(cellcount, cellwidth, indices));
        }
    
        /// <summary>
        /// Creates a bitmap over cells of unmanaged parametric type
        /// </summary>
        /// <param name="bitcount">The number of bits to spread over the cells</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static BitMap<T> FromBits<T>(BitSize bitcount)
            where T : unmanaged
        {
            var cellwidth = bitsize<T>();
            var q = Math.DivRem(bitcount,cellwidth, out int r);
            var cellcount = r == 0 ? q : q + 1;
            var indices = new BitIndex[bitcount];
            for(var cell=0u; cell< cellcount; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return new BitMap<T>(FromIndices(cellcount, cellwidth, indices));
        }

        public static BitMap FromBits(BitSize cellwidth, BitSize bitcount)
        {
            var q = Math.DivRem(bitcount,cellwidth, out int r);
            var cellcount = r == 0 ? q : q + 1;
            var indices = new BitIndex[cellcount*cellwidth];
            for(var cell=0u; cell< cellcount; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return new BitMap(cellcount, cellwidth, indices);        
        }

        public static BitMap FromCells(BitSize cellwidth, int cellcount)
        {
            var bitcount = cellcount * cellwidth;
            var indices = new BitIndex[bitcount];
            for(var cell=0u; cell< cellcount; cell++)
            for(byte bit = 0; bit < bitcount; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return FromIndices(cellcount,cellwidth, indices);
        }

        /// <summary>
        /// Creates a 128-bit bitmap over cells of unmanaged type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public static ref readonly BitMap128<T> Map128<T>()        
            where T : unmanaged
                => ref BitMap128<T>.TheOnly;

        /// <summary>
        /// Creates a 256-bit bitmap over cells of unmanaged type
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public static ref readonly BitMap256<T> Map256<T>()        
            where T : unmanaged
                => ref BitMap256<T>.TheOnly;

        
        [MethodImpl(Inline)]
        BitMap(int cellcount, BitSize cellwidth, BitIndex[] indices)
        {
            this.CellCount = cellcount;
            this.CellWidth = cellwidth;
            this.Indices = indices;
        }

        /// <summary>
        /// The size of a storage cell in bits
        /// </summary>
        public BitSize CellWidth {get;}

        /// <summary>
        /// The number of cells in the map codomain
        /// </summary>
        public int CellCount {get;}

        readonly MemorySpan<BitIndex> Indices;

        /// <summary>
        /// The total number of bits over which the map is defined
        /// </summary>
        public BitSize BitCount 
            => Indices.Length;

        [MethodImpl(Inline)]
        public ref readonly BitIndex Index(BitPos pos)
            => ref Indices[pos];

        [MethodImpl(Inline)]
        public ref readonly uint Cell(BitPos pos)
            => ref Index(pos).CellIndex;

        [MethodImpl(Inline)]
        public ref readonly byte Offset(BitPos pos)
            => ref Index(pos).CellOffset;

        public ref readonly BitIndex this[BitPos pos]
        {
            [MethodImpl(Inline)]
            get => ref Index(pos);
        }

        public string Format()
        {
            var fmt = sbuild();
            for(var i=0; i< Indices.Length; i++)          
            {  
                var index = Indices[i];
                fmt.AppendLine($"{i} -> {index.Format()}");
            }
            return fmt.ToString();
        }
    }
}