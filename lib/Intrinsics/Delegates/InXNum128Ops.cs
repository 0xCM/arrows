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


    static class Num128Delegates
    {

        //! eq
        static readonly PrimalIndex Eq = PrimKinds.index<object>
            (
                @float : new Num128BinPred<float>(InX.eq),
                @double : new Num128BinPred<double>(InX.eq)
            );

        [MethodImpl(Inline)]
        public static Num128BinPred<T> eq<T>()
            where T : struct, IEquatable<T>
                => Eq.lookup<T,Num128BinPred<T>>();

        //! add

        static readonly PrimalIndex Add = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.add),
                @double : new Num128BinOp<double>(InX.add)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,Num128BinOp<T>>();

        //! sub

        static readonly PrimalIndex Sub = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.sub),
                @double : new Num128BinOp<double>(InX.sub)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Sub.lookup<T,Num128BinOp<T>>();

        //! div

        static readonly PrimalIndex Div = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.div),
                @double : new Num128BinOp<double>(InX.div)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Div.lookup<T,Num128BinOp<T>>();

        //! mul

        static readonly PrimalIndex Mul = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.mul),
                @double : new Num128BinOp<double>(InX.mul)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> mul<T>()
            where T : struct, IEquatable<T>
                => Mul.lookup<T,Num128BinOp<T>>();

        //! muladd

        static readonly PrimalIndex MulAdd = PrimKinds.index<object>
            (
                @float : new Num128TernaryOp<float>(InX.muladd),
                @double : new Num128TernaryOp<double>(InX.muladd)
            );

        [MethodImpl(Inline)]
        public static Num128TernaryOp<T> muladd<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,Num128TernaryOp<T>>();


        //! min

        static readonly PrimalIndex Min = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.min),
                @double : new Num128BinOp<double>(InX.min)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> min<T>()
            where T : struct, IEquatable<T>
                => Min.lookup<T,Num128BinOp<T>>();

        //! min

        static readonly PrimalIndex Max = PrimKinds.index<object>
            (
                @float : new Num128BinOp<float>(InX.max),
                @double : new Num128BinOp<double>(InX.max)
            );

        [MethodImpl(Inline)]
        public static Num128BinOp<T> max<T>()
            where T : struct, IEquatable<T>
                => Max.lookup<T,Num128BinOp<T>>();

        //! div
        static readonly PrimalIndex CmpF = PrimKinds.index<object>
            (
                @float : new Num128CmpFloat<float>(InX.cmpf),
                @double : new Num128CmpFloat<double>(InX.cmpf)
            );


        [MethodImpl(Inline)]
        public static Num128CmpFloat<T> cmpf<T>()
            where T : struct, IEquatable<T>
                => CmpF.lookup<T,Num128CmpFloat<T>>();

    }

    static class Num128OpCache
    {
        public readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.add<T>();

        }

        public readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.sub<T>();

        }

        public readonly struct Mul<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.mul<T>();

        }

        public readonly struct Div<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.div<T>();

        }


        public readonly struct MulAdd<T>
            where T : struct, IEquatable<T>
        {
            public static Num128TernaryOp<T> Op = Num128Delegates.muladd<T>();

        }

        public readonly struct Min<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.min<T>();

        }

        public readonly struct Max<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinOp<T> Op = Num128Delegates.max<T>();

        }

        public readonly struct Eq<T>
            where T : struct, IEquatable<T>
        {
            public static Num128BinPred<T> Op = Num128Delegates.eq<T>();

        }

        public readonly struct CmpF<T>
            where T : struct, IEquatable<T>
        {
            public static Num128CmpFloat<T> Op = Num128Delegates.cmpf<T>();

        }

    }


    public static class InXNum128Ops
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => Num128OpCache.Eq<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> add<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => Num128OpCache.Add<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> sub<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
            => Num128OpCache.Sub<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> mul<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
            => Num128OpCache.Mul<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> div<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => Num128OpCache.Div<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> min<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => Num128OpCache.Min<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> max<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
                => Num128OpCache.Max<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Num128<T> muladd<T>(in Num128<T> x, in Num128<T> y, in Num128<T> z)
            where T : struct, IEquatable<T>
                => Num128OpCache.MulAdd<T>.Op(x,y,z);

        [MethodImpl(Inline)]
        public static bool cmpf<T>(in Num128<T> lhs, in Num128<T> rhs, FloatCompareKind mode)
            where T : struct, IEquatable<T>
                => Num128OpCache.CmpF<T>.Op(lhs,rhs,mode);
    }
}
