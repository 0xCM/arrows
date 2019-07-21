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
    /// Identifies a bit position within a span of memory via container and relative offsets
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public readonly struct BitPos
    {
        /// <summary>
        /// The container-relative 0-based offset of the segment
        /// </summary>
        [FieldOffset(0)]
        public readonly ushort SegIdx;

        /// <summary>
        /// The segment-relative offset of the bit
        /// </summary>
        [FieldOffset(2)]
        public readonly byte BitOffset;

        public static implicit operator BitPos((ushort SegIdx, byte BitOffset) pos)
            => Define(pos.SegIdx, pos.BitOffset);

        public static implicit operator (ushort Segment, byte BitOffset)(BitPos pos)
            => (pos.SegIdx, pos.BitOffset);

        [MethodImpl(Inline)]
        public static BitPos Define(ushort SegIdx, byte BitOffset)
            => new BitPos(SegIdx, BitOffset);

        [MethodImpl(Inline)]
        public static BitPos Define((int SegIdx, int BitOffset) src)
             => new BitPos((ushort)src.SegIdx, (byte)src.BitOffset);

        [MethodImpl(Inline)]
        public BitPos(ushort SegIdx, byte BitOffset)
        {
            this.SegIdx = SegIdx;
            this.BitOffset = BitOffset;
        }   

        public string Format()
            => $"[{SegIdx}:{BitOffset}]";


        public override string ToString()
            => Format();

        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
    }
}