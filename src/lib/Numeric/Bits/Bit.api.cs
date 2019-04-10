//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;

    public interface Bit<S> : IComparable<S>, Equatable<S>, Formattable
        where S : Bit<S>, new()
    {

    }

    public static class Bit
    {
        [MethodImpl(Inline)]
        public static bit read(byte src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(sbyte src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(short src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(ushort src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(int src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(uint src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(long src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(ulong src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(decimal src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(double src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(float src, int pos)
            => primops.testbit(src,pos);

        [MethodImpl(Inline)]
        public static bit read(BigInteger src, int pos)
            => primops.testbit(src,pos);

    }



}