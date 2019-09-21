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
        public static uint ToScalar(this Part4x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part6x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part8x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part10x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part12x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part14x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part16x2 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part18x2 src)
            => (uint)src;
    }

}