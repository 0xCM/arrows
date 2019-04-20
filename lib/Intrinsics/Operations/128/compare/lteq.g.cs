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
        public static InXOp<T> opL3<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> opL3<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXOpL3G<T>.TheOnly.opL3(lhs,rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// Defines the generic operator via stateless singleton reification
        /// </summary>
        public readonly struct InXOpL3G<T> : InXOp<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXOp<T> Operator = cast<InXOp<T>>(InXOpL3.TheOnly);

            public static readonly InXOpL3G<T> TheOnly = default;
            public Vec128<T> opL3(Vec128<T> lhs, Vec128<T> rhs)
            {
                throw new NotImplementedException();
            }
        }


        public readonly struct InXOpL3 : 
            InXOp<double>
        {        
            public static readonly InXOpL3 TheOnly = default;

            public Vec128<double> opL3(Vec128<double> lhs, Vec128<double> rhs)
            {
                throw new NotImplementedException();
            }
        }


    }
            

}