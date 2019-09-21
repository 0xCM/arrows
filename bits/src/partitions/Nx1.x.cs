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

    partial class BitPartX
    {        
        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part1x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part2x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part3x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part4x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part5x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part6x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part7x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part8x1 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part9x1 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part10x1 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part11x1 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part12x1 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part13x1 src)
            => (ushort)src;
    }
}