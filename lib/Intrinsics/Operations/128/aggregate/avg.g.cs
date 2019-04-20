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
        public static InXAvg<T> avg<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.Operator;

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> avg<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.TheOnly.avg(lhs,rhs);

        /// <summary>
        /// Applies the operator
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> avg<T>(Vec256<T> lhs, Vec256<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAvgG<T>.TheOnly.avg(lhs,rhs);
    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXAvgG<T> : InXAvg<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAvg<T> Operator = cast<InXAvg<T>>(InXAvg.TheOnly);

            public static readonly InXAvgG<T> TheOnly = default;

            public Vec128<T> avg(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.avg(lhs,rhs);

            public Vec256<T> avg(in Vec256<T> lhs, in Vec256<T> rhs)
                => Operator.avg(lhs,rhs);
        }


        public readonly struct InXAvg : 
            InXAvg<byte>,
            InXAvg<ushort>
        {        
            public static readonly InXAvg TheOnly = default;

            [MethodImpl(Inline)]          
            public Vec128<byte> avg(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.Average(lhs,rhs);

            [MethodImpl(Inline)]          
            public Vec256<byte> avg(in Vec256<byte> lhs, in Vec256<byte> rhs)
                => Avx2.Average(lhs,rhs);

            [MethodImpl(Inline)]          
            public Vec128<ushort> avg(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.Average(lhs,rhs);

            [MethodImpl(Inline)]          
            public Vec256<ushort> avg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
                => Avx2.Average(lhs,rhs);
        }


    }
            

}