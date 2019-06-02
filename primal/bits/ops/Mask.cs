//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        static byte MaskU8(in byte src, in int pos)
            => (byte)(1 << pos);

        [MethodImpl(Inline)]
        static sbyte MaskI8(in sbyte src, in int pos)
            => (sbyte)(1 << pos);

        [MethodImpl(Inline)]
        static short MaskI16(in short src, in int pos)
            => (short)(1 << pos);

        [MethodImpl(Inline)]
        static ushort MaskU16(in ushort src, in int pos)
            => (ushort)(1 << pos);

        [MethodImpl(Inline)]
        static int MaskI32(in int src, in int pos)
            => 1 << pos;

        [MethodImpl(Inline)]
        static uint MaskU32(in uint src, in int pos)
            => 1u << pos;

        [MethodImpl(Inline)]
        static long MaskI64(in long src, in int pos)
            => 1L << pos;

        [MethodImpl(Inline)]
        static ulong MaskU64(in ulong src, in int pos)
            => 1ul << pos;
    }
}