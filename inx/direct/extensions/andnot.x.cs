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

    partial class dinxx
    {

        [MethodImpl(Inline)]
        public static Vec256<sbyte> AndNot(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> AndNot(this in Vec256<byte> lhs, in Vec256<byte> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> AndNot(this in Vec256<short> lhs, in Vec256<short> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> AndNot(this in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> AndNot(this in Vec256<int> lhs, in Vec256<int> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> AndNot(this in Vec256<uint> lhs, in Vec256<uint> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> AndNot(this in Vec256<long> lhs, in Vec256<long> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> AndNot(this in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => dinx.andnot(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => dinx.andnot(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void AndNot(this in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => dinx.andnot(in lhs, in rhs, ref dst);
    }
}