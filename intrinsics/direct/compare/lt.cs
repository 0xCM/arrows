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
        
    using static zfunc;    

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<sbyte> lt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> lt(in Vec128<short> lhs, in Vec128<short> rhs)
            => CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> lt(in Vec128<int> lhs, in Vec128<int> rhs)
            => CompareLessThan(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> lt(in Vec128<float> lhs, in Vec128<float> rhs)
            => CompareLessThan(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> lt(in Vec128<double> lhs, in Vec128<double> rhs)
            => CompareLessThan(lhs, rhs);
    
        [MethodImpl(Inline)]
        public static bool lt(in Num128<float> lhs, in Num128<float> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);                

        [MethodImpl(Inline)]
        public static bool lt(in Num128<double> lhs, in Num128<double> rhs)
            => CompareScalarOrderedLessThan(lhs, rhs);
    
    }

}