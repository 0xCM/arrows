namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs, (x,y) => x == y);

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs, (x,y) => x == y);

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs, (x,y) => x == y);

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));

        [MethodImpl(Inline)]
        static Index<bool> eq(Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs, (x,y) => (x == y));


         static readonly PrimalIndex EqDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedPred<sbyte>(eq),
                @byte : new PrimalFusedPred<byte>(eq),
                @short : new PrimalFusedPred<short>(eq),
                @ushort : new PrimalFusedPred<ushort>(eq),
                @int : new PrimalFusedPred<int>(eq),
                @uint : new PrimalFusedPred<uint>(eq),
                @long : new PrimalFusedPred<long>(eq),
                @ulong : new PrimalFusedPred<ulong>(eq),
                @float : new PrimalFusedPred<float>(eq),
                @double : new PrimalFusedPred<double>(eq),
                @decimal : new PrimalFusedPred<decimal>(eq),
                bigint : new PrimalFusedPred<BigInteger>(eq)
            );

        readonly struct Eq<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedPred<T> Op 
                = EqDelegates.lookup<T,PrimalFusedPred<T>>();
        }


    }

}