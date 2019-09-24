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
        public static Vector128<byte> add(Vector128<byte> lhs, Vector128<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> add(Vector128<sbyte> lhs, Vector128<sbyte> rhs) 
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> add(Vector128<short> lhs, Vector128<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> add(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> add(Vector128<int> lhs, Vector128<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> add(Vector128<uint> lhs, Vector128<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> add(Vector128<long> lhs, Vector128<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> add(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vector256<byte> add(Vector256<byte> lhs, Vector256<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> add(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<short> add(Vector256<short> lhs, Vector256<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ushort> add(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> add(Vector256<int> lhs, Vector256<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<uint> add(Vector256<uint> lhs, Vector256<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<long> add(Vector256<long> lhs, Vector256<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ulong> add(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => Add(lhs, rhs);




   }
}