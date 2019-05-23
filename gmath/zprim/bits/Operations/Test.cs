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
    using static mfunc;
    
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
            => (src & (I32One << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in uint src, in int pos)
            => (src & (U32One << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(in long src, in int pos)
            => (src & (I64One << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(in ulong src, in int pos)
            => (src & (U64One << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(in double src, in int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool test(in float src, in int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 


        [MethodImpl(Inline)]
        public static ref Bit test(in sbyte src, in int pos, out Bit dst)
        {
            dst = (src & (I32One << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in byte src, in int pos, out Bit dst)
        {
            dst = (src & (I32One << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in short src, in int pos, out Bit dst)
        {
            dst = (src & (I32One << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ushort src, in int pos, out Bit dst)
        {
            dst = (src & (I32One << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in int src, in int pos, out Bit dst)
        {
            dst = (src & (I32One << pos)) != I32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (U32One << pos)) != U32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in long src, in int pos, out Bit dst)
        {
            dst = (src & (I64One << pos)) != I64Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ulong src, in int pos, out Bit dst)
        {
            dst = (src & (U64One << pos)) != U64Zero;
            return ref dst;
        }
    }

}