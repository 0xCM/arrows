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
        static Index<sbyte> abs(Index<sbyte> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<byte> abs(Index<byte> src)
            => src;

        [MethodImpl(Inline)]
        static Index<short> abs(Index<short> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ushort> abs(Index<ushort> src)
            => src;

        [MethodImpl(Inline)]
        static Index<int> abs(Index<int> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }
            
        [MethodImpl(Inline)]
        static Index<uint> abs(Index<uint> src)
            => src;

        [MethodImpl(Inline)]
        static Index<long> abs(Index<long> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<ulong> abs(Index<ulong> src)
            => src;

        [MethodImpl(Inline)]
        static Index<float> abs(Index<float> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = MathF.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<double> abs(Index<double> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<decimal> abs(Index<decimal> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = Math.Abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static Index<BigInteger> abs(Index<BigInteger> src)
        {
            var dst = target(src);
            for(var i = 0; i<dst.Length; i++)
                dst[i] = BigInteger.Abs(src[i]);
            return dst;
        }

        static readonly PrimalIndex AbsDelegates = PrimalKinds.index<object>
            (
                @sbyte : new PrimalFusedUnaryOp<sbyte>(abs),
                @byte : new PrimalFusedUnaryOp<byte>(abs),
                @short : new PrimalFusedUnaryOp<short>(abs),
                @ushort : new PrimalFusedUnaryOp<ushort>(abs),
                @int : new PrimalFusedUnaryOp<int>(abs),
                @uint : new PrimalFusedUnaryOp<uint>(abs),
                @long : new PrimalFusedUnaryOp<long>(abs),
                @ulong : new PrimalFusedUnaryOp<ulong>(abs),
                @float : new PrimalFusedUnaryOp<float>(abs),
                @double : new PrimalFusedUnaryOp<double>(abs),
                @decimal : new PrimalFusedUnaryOp<decimal>(abs),
                bigint : new PrimalFusedUnaryOp<BigInteger>(abs)
            );

        readonly struct Abs<T>
            where T : struct, IEquatable<T>
        {
            public static readonly PrimalFusedUnaryOp<T> Op 
                = AbsDelegates.lookup<T,PrimalFusedUnaryOp<T>>();
        }
    }
}