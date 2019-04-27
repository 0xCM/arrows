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
            => map(src, x => x < 0 ? (sbyte)(-x) : x);

        [MethodImpl(Inline)]
        static Index<byte> abs(Index<byte> src)
            => src;

        [MethodImpl(Inline)]
        static Index<short> abs(Index<short> src)
            => map(src, x => x < 0 ? (short)(-x) : x);

        [MethodImpl(Inline)]
        static Index<ushort> abs(Index<ushort> src)
            => src;

        [MethodImpl(Inline)]
        static Index<int> abs(Index<int> src)
            => map(src, x => x < 0 ? -x : x);

        [MethodImpl(Inline)]
        static Index<uint> abs(Index<uint> src)
            => src;

        [MethodImpl(Inline)]
        static Index<long> abs(Index<long> src)
            => map(src, x => x < 0 ? -x : x);

        [MethodImpl(Inline)]
        static Index<ulong> abs(Index<ulong> src)
            => src;

        [MethodImpl(Inline)]
        static Index<float> abs(Index<float> src)
            => map(src, MathF.Abs);

        [MethodImpl(Inline)]
        static Index<double> abs(Index<double> src)
            => map(src, Math.Abs);

        [MethodImpl(Inline)]
        static Index<decimal> abs(Index<decimal> src)
            => map(src, x => x < 0 ? -x : x);

        [MethodImpl(Inline)]
        static Index<BigInteger> abs(Index<BigInteger> src)
            => map(src, BigInteger.Abs);

        static readonly PrimalIndex AbsDelegates = PrimKinds.index<object>
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