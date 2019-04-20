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
        /// Obtains the or[T] operator bundle where 
        /// T: sbyte | byte | short | ushort | int | uint | long | ulong | single | double
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static InXOr<T> or<T>()
            where T : struct, IEquatable<T>
                => SSR.InXOrG<T>.Operator;

        /// <summary>
        /// Computes the bitwise or between two vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXOrG<T>.TheOnly.or(lhs,rhs);
    }
    
    partial class SSR
    {

        public readonly struct InXOrG<T> : InXOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXOr<T> Operator = cast<InXOr<T>>(InXOr.TheOnly);
            
            public static readonly InXOrG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> or(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.or(lhs,rhs);
        }

        public readonly struct InXOr : 
            InXOr<byte>,
            InXOr<sbyte>,
            InXOr<short>,
            InXOr<ushort>,
            InXOr<int>,
            InXOr<uint>,
            InXOr<long>,
            InXOr<ulong>,
            InXOr<float>,
            InXOr<double>

        {
            public static readonly InXOr TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<sbyte> or(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.Or(lhs, rhs);


            [MethodImpl(Inline)]
            public Vec128<byte> or(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> or(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> or(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> or(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> or(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> or(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> or(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> or(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.Or(lhs, rhs);
    
            [MethodImpl(Inline)]
            public Vec128<double> or(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.Or(lhs, rhs);

        }
    }

}