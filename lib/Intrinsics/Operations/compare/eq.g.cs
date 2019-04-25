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

    partial class InX
    {


    }

    partial class SSR
    {
        /// <summary>
        /// The generic add operator via stateless singleton reification
        /// </summary>
        public readonly struct InXEqG<T> : InXEq<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXEq<T> Operator = cast<InXEq<T>>(InXEq.TheOnly);
            
            public static readonly InXEqG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> eq(Vec128<T> lhs, Vec128<T> rhs)
                => Operator.eq(lhs,rhs);
        }

        public readonly struct InXEq : 
            InXEq<byte>,
            InXEq<sbyte>,
            InXEq<short>,
            InXEq<ushort>,
            InXEq<int>,
            InXEq<uint>,
            InXEq<long>,
            InXEq<ulong>,
            InXEq<float>,
            InXEq<double>
        {        
            public static readonly InXEq TheOnly = default;

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