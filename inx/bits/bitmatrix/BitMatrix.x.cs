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

    public static partial class BitMatrixX
    {   
        [MethodImpl(Inline)] 
        public static BitMatrix8 Replicate(this BitMatrix8 src)
            => BitMatrix8.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix16 Replicate(this BitMatrix16 src)
            => BitMatrix16.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix32 Replicate(this BitMatrix32 src)
            => BitMatrix32.Define(src.bits.ReadOnly());

        [MethodImpl(Inline)] 
        public static BitMatrix64 Replicate(this BitMatrix64 src)
            => BitMatrix64.Define(src.bits.ReadOnly()); 

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