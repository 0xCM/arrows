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
    using static inxfunc;

    
    partial class dinx
    {
        [MethodImpl(Inline)]
        public static bool eq(in Num128<float> lhs,in Num128<float> rhs)
            => float.IsNaN(Avx2.CompareEqualScalar(lhs, rhs).GetElement(0));
        
        [MethodImpl(Inline)]
        public static bool eq(in Num128<double> lhs,in Num128<double> rhs)
            => double.IsNaN(Avx2.CompareEqualScalar(lhs, rhs).GetElement(0));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs).AsUInt64());
        
        [MethodImpl(Inline)]
        public static bool eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.TestAllOnes(Avx2.CompareEqual(lhs, rhs).AsUInt64());
  
        [MethodImpl(Inline)]
        public static Vec256<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.CompareEqual(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.CompareEqual(lhs, rhs);



    }
}