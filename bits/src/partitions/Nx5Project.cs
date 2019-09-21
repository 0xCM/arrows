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
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part20x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part25x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x5 part)
            => Bits.scatter(src, (uint)part);


    }
}