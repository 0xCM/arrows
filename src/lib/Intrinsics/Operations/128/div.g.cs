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
    using static inX;
    using static Operative;

    partial class SSR
    {


        public readonly struct InXDivG<T> : InXDiv<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXDiv<T> Operator = cast<InXDiv<T>>(InXDiv.TheOnly);
            
            public static readonly InXDivG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> div(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.div(lhs,rhs);

            [MethodImpl(Inline)]
            public Num128<T> div(Num128<T> lhs, Num128<T> rhs)
                => Operator.div(lhs,rhs);

        }

        public readonly struct InXDiv :
            InXDiv<float>,
            InXDiv<double>
        {
            public static readonly InXDiv TheOnly = default;

            
            [MethodImpl(Inline)]
            public Num128<float> div(Num128<float> lhs, Num128<float> rhs)
                => Avx2.DivideScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public Num128<double> div(Num128<double> lhs, Num128<double> rhs)
                => Avx2.DivideScalar(lhs, rhs);
            
            [MethodImpl(Inline)]
            public Vec128<float> div(Vec128<float> lhs, Vec128<float> rhs)
                => Avx2.Divide(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<double> div(Vec128<double> lhs, Vec128<double> rhs)
                => Avx2.Divide(lhs, rhs);
        }

    }

}