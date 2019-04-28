//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static inxfunc;

    public static class InXFusionOps
    {

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => InX.Add<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> add<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => add<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => InX.Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> sub<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => sub<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalAggOp<T> sum<T>()
            where T : struct, IEquatable<T>
                => InX.Sum<T>.Op;

        [MethodImpl(Inline)]
        public static T sum<T>(in Index<T> src)
            where T : struct, IEquatable<T>
                => sum<T>()(src); 
 
        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => InX.And<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> and<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => and<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => InX.Or<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> or<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => or<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => InX.XOr<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> xor<T>(in Index<T> lhs, in Index<T> rhs)
            where T : struct, IEquatable<T>
                => xor<T>()(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedUnaryOp<T> sqrt<T>()
            where T : struct, IEquatable<T>
                => InX.Sqrt<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> sqrt<T>(in Index<T> src)
            where T : struct, IEquatable<T>
                => sqrt<T>()(src);
    }
}