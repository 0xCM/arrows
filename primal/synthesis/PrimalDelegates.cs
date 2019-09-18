//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class PrimalDelegates
    {        
        [MethodImpl(Inline)]
        public static BinaryOp<T> add<T>()
            where T : struct
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> sub<T>()
            where T : struct
                => Sub<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mul<T>()
            where T : struct
                => Mul<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> div<T>()
            where T : struct
                => Div<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> mod<T>()
            where T : struct
                => Mod<T>.Op;


        [MethodImpl(Inline)]
        public static UnaryOp<T> negate<T>()
            where T : struct
                => Negate<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> inc<T>()
            where T : struct
                => Inc<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> dec<T>()
            where T : struct
                => Dec<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> eq<T>()
            where T : struct
                => Eq<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> gt<T>()
            where T : struct
                => Gt<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> gteq<T>()
            where T : struct
                => GtEq<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> lt<T>()
            where T : struct
                => Lt<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryPredicate<T> lteq<T>()
            where T : struct
                => LtEq<T>.Op;
                        
        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
                => gmath.add(lhs,rhs);
        
        readonly struct Add<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = add<T>;
        }

       readonly struct Sub<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gmath.sub<T>;
        }

       readonly struct Mul<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gmath.mul<T>;
        }

        readonly struct Div<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gmath.div<T>;
        }

       readonly struct Mod<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gmath.mod<T>;
        }

        readonly struct Negate<T>
            where T : struct
        {
            public static readonly UnaryOp<T> Op = gmath.negate<T>;
        }    

       readonly struct Inc<T>
            where T : struct
        {
            public static readonly UnaryOp<T> Op = gmath.inc<T>;
        }    

       readonly struct Dec<T>
            where T : struct
        {
            public static readonly UnaryOp<T> Op = gmath.dec<T>;
        }    

        readonly struct Eq<T>
            where T : struct
        {
            public static readonly BinaryPredicate<T> Op = gmath.eq<T>;
        }

       readonly struct Gt<T>
            where T : struct
        {
            public static readonly BinaryPredicate<T> Op = gmath.gt<T>;
        }

       readonly struct Lt<T>
            where T : struct
        {
            public static readonly BinaryPredicate<T> Op = gmath.lt<T>;
        }    

       readonly struct GtEq<T>
            where T : struct
        {
            public static readonly BinaryPredicate<T> Op = gmath.gteq<T>;
        }

       readonly struct LtEq<T>
            where T : struct
        {
            public static readonly BinaryPredicate<T> Op = gmath.lteq<T>;
        }    
   }

}