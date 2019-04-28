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
        static Index<byte> div(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] / rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<sbyte> div(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] / rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<short> div(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] / rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<ushort> div(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] / rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> div(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> div(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> div(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> div(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<float> div(Index<float> lhs, Index<float> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<double> div(Index<double> lhs, Index<double> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<decimal> div(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> div(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] / rhs[i];
            return dst;
        }


         static readonly PrimalIndex DivDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(div),
                @byte : new PrimalFusedBinOp<byte>(div),
                @short : new PrimalFusedBinOp<short>(div),
                @ushort : new PrimalFusedBinOp<ushort>(div),
                @int : new PrimalFusedBinOp<int>(div),
                @uint : new PrimalFusedBinOp<uint>(div),
                @long : new PrimalFusedBinOp<long>(div),
                @ulong : new PrimalFusedBinOp<ulong>(div),
                @float : new PrimalFusedBinOp<float>(div),
                @double : new PrimalFusedBinOp<double>(div),
                @decimal : new PrimalFusedBinOp<decimal>(div),
                bigint : new PrimalFusedBinOp<BigInteger>(div)
            );

        readonly struct Div<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = DivDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}