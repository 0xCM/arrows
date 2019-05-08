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
    
    
    using static mfunc;

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<sbyte> andnot(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> andnot(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> andnot(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> andnot(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> andnot(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> andnot(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> andnot(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.AndNot(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<float> andnot(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> andnot(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.AndNot(lhs, rhs);        
    
        [MethodImpl(Inline)]
        public static Vec256<sbyte> andnot(Vec256<sbyte> lhs, Vec256<sbyte> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> andnot(Vec256<byte> lhs, Vec256<byte> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> andnot(Vec256<short> lhs, Vec256<short> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> andnot(Vec256<ushort> lhs, Vec256<ushort> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> andnot(Vec256<int> lhs, Vec256<int> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> andnot(Vec256<uint> lhs, Vec256<uint> rhs)
            => Avx2.AndNot(lhs, rhs);

       [MethodImpl(Inline)]
        public static Vec256<long> andnot(Vec256<long> lhs, Vec256<long> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> andnot(Vec256<float> lhs, Vec256<float> rhs)
            => Avx2.AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> andnot(Vec256<double> lhs, Vec256<double> rhs)
            => Avx2.AndNot(lhs, rhs);
    }
}