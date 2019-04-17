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
    using static inX;

    partial class SSR
    {

        public readonly struct InXOrG<T> : InXOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly InXOr<T> Operator = cast<InXOr<T>>(InXOr.TheOnly);
            
            public static readonly InXOrG<T> TheOnly = default;


            [MethodImpl(Inline)]
            public Vec128<T> or(Vec128<T> lhs, Vec128<T> rhs)
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
            public Vec128<sbyte> or(Vec128<sbyte> lhs, Vec128<sbyte> rhs)
                => Avx2.Or(lhs, rhs);


            [MethodImpl(Inline)]
            public Vec128<byte> or(Vec128<byte> lhs, Vec128<byte> rhs)
                => Avx2.Or(lhs, rhs);



            [MethodImpl(Inline)]
            public Vec128<short> or(Vec128<short> lhs, Vec128<short> rhs)
                => Avx2.Or(lhs, rhs);


            [MethodImpl(Inline)]
            public Vec128<ushort> or(Vec128<ushort> lhs, Vec128<ushort> rhs)
                => Avx2.Or(lhs, rhs);


            [MethodImpl(Inline)]
            public Vec128<int> or(Vec128<int> lhs, Vec128<int> rhs)
                => Avx2.Or(lhs, rhs);


            [MethodImpl(Inline)]
            public Vec128<uint> or(Vec128<uint> lhs, Vec128<uint> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<long> or(Vec128<long> lhs, Vec128<long> rhs)
                => Avx2.Or(lhs, rhs);

            [MethodImpl(Inline)]
            public Vec128<ulong> or(Vec128<ulong> lhs, Vec128<ulong> rhs)
                => Avx2.Or(lhs, rhs);

    
            [MethodImpl(Inline)]
            public Vec128<float> or(Vec128<float> lhs, Vec128<float> rhs)
                => Avx2.Or(lhs, rhs);
    
    
            [MethodImpl(Inline)]
            public Vec128<double> or(Vec128<double> lhs, Vec128<double> rhs)
                => Avx2.Or(lhs, rhs);

        }
    }

}