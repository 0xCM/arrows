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
    using static x86;

    partial class InX128G
    {
        /// <summary>
        /// Provies access the the generic equality operator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static InX128Eq<T> eq<T>()
            where T : struct, IEquatable<T>
                => SSR.InX128EqG<T>.Operator;

        /// <summary>
        /// Compares two vectors for equality
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> eq<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InX128EqG<T>.TheOnly.eq(lhs,rhs);
    }


    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InX128EqG<T> : InX128Eq<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InX128Eq<T> Operator = cast<InX128Eq<T>>(InX128Eq.TheOnly);
            
            public static readonly InX128EqG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> eq(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.eq(lhs,rhs);
        }

        public readonly struct InX128Eq : 
            InX128Eq<byte>,
            InX128Eq<sbyte>,
            InX128Eq<short>,
            InX128Eq<ushort>,
            InX128Eq<int>,
            InX128Eq<uint>,
            InX128Eq<long>,
            InX128Eq<ulong>,
            InX128Eq<float>,
            InX128Eq<double>
        {        
            public static readonly InX128Eq TheOnly = default;

            public Vec128<sbyte> eq(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<byte> eq(Vec128<byte> lhs, Vec128<byte> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<short> eq(Vec128<short> lhs, Vec128<short> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<ushort> eq(Vec128<ushort> lhs, Vec128<ushort> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<int> eq(Vec128<int> lhs, Vec128<int> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<uint> eq(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<long> eq(Vec128<long> lhs, Vec128<long> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<ulong> eq(Vec128<ulong> lhs, Vec128<ulong> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<float> eq(Vec128<float> lhs, Vec128<float> rhs)
                => Avx2.CompareEqual(lhs, rhs);

            public Vec128<double> eq(Vec128<double> lhs, Vec128<double> rhs)
                => Avx2.CompareEqual(lhs, rhs);
        }
    }


}