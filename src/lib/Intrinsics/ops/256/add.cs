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
    
    using static zcore;
    using static x86;

    partial class Operative
    {

        public interface InX256Add<T>
            where T : struct, IEquatable<T>
        {
            Vec256<T> add(Vec256<T> lhs, Vec256<T> rhs);
        }

    }
    partial class InX256
    {

        [MethodImpl(Inline)]
        public static Vec256<byte> add(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<ushort> add(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(Vec256<ulong> lhs, Vec256<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.Add(lhs, rhs);


    }

}