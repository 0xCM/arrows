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

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly struct Negatable : 
            INegatableOps<byte>, 
            INegatableOps<sbyte>, 
            INegatableOps<short>, 
            INegatableOps<ushort>, 
            INegatableOps<int>, 
            INegatableOps<uint>, 
            INegatableOps<long>,             
            INegatableOps<ulong>, 
            INegatableOps<float>, 
            INegatableOps<double>, 
            INegatableOps<decimal>,
            INegatableOps<BigInteger>
        {
            static readonly Negatable Inhabitant = default;

            [MethodImpl(Inline)]
            public static INegatableOps<T> Operator<T>() 
                => cast<INegatableOps<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte negate(byte x)
                => (byte)~x;

            [MethodImpl(Inline)]
            public sbyte negate(sbyte x)
                => (sbyte)-x;

            [MethodImpl(Inline)]
            public short negate(short x)
                => (short)-x;

            [MethodImpl(Inline)]
            public ushort negate(ushort x)
                => (ushort)~x;

            [MethodImpl(Inline)]
            public int negate(int x)
                => -x;

            [MethodImpl(Inline)]
            public uint negate(uint x)
                => ~x;

            [MethodImpl(Inline)]
            public long negate(long x)
                => -x;

            [MethodImpl(Inline)]
            public ulong negate(ulong x)
                => ~x;

            [MethodImpl(Inline)]
            public BigInteger negate(BigInteger x)
                => -x;

            [MethodImpl(Inline)]
            public float negate(float x)
                => -x;

            [MethodImpl(Inline)]
            public decimal negate(decimal x)
                => -x;

            [MethodImpl(Inline)]
            public double negate(double x)
                => -x;

        }

    }
}}