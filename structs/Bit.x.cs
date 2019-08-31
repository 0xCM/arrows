//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static zfunc;

    public static class BitX
    {
        /// <summary>
        /// Converts a bool value to a bit value
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]
        public static Bit ToBit(this bool src)
            => src;

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ushort src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this short src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this uint src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this long src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this float src)
            => BitConverter.GetBytes(src);

        /// <summary>
        /// Converts the source value to an array of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this double src)
            => BitConverter.GetBytes(src);

    }

}