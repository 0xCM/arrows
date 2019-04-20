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
        public static InXOp<T> op7Z<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> op7Z<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXOp7ZG<T>.TheOnly.op7Z(lhs,rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// Defines the generic operator via stateless singleton reification
        /// </summary>
        public readonly struct InXOp7ZG<T> : InXOp<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXOp<T> Operator = cast<InXOp<T>>(InXOp7Z.TheOnly);

            public static readonly InXOp7ZG<T> TheOnly = default;
            public Vec128<T> op7Z(Vec128<T> lhs, Vec128<T> rhs)
            {
                throw new NotImplementedException();
            }
        }


        public readonly struct InXOp7Z : 
            InXOp<double>
        {        
            public static readonly InXOp7Z TheOnly = default;

            public Vec128<double> op7Z(Vec128<double> lhs, Vec128<double> rhs)
            {
                throw new NotImplementedException();
            }
        }


    }
            

}