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
        public static byte project(byte src, Part6x3 part)
            => Bits.scatter(src, (byte)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static T project<T>(byte src, Part6x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part9x3 part)
            => Bits.scatter(src, (ushort)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part9x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part12x3 part)
            => Bits.scatter(src, (ushort)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>        
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part12x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));


        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static ushort project(ushort src, Part15x3 part)
            => Bits.scatter(src, (ushort)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>        
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(ushort src, Part15x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part18x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>        
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part18x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part21x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>        
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part21x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part24x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part27x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part27x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Replicates the low bits of a source to an identified partition of an empty target
        /// which is then converted to a specified primal type
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The primal conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part30x3 part)
            where T : unmanaged
                => convert<T>(project(src, part));
    }
}