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
        public static byte ToScalar(this Part6x3 src)
            => (byte)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part9x3 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part12x3 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part15x3 src)
            => (ushort)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part18x3 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part21x3 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part24x3 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part27x3 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint ToScalar(this Part30x3 src)
            => (uint)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong ToScalar(this Part33x3 src)
            => (ulong)src;

        /// <summary>
        /// Converts the source to its underlying scalar value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong ToScalar(this Part36x3 src)
            => (ulong)src;

    }

}