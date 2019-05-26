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
    using static System.Runtime.Intrinsics.X86.Sse41;    
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
    
    using static zfunc;

    public partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> max(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> max(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> max(in Vec128<short> lhs, in Vec128<short> rhs)
            => Max(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<int> max(in Vec128<int> lhs, in Vec128<int> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> max(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Max(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec128<float> max(in Vec128<float> lhs, in Vec128<float> rhs)
            => Max(lhs, rhs);
 
        [MethodImpl(Inline)]
        public static Vec128<double> max(in Vec128<double> lhs, in Vec128<double> rhs)
            => Max(lhs, rhs);

       [MethodImpl(Inline)]
        public static Vec256<byte> max(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> max(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> max(in Vec256<short> lhs, in Vec256<short> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> max(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> max(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> max(in Vec256<int> lhs, in Vec256<int> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> max(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Max(lhs, rhs);


       [MethodImpl(Inline)]
        public static Vec256<float> max(in Vec256<float> lhs, in Vec256<float> rhs)
            => Max(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> max(in Vec256<double> lhs, in Vec256<double> rhs)
            => Max(lhs, rhs);


    }
}