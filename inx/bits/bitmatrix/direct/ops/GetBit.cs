//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrixX
    {    

        [MethodImpl(Inline)]
        static Bit Get(this Span<byte> src, int row, int col)
            => Bits.test(in src[row], col);

        [MethodImpl(Inline)]
        static Bit Get(this Span<ushort> src, int row, int col)
            => Bits.test(in src[row], col);

        [MethodImpl(Inline)]
        static Bit Get(this Span<uint> src, int row, int col)
            => Bits.test(in src[row], col);

        [MethodImpl(Inline)]
        static Bit Get(this Span<ulong> src, int row, int col)
            => Bits.test(in src[row], col);

        [MethodImpl(Inline)]
        public static Bit GetBit(this in BitMatrix4 src, int row, int col)
            => src.bits.Get(row,col);

        [MethodImpl(Inline)]
        public static Bit GetBit(this in BitMatrix8 src, int row, int col)
            => src.bits.Get(row,col);

        [MethodImpl(Inline)]
        public static Bit GetBit(this in BitMatrix16 src, int row, int col)
            => src.bits.Get(row,col);

        [MethodImpl(Inline)]
        public static Bit GetBit(this in BitMatrix32 src, int row, int col)
            => src.bits.Get(row,col);

        [MethodImpl(Inline)]
        public static Bit GetBit(this in BitMatrix64 src, int row, int col)
            => src.bits.Get(row,col);
    }
}