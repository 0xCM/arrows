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
    using static Operative;


    public partial class InX
    {
        
        [MethodImpl(Inline)]
        public static unsafe void add(in Num128<float> lhs, in Num128<float> rhs, float* dst)
            => Avx2.StoreScalar(dst,Avx2.AddScalar(lhs, rhs));
        
        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
            => Avx2.Store(dst, Avx2.Add(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

        [MethodImpl(Inline)]
        public unsafe static void add(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => Avx2.Store(dst, Avx2.Add(lhs, rhs));

    }

}