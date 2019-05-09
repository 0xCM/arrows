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
    using static zfunc;

    using static Operative;

    partial class PrimOps { partial class Reify
    {
        public readonly struct Absolutive : 
            IAbsolutiveOps<byte>, 
            IAbsolutiveOps<sbyte>, 
            IAbsolutiveOps<short>, 
            IAbsolutiveOps<ushort>, 
            IAbsolutiveOps<int>, 
            IAbsolutiveOps<uint>, 
            IAbsolutiveOps<long>, 
            IAbsolutiveOps<ulong>, 
            IAbsolutiveOps<float>, 
            IAbsolutiveOps<double>, 
            IAbsolutiveOps<decimal>,
            IAbsolutiveOps<BigInteger>
        {
            static readonly Absolutive Inhabitant = default;
            
            [MethodImpl(Inline)]
            public static IAbsolutiveOps<T> Operator<T>() 
                => cast<IAbsolutiveOps<T>>(Inhabitant);

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