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
    using static inX;
    using static Operative;

    partial class InXX
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> Add(this Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<sbyte> Add(this Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> Add(this Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> Add(this Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> Add(this Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> Add(this Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> Add(this Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> Add(this Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> Add(this Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> Add(this Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);       
 
    }
}