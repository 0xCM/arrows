//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Defines a storage-relative bit position
    /// </summary>
	public readonly struct BitIndex
	{
		/// <summary>
        /// The 0-based position of the cell relative to its container
		/// </summary>
		public readonly uint CellIndex;

		/// <summary>
		/// The 0-based position of the bit relative to the cell
		/// </summary>
		public readonly byte CellOffset;

        [MethodImpl(Inline)]
        public static implicit operator (uint cell, byte offset)(BitIndex src)
            => (src.CellIndex, src.CellOffset);

        [MethodImpl(Inline)]
        public static implicit operator BitIndex((uint cell, byte offset) src)
            => new BitIndex(src.cell, src.offset);

        [MethodImpl(Inline)]
        public BitIndex(uint index, byte offset)
        {
            this.CellIndex = index;
            this.CellOffset = offset;
        }

        public string Format()
            => $"[{CellIndex}:{CellOffset}]";

        public override string ToString()
            => Format();
	}

}