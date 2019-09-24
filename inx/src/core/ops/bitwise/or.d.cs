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
        public static Vector128<byte> or(Vector128<byte> lhs, Vector128<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> or(Vector128<short> lhs, Vector128<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<sbyte> or(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ushort> or(Vector128<ushort> lhs, Vector128<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> or(Vector128<int> lhs, Vector128<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<uint> or(Vector128<uint> lhs, Vector128<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<long> or(Vector128<long> lhs, Vector128<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<ulong> or(Vector128<ulong> lhs, Vector128<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<float> or(Vector128<float> lhs, Vector128<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vector128<double> or(Vector128<double> lhs, Vector128<double> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<byte> or(Vector256<byte> lhs, Vector256<byte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<short> or(Vector256<short> lhs, Vector256<short> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> or(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ushort> or(Vector256<ushort> lhs, Vector256<ushort> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> or(Vector256<int> lhs, Vector256<int> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<uint> or(Vector256<uint> lhs, Vector256<uint> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<long> or(Vector256<long> lhs, Vector256<long> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<ulong> or(Vector256<ulong> lhs, Vector256<ulong> rhs)
            => Or(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<float> or(Vector256<float> lhs, Vector256<float> rhs)
            => Or(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vector256<double> or(Vector256<double> lhs, Vector256<double> rhs)
            => Or(lhs, rhs);
    }

}