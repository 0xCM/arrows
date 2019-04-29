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
        static Index<byte> add(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] + rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<sbyte> add(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] + rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<short> add(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] + rhs[i]);
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<ushort> add(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] + rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> add(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> add(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> add(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> add(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<float> add(Index<float> lhs, Index<float> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<double> add(Index<double> lhs, Index<double> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<decimal> add(Index<decimal> lhs, Index<decimal> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> add(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] + rhs[i];
            return dst;
        }


         static readonly PrimalIndex AddDelegates = PrimalKinds.index<object>
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