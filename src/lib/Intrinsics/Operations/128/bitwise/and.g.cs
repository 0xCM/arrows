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
        /// Obtains the and[T] operator bundle
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAnd<T> and<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.Operator;

        /// <summary>
        /// Applies the generic and operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAndG<T>.TheOnly.and(lhs,rhs);

    }

    partial class SSR
    {
        public readonly struct InXAndG<T> : InXAnd<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAnd<T> Operator = cast<InXAnd<T>>(InXAnd.TheOnly);
            
            public static readonly InXAndG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> and(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.and(lhs,rhs);
        }

        public readonly struct InXAnd :
            InXAnd<byte>,
            InXAnd<sbyte>,
            InXAnd<short>,
            InXAnd<ushort>,
            InXAnd<int>,
            InXAnd<uint>,
            InXAnd<long>,
            InXAnd<ulong>,
            InXAnd<float>,
            InXAnd<double>
        {

            public static readonly InXAnd TheOnly = default;

            [MethodImpl(Inline)]
            public Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.And(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.And(lhs, rhs);
            
            [MethodImpl(Inline)]
            public Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.And(lhs, rhs);   
        }
    }
}