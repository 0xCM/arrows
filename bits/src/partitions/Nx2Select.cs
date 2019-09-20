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
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, Part6x2 part)
            => Bits.gather(src, (byte)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, Part4x2 part)
            => Bits.gather(src, (byte)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, Part8x2 part)
            => Bits.gather(src, (byte)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(ushort src, Part10x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(ushort src, Part12x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(ushort src, Part16x2 part)
            => (byte)Bits.gather(src, (ushort)part);

        /// <summary>
        /// Replicates an identified partition of a bit source to the low bits of a target 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The source partition to select/extract</param>
        [MethodImpl(Inline)]
        public static byte select(uint src, Part32x2 part)
            => (byte)Bits.gather(src, (uint)part);

    }
}