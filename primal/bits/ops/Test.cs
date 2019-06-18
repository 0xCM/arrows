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
    using static Constants;

    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static bool test(in sbyte src, in int pos)
            => (src & (1 << pos)) != 0;
            
        [MethodImpl(Inline)]
        public static bool test(in byte src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in short src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in ushort src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in int src, in int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in uint src, in int pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(in long src, in int pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(in ulong src, in int pos)
            => (src & (1ul << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(in float src, in int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 

        [MethodImpl(Inline)]
        public static bool test(in double src, in int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static ref Bit test(in sbyte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in byte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in short src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ushort src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in int src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != I32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (1u << pos)) != U32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in long src, in int pos, out Bit dst)
        {
            dst = (src & (1L << pos)) != I64Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ulong src, in int pos, out Bit dst)
        {
            dst = (src & (1ul << pos)) != U64Zero;
            return ref dst;
        }
    }

}