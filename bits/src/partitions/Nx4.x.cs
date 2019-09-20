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
        public static byte ToScalar(this Part8x4 src)
            => (byte)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part12x4 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part16x4 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part20x4 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part24x4 src)
            => (uint)src;
            
        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part28x4 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part32x4 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong ToScalar(this Part64x4 src)
            => (ulong)src;

    }

}