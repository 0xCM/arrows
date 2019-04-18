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

    partial class InXG
    {
        /// <summary>
        /// Obtains the cmpf[T] operator bundle where
        /// T: float, double
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXCmpF<T> cmpf<T>()
            where T : struct, IEquatable<T>
                => SSR.InXCmpFG<T>.Operator;

        /// <summary>
        /// Compares two floating-point vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <param name="mode">The comparison algorithm</param>
        /// <typeparam name="T">The primitive float type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> cmpf<T>(Vec128<T> lhs, Vec128<T> rhs, FloatComparisonMode mode)
            where T : struct, IEquatable<T>
                => SSR.InXCmpFG<T>.TheOnly.cmpf(lhs,rhs,mode);

        /// <summary>
        /// Compares two floating-point scalars
        /// </summary>
        /// <param name="lhs">The first scalar</param>
        /// <param name="rhs">The second scalar</param>
        /// <param name="mode">The comparison algorithm</param>
        /// <typeparam name="T">The primitive float type, either single or double</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> cmpf<T>(Num128<T> lhs, Num128<T> rhs, FloatComparisonMode mode)
            where T : struct, IEquatable<T>
                => SSR.InXCmpFG<T>.TheOnly.cmpf(lhs,rhs,mode);

    }
    
    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXCmpFG<T> : Z0.InXCmpF<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXCmpFG<T> TheOnly = default;

            public static readonly Z0.InXCmpF<T> Operator = cast<Z0.InXCmpF<T>>(InXCmpF.TheOnly);

            public Num128<T> cmpf(Num128<T> lhs, Num128<T> rhs, FloatComparisonMode mode)
                => Operator.cmpf(lhs,rhs,mode);

            public Vec128<T> cmpf(Vec128<T> lhs, Vec128<T> rhs, FloatComparisonMode mode)
                => Operator.cmpf(lhs,rhs,mode);
        }

        public readonly struct InXCmpF :
            Z0.InXCmpF<float>,
            Z0.InXCmpF<double>
        {        
            public static readonly InXCmpF TheOnly = default;

            [MethodImpl(Inline)]
            public Num128<float> cmpf(Num128<float> lhs, Num128<float> rhs, FloatComparisonMode mode)
                => Avx2.CompareScalar(lhs,rhs,mode);

            [MethodImpl(Inline)]
            public Num128<double> cmpf(Num128<double> lhs, Num128<double> rhs, FloatComparisonMode mode)
                => Avx2.CompareScalar(lhs,rhs,mode);

            [MethodImpl(Inline)]
            public Vec128<float> cmpf(Vec128<float> lhs, Vec128<float> rhs, FloatComparisonMode mode)
                => clearNaN(Avx2.Compare(lhs,rhs,mode));

            [MethodImpl(Inline)]
            public Vec128<double> cmpf(Vec128<double> lhs, Vec128<double> rhs, FloatComparisonMode mode)
                => clearNaN(Avx2.Compare(lhs,rhs,mode));
        }
    }

}