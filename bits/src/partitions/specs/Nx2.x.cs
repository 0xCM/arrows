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
        public static byte ToScalar(this Part4x2 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part6x2 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static byte ToScalar(this Part8x2 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part10x2 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part12x2 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part14x2 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this Part16x2 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static uint ToScalar(this Part18x2 src)
            => (uint)src;


    }

}