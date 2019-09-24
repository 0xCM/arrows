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
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;    

    partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vector128<sbyte> sign(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<short> sign(Vector128<short> lhs, Vector128<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector128<int> sign(Vector128<int> lhs, Vector128<int> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<sbyte> sign(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<short> sign(Vector256<short> lhs, Vector256<short> rhs)
            => Sign(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vector256<int> sign(Vector256<int> lhs, Vector256<int> rhs)
            => Sign(lhs, rhs);


    }
}