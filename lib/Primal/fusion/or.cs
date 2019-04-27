namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {
 
        [MethodImpl(Inline)]
        static Index<byte> or(Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs, (x,y) => (byte)(x | y));

        [MethodImpl(Inline)]
        static Index<sbyte> or(Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs, (x,y) => (sbyte)(x | y));

        [MethodImpl(Inline)]
        static Index<short> or(Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs, (x,y) => (short)(x | y));

        [MethodImpl(Inline)]
        static Index<ushort> or(Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs, (x,y) => (ushort)(x | y));

        [MethodImpl(Inline)]
        static Index<int> or(Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs, (x,y) => (x | y));

        [MethodImpl(Inline)]
        static Index<uint> or(Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs, (x,y) => (x | y));

        [MethodImpl(Inline)]
        static Index<long> or(Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs, (x,y) => (x | y));

        [MethodImpl(Inline)]
        static Index<ulong> or(Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs, (x,y) => (x | y));

        [MethodImpl(Inline)]
        static Index<BigInteger> or(Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs, (x,y) => (x | y));


         static readonly PrimalIndex OrDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(add),
                @byte : new PrimalFusedBinOp<byte>(add),
                @short : new PrimalFusedBinOp<short>(add),
                @ushort : new PrimalFusedBinOp<ushort>(add),
                @int : new PrimalFusedBinOp<int>(add),
                @uint : new PrimalFusedBinOp<uint>(add),
                @long : new PrimalFusedBinOp<long>(add),
                @ulong : new PrimalFusedBinOp<ulong>(add),
                bigint : new PrimalFusedBinOp<BigInteger>(add)
            );

        readonly struct Or<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = OrDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}