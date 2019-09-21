//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class Bits
    {

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part1x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part2x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part3x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part4x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part5x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part6x1 part)
            => (byte)Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part7x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part8x1 part)
            => Bits.gather(src, (uint)part);
        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part9x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part10x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part11x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part12x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part13x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part16x1 part)
            => Bits.gather(src, (uint)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bit of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, Part32x1 part)
            => Bits.gather(src, (uint)part);

    }
}