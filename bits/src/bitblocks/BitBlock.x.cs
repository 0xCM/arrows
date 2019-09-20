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
        /// Populates a bitblock of length 3 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock3 ToBitBlock(this BitString src, N3 n)
            => BitBlock.FromSpan<BitBlock3>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 4 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock4 ToBitBlock(this BitString src, N4 n)
            => BitBlock.FromSpan<BitBlock4>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 5 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock5 ToBitBlock(this BitString src, N5 n)
            => BitBlock.FromSpan<BitBlock5>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 6 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock6 ToBitBlock(this BitString src, N6 n)
            => BitBlock.FromSpan<BitBlock6>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 7 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock7 ToBitBlock(this BitString src, N7 n)
            => BitBlock.FromSpan<BitBlock7>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 8 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock8 ToBitBlock(this BitString src, N8 n)
            => BitBlock.FromSpan<BitBlock8>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 9 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock9 ToBitBlock(this BitString src, N9 n)
            => BitBlock.FromSpan<BitBlock9>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 10 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock10 ToBitBlock(this BitString src, N10 n)
            => BitBlock.FromSpan<BitBlock10>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 11 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock11 ToBitBlock(this BitString src, N11 n)
            => BitBlock.FromSpan<BitBlock11>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 12 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock12 ToBitBlock(this BitString src, N12 n)
            => BitBlock.FromSpan<BitBlock12>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 13 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock13 ToBitBlock(this BitString src, N13 n)
            => BitBlock.FromSpan<BitBlock13>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 14 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock14 ToBitBlock(this BitString src, N14 n)
            => BitBlock.FromSpan<BitBlock14>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 15 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock15 ToBitBlock(this BitString src, N15 n)
            => BitBlock.FromSpan<BitBlock15>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 16 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock16 ToBitBlock(this BitString src, N16 n)
            => BitBlock.FromSpan<BitBlock16>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 17 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock17 ToBitBlock(this BitString src, N17 n)
            => BitBlock.FromSpan<BitBlock17>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 18 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock18 ToBitBlock(this BitString src, N18 n)
            => BitBlock.FromSpan<BitBlock18>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 19 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock19 ToBitBlock(this BitString src, N19 n)
            => BitBlock.FromSpan<BitBlock19>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 20 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock20 ToBitBlock(this BitString src, N20 n)
            => BitBlock.FromSpan<BitBlock20>(src.BitSeq);

        /// <summary>
        /// Populates a bitblock of length 20 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock21 ToBitBlock(this BitString src, N21 n)
            => BitBlock.FromSpan<BitBlock21>(src.BitSeq);


        /// <summary>
        /// Populates a bitblock of length 32 from a bitstring
        /// </summary>
        /// <param name="src">The source bitstring</param>
        /// <param name="n">The block length for overload resolution</param>
        [MethodImpl(Inline)]
        public static BitBlock32 ToBitBlock(this BitString src, N32 n)
            => BitBlock.FromSpan<BitBlock32>(src.BitSeq);

    }

}