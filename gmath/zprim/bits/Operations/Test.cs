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
            => (src & (OneI32 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(in uint src, in int pos)
            => (src & (OneU32 << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(in long src, in int pos)
            => (src & (OneI64 << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(in ulong src, in int pos)
            => (src & (OneU64 << pos)) != 0ul;

        [MethodImpl(Inline)]
        public static bool test(in double src, in int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool test(in float src, in int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos); 


        [MethodImpl(Inline)]
        public static ref Bit test(in sbyte src, in int pos, out Bit dst)
        {
            dst = (src & (OneI32 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in byte src, in int pos, out Bit dst)
        {
            dst = (src & (OneI32 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in short src, in int pos, out Bit dst)
        {
            dst = (src & (OneI32 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ushort src, in int pos, out Bit dst)
        {
            dst = (src & (OneI32 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in int src, in int pos, out Bit dst)
        {
            dst = (src & (OneI32 << pos)) != ZeroI32;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (OneU32 << pos)) != ZeroU32;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in long src, in int pos, out Bit dst)
        {
            dst = (src & (OneI64 << pos)) != ZeroI64;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Bit test(in ulong src, in int pos, out Bit dst)
        {
            dst = (src & (OneU64 << pos)) != ZeroU64;
            return ref dst;
        }
    }

}