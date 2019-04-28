//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    public static partial class PrimalFusion
    {

        [MethodImpl(Inline)]
        public static PrimalFusedPred<T> eq<T>()
            where T : struct, IEquatable<T>
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static Index<bool> eq<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Eq<T>.Op(lhs,rhs);

       [MethodImpl(Inline)]
        public static PrimalFusedPred<T> lt<T>()
            where T : struct, IEquatable<T>
                => Lt<T>.Op;

        [MethodImpl(Inline)]
        public static Index<bool> lt<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Lt<T>.Op(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static PrimalFusedPred<T> gt<T>()
            where T : struct, IEquatable<T>
                => Gt<T>.Op;

        [MethodImpl(Inline)]
        public static Index<bool> gt<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Gt<T>.Op(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> add<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Add<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> sub<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Sub<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> mul<T>()
            where T : struct, IEquatable<T>
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> mul<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Mul<T>.Op(lhs,rhs);


        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> div<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Div<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> mod<T>()
            where T : struct, IEquatable<T>
                => Mod<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> mod<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Mod<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> and<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => And<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> or<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => Or<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static PrimalFusedBinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr<T>.Op;

        [MethodImpl(Inline)]
        public static PrimalFusedUnaryOp<T> abs<T>()
            where T : struct, IEquatable<T>
                => Abs<T>.Op;

        [MethodImpl(Inline)]
        public static Index<T> abs<T>(Index<T> src)
            where T : struct, IEquatable<T>
                => Abs<T>.Op(src);


    }


}