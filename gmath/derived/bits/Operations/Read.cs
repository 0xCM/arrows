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
        public static Bit read(sbyte src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(byte src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(short src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(ushort src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(int src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(uint src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(long src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(ulong src, int pos)
            => Bits.testbit(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(float src, int pos)
            => Bits.test(src, pos);

        [MethodImpl(Inline)]   
        public static Bit read(double src, int pos)
            => Bits.test(src, pos);
    }
}
