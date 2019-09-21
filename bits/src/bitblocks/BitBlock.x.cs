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

    public static class BitBlockX
    {
        /// <summary>
        /// Populates a bitblock of length 2 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock2> ToBitBlock(this BitString src, N2 n)
            => BitBlock.FromSpan<BitBlock2>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 3 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock3> ToBitBlock(this BitString src, N3 n)
            => BitBlock.FromSpan<BitBlock3>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 4 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock4> ToBitBlock(this BitString src, N4 n)
            => BitBlock.FromSpan<BitBlock4>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 5 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock5> ToBitBlock(this BitString src, N5 n)
            => BitBlock.FromSpan<BitBlock5>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 6 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock6> ToBitBlock(this BitString src, N6 n)
            => BitBlock.FromSpan<BitBlock6>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 7 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock7> ToBitBlock(this BitString src, N7 n)
            => BitBlock.FromSpan<BitBlock7>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 8 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock8> ToBitBlock(this BitString src, N8 n)
            => BitBlock.FromSpan<BitBlock8>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 9 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock9> ToBitBlock(this BitString src, N9 n)
            => BitBlock.FromSpan<BitBlock9>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 10 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock10> ToBitBlock(this BitString src, N10 n)
            => BitBlock.FromSpan<BitBlock10>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 11 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock11> ToBitBlock(this BitString src, N11 n)
            => BitBlock.FromSpan<BitBlock11>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 12 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock12> ToBitBlock(this BitString src, N12 n)
            => BitBlock.FromSpan<BitBlock12>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 13 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock13> ToBitBlock(this BitString src, N13 n)
            => BitBlock.FromSpan<BitBlock13>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 14 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock14> ToBitBlock(this BitString src, N14 n)
            => BitBlock.FromSpan<BitBlock14>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 15 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock15> ToBitBlock(this BitString src, N15 n)
            => BitBlock.FromSpan<BitBlock15>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 16 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock16> ToBitBlock(this BitString src, N16 n)
            => BitBlock.FromSpan<BitBlock16>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 17 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock17> ToBitBlock(this BitString src, N17 n)
            => BitBlock.FromSpan<BitBlock17>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 18 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock18> ToBitBlock(this BitString src, N18 n)
            => BitBlock.FromSpan<BitBlock18>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 19 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock19> ToBitBlock(this BitString src, N19 n)
            => BitBlock.FromSpan<BitBlock19>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 20 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock20> ToBitBlock(this BitString src, N20 n)
            => BitBlock.FromSpan<BitBlock20>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 20 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock21> ToBitBlock(this BitString src, N21 n)
            => BitBlock.FromSpan<BitBlock21>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 32 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock<BitBlock32> ToBitBlock(this BitString src, N32 n)
            => BitBlock.FromSpan<BitBlock32>(src.BitSeq);

        /// <summary>
        /// Presents a non-parametric bitblock as a generic bitblock
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitBlock<T> AsGeneric<T>(this ref T src)
            where T : unmanaged, IBitBlock
                => BitBlock.AsGeneric(ref src);

    }

}