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

    public class BitMap
    {
        public static BitMap<T> FromCells<T>(int cells)
            where T : unmanaged
        {
            var cellwidth = BitIndex<T>.CellWidth;
            var bits = cells * cellwidth;
            var indices = new BitIndex<T>[bits];
            for(var cell=0u; cell< cells; cell++)
            for(byte bit = 0; bit < bits; bit++)
                indices[cell*cellwidth + bit] = new BitIndex<T>(cell, bit);
            return new BitMap<T>(bits,indices);

        }

        public static BitMap<T> FromBits<T>(BitSize bitcount)
            where T : unmanaged
        {
            var cellwidth = BitIndex<T>.CellWidth;
            var q = Math.DivRem(bitcount,cellwidth, out int r);
            var cells = r == 0 ? q : q + 1;
            var indices = new BitIndex<T>[bitcount];
            for(var cell=0u; cell< cells; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex<T>(cell, bit);
            return new BitMap<T>(bitcount,indices);
        }

        public static BitMap FromBits(BitSize cellwidth, BitSize bitcount)
        {
            var q = Math.DivRem(bitcount,cellwidth, out int r);
            var cells = r == 0 ? q : q + 1;
            var indices = new BitIndex[cells*cellwidth];
            for(var cell=0u; cell< cells; cell++)
            for(byte bit = 0; bit < cellwidth; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return new BitMap(bitcount,indices);        
        }

        public static BitMap FromCells(BitSize cellwidth, int cells)
        {
            var bitcount = cells * cellwidth;
            var indices = new BitIndex[bitcount];
            for(var cell=0u; cell< cells; cell++)
            for(byte bit = 0; bit < bitcount; bit++)
                indices[cell*cellwidth + bit] = new BitIndex(cell, bit);
            return new BitMap(bitcount,indices);
        }

        
        [MethodImpl(Inline)]
        BitMap(BitSize bitcount, BitIndex[] indices)
        {
            this.BitCount = bitcount;
            this.Indices = indices;
        }

        Memory<BitIndex> Indices;

        public BitSize BitCount {get;}         

        public BitIndex this[int pos]
        {
            [MethodImpl(Inline)]
            get => Index(pos);
        }

        [MethodImpl(Inline)]
        public BitIndex Index(int pos)
            => Indices.Span[pos];


        [MethodImpl(Inline)]
        public uint Cell(int bitpos)
            => Index(bitpos).CellIndex;

        [MethodImpl(Inline)]
        public uint Offset(int bitpos)
            => Index(bitpos).CellOffset;

    }

    public class BitMap<T>
        where T : unmanaged
    {
    
        [MethodImpl(Inline)]
        public BitMap(BitSize bitcount, BitIndex<T>[] indices)
        {
            this.BitCount = bitcount;
            this.Indices = indices;        
        }

        Memory<BitIndex<T>> Indices;

        public BitSize BitCount {get;}

        public BitIndex<T> this[int pos]
        {
            [MethodImpl(Inline)]
            get => Index(pos);
        }

        [MethodImpl(Inline)]
        public BitIndex<T> Index(int pos)
            => Indices.Span[pos];

        [MethodImpl(Inline)]
        public uint Cell(int bitpos)
            => Index(bitpos).CellIndex;

        [MethodImpl(Inline)]
        public uint Offset(int bitpos)
            => Index(bitpos).CellOffset;

        
    }


}