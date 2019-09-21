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
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part1x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part2x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part3x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part3x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part4x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part5x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part5x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part6x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part7x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part7x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part8x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part9x1 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part10x1 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part11x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part11x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part12x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part13x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part13x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part16x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

        /// <summary>
        /// Replicates the low bit of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part32x1 part)
            where T : unmanaged
                => convert<T>(project(src,part));

    }
}