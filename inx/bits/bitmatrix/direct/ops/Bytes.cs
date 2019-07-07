//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    partial class BitMatrixX
    {   

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public static Span<byte> Bytes(this ref BitMatrix4 src)
            => src.bits;

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public static Span<byte> Bytes(this ref BitMatrix8 src)
            => src.bits;

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public static Span<byte> Bytes(this ref BitMatrix16 src)
            => src.bits.AsBytes();

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public static Span<byte> Bytes(this ref BitMatrix32 src)
            => src.bits.AsBytes();

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public static Span<byte> Bytes(this ref BitMatrix64 src)
            => src.bits.AsBytes();
    }

}