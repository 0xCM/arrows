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
        /// Obtains the add[T] operator bundle where
        /// T: sbyte | byte | short | ushort | int | uint | long | ulong | single | double
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static InXAdd<T> add<T>()
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.Operator;

        /// <summary>
        /// Applies the generic add operator to supplied operands
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => SSR.InXAddG<T>.TheOnly.add(lhs,rhs);

    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via singleton reification
        /// </summary>
        public readonly struct InXAddG<T> : InXAdd<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXAdd<T> Operator = cast<InXAdd<T>>(InXAdd.TheOnly);
            
            public static readonly InXAddG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> add(in Vec128<T> lhs, in Vec128<T> rhs)
                => Operator.add(lhs,rhs);
        }

        public readonly struct InXAdd : 
            InXAdd<byte>,
            InXAdd<sbyte>,
            InXAdd<short>,
            InXAdd<ushort>,
            InXAdd<int>,
            InXAdd<uint>,
            InXAdd<long>,
            InXAdd<ulong>,
            InXAdd<float>,
            InXAdd<double>
        {        
            public static readonly InXAdd TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
                => Avx2.Add(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
                => Avx2.Add(lhs, rhs);
        }
    }
}