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

        public readonly struct Subtractive : 
            Subtractive<byte>, 
            Subtractive<sbyte>, 
            Subtractive<short>, 
            Subtractive<ushort>, 
            Subtractive<int>, 
            Subtractive<uint>, 
            Subtractive<long>,             
            Subtractive<ulong>, 
            Subtractive<float>, 
            Subtractive<double>, 
            Subtractive<decimal>,
            Subtractive<BigInteger>
        {
            static readonly Subtractive Inhabitant = default;

            public static Subtractive<T> Operator<T>() 
                => cast<Subtractive<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public sbyte sub(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs - rhs);

            [MethodImpl(Inline)]
            public byte sub(byte lhs, byte rhs)
                => (byte)(lhs - rhs);

            [MethodImpl(Inline)]
            public short sub(short lhs, short rhs)
                => (short)(lhs - rhs);

            [MethodImpl(Inline)]
            public ushort sub(ushort lhs, ushort rhs)
                => (ushort)(lhs - rhs);

            [MethodImpl(Inline)]
            public int sub(int lhs, int rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public uint sub(uint lhs, uint rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public long sub(long lhs, long rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public ulong sub(ulong lhs, ulong rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public BigInteger sub(BigInteger lhs, BigInteger rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public float sub(float lhs, float rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public double sub(double lhs, double rhs)
                => lhs - rhs;

            [MethodImpl(Inline)]
            public decimal sub(decimal lhs, decimal rhs)
                => lhs - rhs;

        }

    }    
  } 

}