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

    partial class InXG
    {

        /// <summary>
        /// Obtains the div[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXDiv<T> div<T>()
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.Operator;

        
        /// <summary>
        /// Divides one floating-point scalar by another
        /// </summary>
        /// <param name="lhs">The dividend</param>
        /// <param name="rhs">The divisor</param>
        /// <typeparam name="T">The primitive type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> divf<T>(Num128<T> lhs, Num128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.TheOnly.div(lhs,rhs);
        
        /// <summary>
        /// Divides the components of two floating-point vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> divf<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXDivG<T>.TheOnly.div(lhs,rhs);

    }

    partial class SSR
    {


        public readonly struct InXDivG<T> : InXDiv<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXDiv<T> Operator = cast<InXDiv<T>>(InXDiv.TheOnly);
            
            public static readonly InXDivG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> div(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.div(lhs,rhs);

            [MethodImpl(Inline)]
            public Num128<T> div(in Num128<T> lhs, in Num128<T> rhs)
                => Operator.div(lhs,rhs);

        }

        public readonly struct InXDiv :
            InXDiv<float>,
            InXDiv<double>
        {
            public static readonly InXDiv TheOnly = default;
            
            [MethodImpl(Inline)]
            public Num128<float> div(in Num128<float> lhs, in Num128<float> rhs)
                => Avx2.DivideScalar(lhs, rhs);

            [MethodImpl(Inline)]
            public Num128<double> div(in Num128<double> lhs, in Num128<double> rhs)
                => Avx2.DivideScalar(lhs, rhs);
            
            [MethodImpl(Inline)]
            public Vec128<float> div(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.Divide(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<double> div(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.Divide(lhs, rhs);
        }

    }

}