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
        static Index<byte> mod(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] % rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<sbyte> mod(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] % rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<short> mod(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] % rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<ushort> mod(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] % rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> mod(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> mod(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> mod(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> mod(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<float> mod(Index<float> lhs, Index<float> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<double> mod(Index<double> lhs, Index<double> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<decimal> mod(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> mod(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] % rhs[i];
            return dst;
        }


         static readonly PrimalIndex ModDelegates = PrimKinds.index<object>
            (
                @sbyte : new PrimalFusedBinOp<sbyte>(mod),
                @byte : new PrimalFusedBinOp<byte>(mod),
                @short : new PrimalFusedBinOp<short>(mod),
                @ushort : new PrimalFusedBinOp<ushort>(mod),
                @int : new PrimalFusedBinOp<int>(mod),
                @uint : new PrimalFusedBinOp<uint>(mod),
                @long : new PrimalFusedBinOp<long>(mod),
                @ulong : new PrimalFusedBinOp<ulong>(mod),
                @float : new PrimalFusedBinOp<float>(mod),
                @double : new PrimalFusedBinOp<double>(mod),
                @decimal : new PrimalFusedBinOp<decimal>(mod),
                bigint : new PrimalFusedBinOp<BigInteger>(mod)
            );

        readonly struct Mod<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedBinOp<T> Op 
                = ModDelegates.lookup<T,PrimalFusedBinOp<T>>();
        }


    }

}