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
        public static bool test(sbyte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(byte src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(short src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(ushort src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(int src, int pos)
            => (src & (1 << pos)) != 0;

        [MethodImpl(Inline)]
        public static bool test(uint src, int pos)
            => (src & (1u << pos)) != 0u;

        [MethodImpl(Inline)]
        public static bool test(long src, int pos)
            => (src & (1L << pos)) != 0L;

        [MethodImpl(Inline)]
        public static bool test(ulong src, int pos)
            => (src & (1ul << pos)) != 0ul;


        [MethodImpl(Inline)]
        public static bool test(double src, int pos)
            => test(BitConverter.DoubleToInt64Bits(src),pos);

        [MethodImpl(Inline)]
        public static bool test(float src, int pos)
            => test(BitConverter.SingleToInt32Bits(src),pos);
 
        [MethodImpl(Inline)]
        public static bool test(in U128 src, int pos)
            => pos < 64 ? test(src.x0, pos) : test(src.x1, pos) ;

        [MethodImpl(Inline)]
        public static bool test(in I128 src, int pos)
            => pos < 64 ? test(src.x0, pos) : test(src.x1, pos) ;

    }

}