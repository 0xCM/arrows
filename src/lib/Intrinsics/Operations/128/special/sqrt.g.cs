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
        /// Obtains the sqrt[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXSqrt<T> sqrt<T>()
            where T : struct, IEquatable<T>
                => SSR.InXSqrtG<T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> sqrt<T>(Num128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXSqrtG<T>.TheOnly.sqrt(src);


        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> sqrt<T>(Vec128<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXSqrtG<T>.TheOnly.sqrt(src);

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The source vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> sqrt<T>(Vec256<T> src)
            where T : struct, IEquatable<T>
                => SSR.InXSqrtG<T>.TheOnly.sqrt(src);

    }

    partial class SSR
    {
        /// <summary>
        /// Defines the generic operator via stateless singleton reification
        /// </summary>
        public readonly struct InXSqrtG<T> : InXSqrt<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXSqrt<T> Operator = cast<InXSqrt<T>>(InXSqrt.TheOnly);

            public static readonly InXSqrtG<T> TheOnly = default;

            public Num128<T> sqrt(Num128<T> src)
                => Operator.sqrt(src);

            public Vec128<T> sqrt(Vec128<T> src)
                => Operator.sqrt(src);

            public Vec256<T> sqrt(Vec256<T> src)
                => Operator.sqrt(src);
        }

        public readonly struct InXSqrt : 
            InXSqrt<double>
        {        
            public static readonly InXSqrt TheOnly = default;

            public Num128<float> sqrt(Num128<float> src)
                => Avx2.SqrtScalar(src);

            public Vec128<float> sqrt(Vec128<float> src)
                => Avx2.Sqrt(src);

            public Num128<double> sqrt(Num128<double> src)
                => Avx2.SqrtScalar(src);

            public Vec128<double> sqrt(Vec128<double> src)
                => Avx2.Sqrt(src);

            public Vec256<float> sqrt(Vec256<float> src)
                => Avx2.Sqrt(src);

            public Vec256<double> sqrt(Vec256<double> src)
                => Avx2.Sqrt(src);
        }
    }        
}