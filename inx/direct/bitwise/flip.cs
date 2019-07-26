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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> flip(in Vec128<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<byte> flip(in Vec128<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<short> flip(in Vec128<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<ushort> flip(in Vec128<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<int> flip(in Vec128<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<uint> flip(in Vec128<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec128<long> flip(in Vec128<long> src)
            => Vec128.define(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec128<ulong> flip(in Vec128<ulong> src)
            => Vec128.define(~src[0], ~src[1]);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> flip(in Vec256<sbyte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<byte> flip(in Vec256<byte> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<short> flip(in Vec256<short> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ushort> flip(in Vec256<ushort> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<int> flip(in Vec256<int> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<uint> flip(in Vec256<uint> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<long> flip(in Vec256<long> src)
            => Xor(src, CompareEqual(src,src));

        [MethodImpl(Inline)]
        public static Vec256<ulong> flip(in Vec256<ulong> src)
            => Xor(src, CompareEqual(src,src));


        [MethodImpl(Inline)]
        public static void flip(in Vec128<sbyte> src, ref sbyte dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<byte> src, ref byte dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<short> src, ref short dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<ushort> src, ref ushort dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<int> src, ref int dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec128<uint> src, ref uint dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<sbyte> src, ref sbyte dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<byte> src, ref byte dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<short> src, ref short dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<ushort> src, ref ushort dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<int> src, ref int dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<uint> src, ref uint dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<long> src, ref long dst)
            => store(flip(in src), ref dst);

        [MethodImpl(Inline)]
        public static void flip(in Vec256<ulong> src, ref ulong dst)
            => store(flip(in src), ref dst);

   }

}