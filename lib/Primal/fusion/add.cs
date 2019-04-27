namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {
 
        [MethodImpl(Inline)]
        static Index<byte> add(Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs, (x,y) => (byte)(x + y));

        [MethodImpl(Inline)]
        static Index<sbyte> add(Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs, (x,y) => (sbyte)(x + y));

        [MethodImpl(Inline)]
        static Index<short> add(Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs, (x,y) => (short)(x + y));

        [MethodImpl(Inline)]
        static Index<ushort> add(Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs, (x,y) => (ushort)(x + y));

        [MethodImpl(Inline)]
        static Index<int> add(Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<uint> add(Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<long> add(Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<ulong> add(Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<float> add(Index<float> lhs, Index<float> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<double> add(Index<double> lhs, Index<double> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<decimal> add(Index<decimal> lhs, Index<decimal> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));

        [MethodImpl(Inline)]
        static Index<BigInteger> add(Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs, (x,y) => (x + y));


         static readonly PrimalIndex AddDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(add),
                @byte : new PrimalFusedBinOp<byte>(add),
                @short : new PrimalFusedBinOp<short>(add),
                @ushort : new PrimalFusedBinOp<ushort>(add),
                @int : new PrimalFusedBinOp<int>(add),
                @uint : new PrimalFusedBinOp<uint>(add),
                @long : new PrimalFusedBinOp<long>(add),
                @ulong : new PrimalFusedBinOp<ulong>(add),
                @float : new PrimalFusedBinOp<float>(add),
                @double : new PrimalFusedBinOp<double>(add),
                @decimal : new PrimalFusedBinOp<decimal>(add),
                bigint : new PrimalFusedBinOp<BigInteger>(add)
            );

        readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = AddDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}