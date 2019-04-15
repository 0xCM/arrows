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
    using static Operative;

    public interface InX128Add<T> : InX128Op<T>
        where T : struct, IEquatable<T>
    {
        Vec128<T> add(Vec128<T> lhs, Vec128<T> rhs);
    }

    partial class InX128G
    {
        /// <summary>
        /// Provies access to the generic add operator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static InX128Add<T> add<T>()
            where T : struct, IEquatable<T>
                => InX128AddG<T>.Operator;

        /// <summary>
        /// Adds two vectors
        /// </summary>
        /// <param name="lhs">The first vector</param>
        /// <param name="rhs">The second vector</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(Vec128<T> lhs, Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => InX128AddG<T>.TheOnly.add(lhs,rhs);
    }
    
    /// <summary>
    /// The eneric add operator via singleton reification
    /// </summary>
    readonly struct InX128AddG<T> : InX128Add<T>
        where T : struct, IEquatable<T>
    {
        public static readonly InX128Add<T> Operator = cast<InX128Add<T>>(InX128Add.TheOnly);
        
        public static readonly InX128AddG<T> TheOnly = default;


        [MethodImpl(Inline)]
        public Vec128<T> add(Vec128<T> lhs, Vec128<T> rhs)
            => Operator.add(lhs,rhs);
    }

    public readonly struct InX128Add : 
        InX128Add<byte>,
        InX128Add<sbyte>,
        InX128Add<short>,
        InX128Add<ushort>,
        InX128Add<int>,
        InX128Add<uint>,
        InX128Add<long>,
        InX128Add<ulong>,
        InX128Add<float>,
        InX128Add<double>
    {        
        public static readonly InX128Add TheOnly = default;


        [MethodImpl(Inline)]
        public Vec128<byte> add(Vec128<byte> lhs, Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<sbyte> add(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<short> add(Vec128<short> lhs, Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<ushort> add(Vec128<ushort> lhs, Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<int> add(Vec128<int> lhs, Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<uint> add(Vec128<uint> lhs, Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<long> add(Vec128<long> lhs, Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<ulong> add(Vec128<ulong> lhs, Vec128<ulong> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<double> add(Vec128<double> lhs, Vec128<double> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public Vec128<float> add(Vec128<float> lhs, Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);
    }
}