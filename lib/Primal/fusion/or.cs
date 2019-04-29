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
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] | rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<sbyte> or(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] | rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<short> or(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] | rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ushort> or(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] | rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> or(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> or(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> or(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> or(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> or(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] | rhs[i];
            return dst;
        }

        static readonly PrimalIndex OrDelegates = PrimalKinds.index<object>
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