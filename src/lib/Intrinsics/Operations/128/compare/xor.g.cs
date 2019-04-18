//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;

    partial class InXG
    {
        /// <summary>
        /// Obtains the generic xor operator for a specified primitive type
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static InXXOr<T> xor<T>()
            where T : struct, IEquatable<T>
                => SSR.InXXOrG<T>.Operator;


        /// <summary>
        /// Applies the generic xor operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXXOrG<T>.TheOnly.xor(lhs,rhs);

    }

    partial class SSR
    {

        public readonly struct InXXOrG<T> : InXXOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXXOrG<T> TheOnly = default;

            public static readonly InXXOr<T> Operator = cast<InXXOr<T>>(InXXOr.TheOnly);
            
            [MethodImpl(Inline)]
            public Vec128<T> xor(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.xor(lhs,rhs);
        }

        public readonly struct InXXOr : 
            InXXOr<byte>,
            InXXOr<sbyte>,
            InXXOr<short>,
            InXXOr<ushort>,
            InXXOr<int>,
            InXXOr<uint>,
            InXXOr<long>,
            InXXOr<ulong>,
            InXXOr<float>,
            InXXOr<double>

        {
            public static readonly InXXOr TheOnly = default;

            [MethodImpl(Inline)]
            public Vec128<sbyte> xor(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<byte> xor(Vec128<byte> lhs, Vec128<byte> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> xor(Vec128<short> lhs, Vec128<short> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> xor(Vec128<ushort> lhs, Vec128<ushort> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> xor(Vec128<int> lhs, Vec128<int> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> xor(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> xor(Vec128<long> lhs, Vec128<long> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> xor(Vec128<ulong> lhs, Vec128<ulong> rhs)
                => Avx2.Xor(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> xor(Vec128<float> lhs, Vec128<float> rhs)
                => Avx2.Xor(lhs, rhs);    
    
            [MethodImpl(Inline)]
            public Vec128<double> xor(Vec128<double> lhs, Vec128<double> rhs)
                => Avx2.Xor(lhs, rhs);

        }
    }

}