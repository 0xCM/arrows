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