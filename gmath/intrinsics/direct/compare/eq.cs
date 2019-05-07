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
    using static global::mfunc;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    partial class dinx
    {

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<short> lhs, in Vec128<short> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<int> lhs, in Vec128<int> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<long> lhs, in Vec128<long> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => allOn(CompareEqual(lhs, rhs));

        [MethodImpl(Inline)]
        public static bool eq(in Vec128<float> lhs, in Vec128<float> rhs)
            => allOn(Avx2.CompareEqual(lhs, rhs).AsUInt64());
        
        [MethodImpl(Inline)]
        public static bool eq(in Vec128<double> lhs, in Vec128<double> rhs)
            => allOn(CompareEqual(lhs, rhs).AsUInt64());
  
        [MethodImpl(Inline)]
        public static bool eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<short> lhs, in Vec256<short> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }            

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<int> lhs, in Vec256<int> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }

        [MethodImpl(Inline)]
        public static bool eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
        {
            var result = CompareEqual(lhs, rhs);
            return allOn(extract(result,0)) && allOn(extract(result,1));
        }



    }
}