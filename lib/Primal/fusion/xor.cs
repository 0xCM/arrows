namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;

    using static zcore;

    partial class PrimalFusion
    {
 
        [MethodImpl(Inline)]
        static Index<byte> xor(Index<byte> lhs, Index<byte> rhs)
            => fuse(lhs,rhs, (x,y) => (byte)(x ^ y));

        [MethodImpl(Inline)]
        static Index<sbyte> xor(Index<sbyte> lhs, Index<sbyte> rhs)
            => fuse(lhs,rhs, (x,y) => (sbyte)(x ^ y));

        [MethodImpl(Inline)]
        static Index<short> xor(Index<short> lhs, Index<short> rhs)
            => fuse(lhs,rhs, (x,y) => (short)(x ^ y));

        [MethodImpl(Inline)]
        static Index<ushort> xor(Index<ushort> lhs, Index<ushort> rhs)
            => fuse(lhs,rhs, (x,y) => (ushort)(x ^ y));

        [MethodImpl(Inline)]
        static Index<int> xor(Index<int> lhs, Index<int> rhs)
            => fuse(lhs,rhs, (x,y) => (x ^ y));

        [MethodImpl(Inline)]
        static Index<uint> xor(Index<uint> lhs, Index<uint> rhs)
            => fuse(lhs,rhs, (x,y) => (x ^ y));

        [MethodImpl(Inline)]
        static Index<long> xor(Index<long> lhs, Index<long> rhs)
            => fuse(lhs,rhs, (x,y) => (x ^ y));

        [MethodImpl(Inline)]
        static Index<ulong> xor(Index<ulong> lhs, Index<ulong> rhs)
            => fuse(lhs,rhs, (x,y) => (x ^ y));


        [MethodImpl(Inline)]
        static Index<BigInteger> xor(Index<BigInteger> lhs, Index<BigInteger> rhs)
            => fuse(lhs,rhs, (x,y) => (x ^ y));


         static readonly PrimalIndex XOrDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(xor),
                @byte : new PrimalFusedBinOp<byte>(xor),
                @short : new PrimalFusedBinOp<short>(xor),
                @ushort : new PrimalFusedBinOp<ushort>(xor),
                @int : new PrimalFusedBinOp<int>(xor),
                @uint : new PrimalFusedBinOp<uint>(xor),
                @long : new PrimalFusedBinOp<long>(xor),
                @ulong : new PrimalFusedBinOp<ulong>(xor),
                bigint : new PrimalFusedBinOp<BigInteger>(xor)
            );

        readonly struct XOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = XOrDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}