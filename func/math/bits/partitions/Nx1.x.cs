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

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static partial class BitPartX
    {        
        [MethodImpl(Inline)]
        public static byte ToScalar(this Part1x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part2x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part3x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part4x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part5x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part6x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part7x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part8x1 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part9x1 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part10x1 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part11x1 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part12x1 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part13x1 src)
            => (ushort)src;


    }

}