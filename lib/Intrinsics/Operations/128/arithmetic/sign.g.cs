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
        /// Obtains the op1[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXOp<T> opQ1<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> opQ1<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXOpQ1G<T>.TheOnly.opQ1(lhs,rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// Defines the generic operator via stateless singleton reification
        /// </summary>
        public readonly struct InXOpQ1G<T> : InXOp<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXOp<T> Operator = cast<InXOp<T>>(InXOpQ1.TheOnly);

            public static readonly InXOpQ1G<T> TheOnly = default;
            public Vec128<T> opQ1(Vec128<T> lhs, Vec128<T> rhs)
            {
                throw new NotImplementedException();
            }
        }


        public readonly struct InXOpQ1 : 
            InXOp<double>
        {        
            public static readonly InXOpQ1 TheOnly = default;

            public Vec128<double> opQ1(Vec128<double> lhs, Vec128<double> rhs)
            {
                throw new NotImplementedException();
            }
        }


    }
            

}