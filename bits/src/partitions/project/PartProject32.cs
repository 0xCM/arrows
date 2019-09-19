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
        /// Projects the low bit of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part1x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part2x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part3x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part4x2 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part5x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x2 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part6x3 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part7x1 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x2 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part8x4 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part9x3 part)
            => Bits.scatter(src, (uint)part);
       
        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x2 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part10x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part11x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x2 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x4 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part12x6 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part13x1 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part15x5 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x2 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x4 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part16x8 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part21x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part24x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part27x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part30x3 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x4 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x8 part)
            => Bits.scatter(src, (uint)part);

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified partition 
        /// of a an empty 32-bit target value that is returned to the caller
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        [MethodImpl(Inline)]
        public static uint project(uint src, Part32x16 part)
            => Bits.scatter(src, (uint)part);


        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part21x3 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part24x3 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part27x3 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part30x3 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part32x4 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part32x8 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

        /// <summary>
        /// Projects the low bits of a 32-bit source value to an identified
        /// partition of a an empty 32-bit target value which is subsequently returned 
        /// to the caller following its conversion to a specified primal type 
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="part">The target partition</param>
        /// <typeparam name="T">The target conversion type</typeparam>
        [MethodImpl(Inline)]
        public static T project<T>(uint src, Part32x16 part)
            where T : unmanaged
                => convert<T>(Bits.scatter(src, (uint)part));

    }

}