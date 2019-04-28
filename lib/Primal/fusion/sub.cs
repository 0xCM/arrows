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

    partial class PrimalFusion
    {
 
        [MethodImpl(Inline)]
        static Index<byte> sub(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] - rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<sbyte> sub(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] - rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<short> sub(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] - rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<ushort> sub(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] - rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> sub(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> sub(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> sub(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> sub(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<float> sub(Index<float> lhs, Index<float> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<double> sub(Index<double> lhs, Index<double> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<decimal> sub(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> sub(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] - rhs[i];
            return dst;
        }

        static readonly PrimalIndex SubDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(sub),
                @byte : new PrimalFusedBinOp<byte>(sub),
                @short : new PrimalFusedBinOp<short>(sub),
                @ushort : new PrimalFusedBinOp<ushort>(sub),
                @int : new PrimalFusedBinOp<int>(sub),
                @uint : new PrimalFusedBinOp<uint>(sub),
                @long : new PrimalFusedBinOp<long>(sub),
                @ulong : new PrimalFusedBinOp<ulong>(sub),
                @float : new PrimalFusedBinOp<float>(sub),
                @double : new PrimalFusedBinOp<double>(sub),
                @decimal : new PrimalFusedBinOp<decimal>(sub),
                bigint : new PrimalFusedBinOp<BigInteger>(sub)
            );

        readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = SubDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }
    }
}