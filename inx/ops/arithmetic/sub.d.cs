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

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> sub(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> sub(in Vec128<short> lhs, in Vec128<short> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sub(in Vec128<int> lhs, in Vec128<int> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> sub(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> sub(in Vec128<long> lhs, in Vec128<long> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Subtract(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Vec256<byte> sub(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Subtract(lhs, rhs);


        [MethodImpl(Inline)]
        public static void sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => store(Subtract(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => store(Subtract(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(sub(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(sub(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Num128<float> lhs, in Num128<float> rhs, ref float dst)
            => store(SubtractScalar(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void sub(in Num128<double> lhs, in Num128<double> rhs, ref double dst)
            => store(SubtractScalar(lhs, rhs), ref dst);


        [MethodImpl(Inline)]
        public static Num128<float> sub(in Num128<float> lhs, in Num128<float> rhs)
            => SubtractScalar(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Num128<double> sub(in Num128<double> lhs, in Num128<double> rhs)
            => SubtractScalar(lhs, rhs);

    }
}