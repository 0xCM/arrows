//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

	public readonly struct BitIndex
	{
        [MethodImpl(Inline)]
        public static implicit operator (uint cell, byte offset)(BitIndex src)
            => (src.CellIndex, src.CellOffset);

        [MethodImpl(Inline)]
        public static implicit operator BitIndex((uint cell, byte offset) src)
            => new BitIndex(src.cell, src.offset);

        [MethodImpl(Inline)]
        public BitIndex(uint CellIndex, byte CellOffset)
        {
            this.CellIndex = CellIndex;
            this.CellOffset = CellOffset;
        }

		/// <summary>
		/// The container-relative 0-based offset of the cell in which the bit resides
		/// </summary>
		public readonly uint CellIndex;

		/// <summary>
		/// The cell-relative location of the bit
		/// </summary>
		public readonly byte CellOffset;

        public string Format()
            => $"[{CellIndex}:{CellOffset}]";

        public override string ToString()
            => Format();

	}

    public readonly struct BitIndex<T>
        where T : unmanaged
    {
        /// <summary>
        /// The number of bits that comprise a cell
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public static readonly byte CellWidth = (byte)(Unsafe.SizeOf<T>()*8);        

        [MethodImpl(Inline)]
        public static implicit operator (uint cell, byte offset)(BitIndex<T> src)
            => (src.CellIndex, src.CellOffset);

        [MethodImpl(Inline)]
        public static implicit operator BitIndex<T>((uint cell, byte offset) src)
            => new BitIndex<T>(src.cell, src.offset);

        
        [MethodImpl(Inline)]
        public static implicit operator BitIndex(BitIndex<T> src)
            => new BitIndex(src.CellIndex, src.CellOffset);

        [MethodImpl(Inline)]
        public BitIndex(uint CellIndex, byte CellOffset)
        {
            this.CellIndex = CellIndex;
            this.CellOffset = CellOffset;
        }

		/// <summary>
		/// The container-relative 0-based offset of the cell in which the bit resides
		/// </summary>
		public readonly uint CellIndex;

		/// <summary>
		/// The cell-relative location of the bit
		/// </summary>
		public readonly byte CellOffset;

        public readonly byte CellCapacity
        {
            [MethodImpl(Inline)]
            get => CellWidth;
        }

        public string Format()
            => $"[{CellIndex}:{CellOffset}]";

        public override string ToString()
            => Format();

    }
}