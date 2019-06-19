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
        public static Vec128<sbyte> andnot(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> andnot(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> andnot(in Vec128<short> lhs, in Vec128<short> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> andnot(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> andnot(in Vec128<int> lhs, in Vec128<int> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> andnot(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> andnot(in Vec128<long> lhs, in Vec128<long> rhs)
            => AndNot(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<ulong> andnot(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => AndNot(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<float> andnot(in Vec128<float> lhs, in Vec128<float> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> andnot(in Vec128<double> lhs, in Vec128<double> rhs)
            => AndNot(lhs, rhs);        
    
        [MethodImpl(Inline)]
        public static Vec256<sbyte> andnot(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> andnot(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> andnot(in Vec256<short> lhs, in Vec256<short> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> andnot(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> andnot(in Vec256<int> lhs, in Vec256<int> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> andnot(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> andnot(in Vec256<long> lhs, in Vec256<long> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> andnot(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> andnot(in Vec256<float> lhs, in Vec256<float> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> andnot(in Vec256<double> lhs, in Vec256<double> rhs)
            => AndNot(lhs, rhs);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(AndNot(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void andnot(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(AndNot(lhs, rhs), ref dst);

    }
}