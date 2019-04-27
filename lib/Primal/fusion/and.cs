namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {
 
        [MethodImpl(Inline)]
        static Index<byte> and(Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs, (x,y) => (byte)(x & y));

        [MethodImpl(Inline)]
        static Index<sbyte> and(Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs, (x,y) => (sbyte)(x & y));

        [MethodImpl(Inline)]
        static Index<short> and(Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs, (x,y) => (short)(x & y));

        [MethodImpl(Inline)]
        static Index<ushort> and(Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs, (x,y) => (ushort)(x & y));

        [MethodImpl(Inline)]
        static Index<int> and(Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs, (x,y) => (x & y));

        [MethodImpl(Inline)]
        static Index<uint> and(Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs, (x,y) => (x & y));

        [MethodImpl(Inline)]
        static Index<long> and(Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs, (x,y) => (x & y));

        [MethodImpl(Inline)]
        static Index<ulong> and(Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs, (x,y) => (x & y));


        [MethodImpl(Inline)]
        static Index<BigInteger> and(Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs, (x,y) => (x & y));


         static readonly PrimalIndex AndDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(and),
                @byte : new PrimalFusedBinOp<byte>(and),
                @short : new PrimalFusedBinOp<short>(and),
                @ushort : new PrimalFusedBinOp<ushort>(and),
                @int : new PrimalFusedBinOp<int>(and),
                @uint : new PrimalFusedBinOp<uint>(and),
                @long : new PrimalFusedBinOp<long>(and),
                @ulong : new PrimalFusedBinOp<ulong>(and),
                bigint : new PrimalFusedBinOp<BigInteger>(and)
            );

        readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = AndDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}