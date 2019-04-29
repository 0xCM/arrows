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
        static Index<sbyte> xor(Index<sbyte> lhs, Index<sbyte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (sbyte)(lhs[i] ^ rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<byte> xor(Index<byte> lhs, Index<byte> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (byte)(lhs[i] ^ rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<short> xor(Index<short> lhs, Index<short> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (short)(lhs[i] ^ rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ushort> xor(Index<ushort> lhs, Index<ushort> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = (ushort)(lhs[i] ^ rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<int> xor(Index<int> lhs, Index<int> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<uint> xor(Index<uint> lhs, Index<uint> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<long> xor(Index<long> lhs, Index<long> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> xor(Index<ulong> lhs, Index<ulong> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }


        [MethodImpl(Inline)]
        static Index<BigInteger> xor(Index<BigInteger> lhs, Index<BigInteger> rhs)
        {
            var dst = target(lhs,rhs);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = lhs[i] ^ rhs[i];
            return dst;
        }


         static readonly PrimalIndex XOrDelegates = PrimalKinds.index<object>
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