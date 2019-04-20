//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify
    {
        public readonly struct Absolutive : 
            Absolutive<byte>, 
            Absolutive<sbyte>, 
            Absolutive<short>, 
            Absolutive<ushort>, 
            Absolutive<int>, 
            Absolutive<uint>, 
            Absolutive<long>, 
            Absolutive<ulong>, 
            Absolutive<float>, 
            Absolutive<double>, 
            Absolutive<decimal>,
            Absolutive<BigInteger>
        {
            static readonly Absolutive Inhabitant = default;
            
            [MethodImpl(Inline)]
            public static Absolutive<T> Operator<T>() 
                => cast<Absolutive<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte abs(byte x)
                => x;

            [MethodImpl(Inline)]
            public sbyte abs(sbyte x)
                => (sbyte)(x >= 0 ? x : -x);

            [MethodImpl(Inline)]
            public short abs(short x)
                => Math.Abs(x);

            [MethodImpl(Inline)]
            public ushort abs(ushort x)
                => x;

            [MethodImpl(Inline)]
            public int abs(int x)
                => Math.Abs(x);

            [MethodImpl(Inline)]
            public long abs(long x)
                => Math.Abs(x);

            [MethodImpl(Inline)]
            public BigInteger abs(BigInteger x)
                => BigInteger.Abs(x);

            [MethodImpl(Inline)]
            public float abs(float x)
                => MathF.Abs(x);

            [MethodImpl(Inline)]
            public decimal abs(decimal x)
                => Math.Abs(x);

            [MethodImpl(Inline)]
            public double abs(double x)
                => Math.Abs(x);

            [MethodImpl(Inline)]
            public uint abs(uint x)
                => x;

            [MethodImpl(Inline)]
            public ulong abs(ulong x)
                => x;
        }        

    }

}}