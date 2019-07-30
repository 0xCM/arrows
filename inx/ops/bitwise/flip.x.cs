//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static dinx;

    partial class dinxx
    {
        public static Vec128<T> Flip<T>(in this Vec128<T> src)
            where T : struct
                => ginx.flip(in src);

        public static Vec256<T> Flip<T>(in this Vec256<T> src)
            where T : struct
                => ginx.flip(in src);


        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<sbyte> lhs, ref sbyte dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<byte> lhs, ref byte dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<short> lhs, ref short dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<ushort> lhs, ref ushort dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<int> lhs, ref int dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec128<uint> lhs, ref uint dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> Flip(this in Vec256<sbyte> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> Flip(this in Vec256<byte> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<short> Flip(this in Vec256<short> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> Flip(this in Vec256<ushort> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<int> Flip(this in Vec256<int> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> Flip(this in Vec256<uint> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<long> Flip(this in Vec256<long> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> Flip(this in Vec256<ulong> lhs)
            => flip(in lhs);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<sbyte> lhs, ref sbyte dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<byte> lhs, ref byte dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<short> lhs, ref short dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<ushort> lhs, ref ushort dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<int> lhs, ref int dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<uint> lhs, ref uint dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<long> lhs, ref long dst)
            => flip(in lhs, ref dst);

        [MethodImpl(Inline)]
        public static void Flip(this in Vec256<ulong> lhs, ref ulong dst)
            => flip(in lhs, ref dst);
    }

}