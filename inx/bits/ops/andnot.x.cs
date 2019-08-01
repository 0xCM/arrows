//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;
    using static Span256;
    using static Span128;

    
    partial class BitX
    {

        [MethodImpl(Inline)]
        public static Vec256<sbyte> AndNot(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> AndNot(this Vec256<byte> lhs, in Vec256<byte> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> AndNot(this Vec256<short> lhs, in Vec256<short> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> AndNot(this Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> AndNot(this Vec256<int> lhs, in Vec256<int> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> AndNot(this Vec256<uint> lhs, in Vec256<uint> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> AndNot(this Vec256<long> lhs, in Vec256<long> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> AndNot(this Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Bits.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => Bits.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => Bits.andnot(in lhs, in rhs, ref dst);
    }
}