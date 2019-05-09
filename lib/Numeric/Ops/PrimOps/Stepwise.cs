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
    using static zfunc;

    using static Operative;

    partial class PrimOps { partial class Reify {

        public readonly struct Stepwise : 
            IStepwiseOps<byte>, 
            IStepwiseOps<sbyte>, 
            IStepwiseOps<short>, 
            IStepwiseOps<ushort>, 
            IStepwiseOps<int>, 
            IStepwiseOps<uint>, 
            IStepwiseOps<long>,             
            IStepwiseOps<ulong>, 
            IStepwiseOps<float>, 
            IStepwiseOps<double>, 
            IStepwiseOps<decimal>,
            IStepwiseOps<BigInteger>
        {
            static readonly Stepwise Inhabitant = default;

            [MethodImpl(Inline)]
            public static IStepwiseOps<T> Operator<T>() 
                => cast<IStepwiseOps<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte inc(byte x)
                => ++x;

            [MethodImpl(Inline)]
            public sbyte inc(sbyte x)
                => ++x;

            [MethodImpl(Inline)]
            public short inc(short x)
                => ++x;

            [MethodImpl(Inline)]
            public ushort inc(ushort x)
                => ++x;

            [MethodImpl(Inline)]
            public int inc(int x)
                => ++x;

            [MethodImpl(Inline)]
            public uint inc(uint x)
                => ++x;

            [MethodImpl(Inline)]
            public long inc(long x)
                => ++x;

            [MethodImpl(Inline)]
            public ulong inc(ulong x)
                => ++x;

            [MethodImpl(Inline)]
            public double inc(double x)
                => ++x;

            [MethodImpl(Inline)]
            public float inc(float x)
                => ++x;

            [MethodImpl(Inline)]
            public decimal inc(decimal x)
                => ++x;

            [MethodImpl(Inline)]
            public BigInteger inc(BigInteger x)
                => ++x;

            [MethodImpl(Inline)]
            public byte dec(byte x)
                => --x;

            [MethodImpl(Inline)]
            public sbyte dec(sbyte x)
                => --x;

            [MethodImpl(Inline)]
            public short dec(short x)
                => --x;

            [MethodImpl(Inline)]
            public ushort dec(ushort x)
                => --x;

            [MethodImpl(Inline)]
            public int dec(int x)
                => --x;

            [MethodImpl(Inline)]
            public uint dec(uint x)
                => --x;

            [MethodImpl(Inline)]
            public long dec(long x)
                => --x;

            [MethodImpl(Inline)]
            public ulong dec(ulong x)
                => --x;

            [MethodImpl(Inline)]
            public double dec(double x)
                => --x;

            [MethodImpl(Inline)]
            public float dec(float x)
                => --x;

            [MethodImpl(Inline)]
            public decimal dec(decimal x)
                => --x;

            [MethodImpl(Inline)]
            public BigInteger dec(BigInteger x)
                => --x;
 
            [MethodImpl(Inline)]
            public byte inc(byte x, ref byte y)
                => y = ++x;

            [MethodImpl(Inline)]
            public sbyte inc(sbyte x, ref sbyte y)
                => y = ++x;

            [MethodImpl(Inline)]
            public short inc(short x, ref short y)
                => y = ++x;

            [MethodImpl(Inline)]
            public ushort inc(ushort x, ref ushort y)
                => y = ++x;

            [MethodImpl(Inline)]
            public int inc(int x, ref int y)
                => y = ++x;

            [MethodImpl(Inline)]
            public uint inc(uint x, ref uint y)
                => y = ++x;

            [MethodImpl(Inline)]
            public long inc(long x, ref long y)
                => y = ++x;

            [MethodImpl(Inline)]
            public ulong inc(ulong x, ref ulong y)
                => y = ++x;

            [MethodImpl(Inline)]
            public float inc(float x, ref float y)
                => y = ++x;

            [MethodImpl(Inline)]
            public double inc(double x, ref double y)
                => y = ++x;

            [MethodImpl(Inline)]
            public decimal inc(decimal x, ref decimal y)
                => y = ++x;

            [MethodImpl(Inline)]
            public BigInteger inc(BigInteger x, ref BigInteger y)
                => y = ++x;

        }

    }
}}