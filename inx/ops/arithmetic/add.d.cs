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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    public static partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Sse.Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => store(Avx2.Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Add(lhs, rhs), ref dst);

 
   }
}