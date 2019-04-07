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
        public readonly struct Bitwise : 
            Bitwise<byte>, 
            Bitwise<sbyte>, 
            Bitwise<short>, 
            Bitwise<ushort>, 
            Bitwise<int>, 
            Bitwise<uint>,
            Bitwise<long>, 
            Bitwise<ulong>,
            Bitwise<float>, 
            Bitwise<double>, 
            Bitwise<decimal>,
            Bitwise<BigInteger>
                
        {
            static readonly Bitwise Inhabitant = default;

            [MethodImpl(Inline)]
            public static Bitwise<T> Operator<T>() 
                => cast<Bitwise<T>>(Inhabitant);

            // !! byte
            // !! -------------------------------------------------------------
            [MethodImpl(Inline)]   
            public byte and(byte a, byte b) 
                => (byte)(a & b);

            [MethodImpl(Inline)]   
            public byte or(byte a, byte b) 
                => (byte)(a | b);

            [MethodImpl(Inline)]   
            public byte xor(byte a, byte b) 
                => (byte)(a ^ b);

            [MethodImpl(Inline)]   
            public byte lshift(byte a, int shift) 
                => (byte)(a << shift);

            [MethodImpl(Inline)]   
            public byte rshift(byte a, int shift) 
                => (byte)(a >> shift);

            [MethodImpl(Inline)]   
            public byte flip(byte a) 
                => (byte)~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(byte a) 
                => zcore.bitstring(a);

            // !! sbyte
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public sbyte and(sbyte a, sbyte b) 
                => (sbyte)(a & b);

            [MethodImpl(Inline)]   
            public sbyte or(sbyte a, sbyte b) 
                => (sbyte)(a | b);

            [MethodImpl(Inline)]   
            public sbyte xor(sbyte a, sbyte b) 
                => (sbyte)(a ^ b);

            [MethodImpl(Inline)]   
            public sbyte lshift(sbyte a, int shift) 
                => (sbyte)(a << shift);

            [MethodImpl(Inline)]   
            public sbyte rshift(sbyte a, int shift) 
                => (sbyte)(a >> shift);

            [MethodImpl(Inline)]   
            public sbyte flip(sbyte a) 
                => (sbyte)~ a;
            
            [MethodImpl(Inline)]   
            public BitString bitstring(sbyte a) 
                => zcore.bitstring(a);

            // !! short
            // !! -------------------------------------------------------------
            
            [MethodImpl(Inline)]   
            public short and(short a, short b) 
                => (short)(a & b);

            [MethodImpl(Inline)]   
            public short or(short a, short b) 
                => (short)(a | b);

            [MethodImpl(Inline)]   
            public short xor(short a, short b) 
                => (short)(a ^ b);

            [MethodImpl(Inline)]   
            public short lshift(short a, int shift) 
                => (short)(a << shift);

            [MethodImpl(Inline)]   
            public short rshift(short a, int shift) 
                => (short)(a >> shift);

            [MethodImpl(Inline)]   
            public short flip(short a) 
                => (short)~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(short a) 
                => zcore.bitstring(a);

            // !! ushort
            // !! -------------------------------------------------------------
            
            [MethodImpl(Inline)]   
            public ushort and(ushort a, ushort b) 
                => (ushort)(a & b);

            [MethodImpl(Inline)]   
            public ushort or(ushort a, ushort b) 
                => (ushort)(a | b);

            [MethodImpl(Inline)]   
            public ushort xor(ushort a, ushort b) 
                => (ushort)(a ^ b);

            [MethodImpl(Inline)]   
            public ushort lshift(ushort a, int shift) 
                => (ushort)(a << shift);

            [MethodImpl(Inline)]   
            public ushort rshift(ushort a, int shift) 
                => (ushort)(a >> shift);

            [MethodImpl(Inline)]   
            public ushort flip(ushort a) 
                => (ushort)~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(ushort a) 
                => zcore.bitstring(a);


            // !! int
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public int and(int a, int b) 
                => a & b;

            [MethodImpl(Inline)]   
            public int or(int a, int b) 
                => a | b;

            [MethodImpl(Inline)]   
            public int xor(int a, int b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public int lshift(int a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public int rshift(int a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public int flip(int a) 
                => ~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(int a) 
                => zcore.bitstring(a);

            // !! uint
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public uint and(uint a, uint b) 
                => a & b;

            [MethodImpl(Inline)]   
            public uint or(uint a, uint b) 
                => a | b;

            [MethodImpl(Inline)]   
            public uint xor(uint a, uint b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public uint lshift(uint a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public uint rshift(uint a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public uint flip(uint a) 
                => ~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(uint a) 
                => zcore.bitstring(a);

            // !! long
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public long and(long a, long b) 
                => a & b;

            [MethodImpl(Inline)]   
            public long or(long a, long b) 
                => a | b;

            [MethodImpl(Inline)]   
            public long xor(long a, long b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public long lshift(long a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public long rshift(long a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public long flip(long a) 
                => ~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(long a) 
                => zcore.bitstring(a);


            // !! ulong
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public ulong and(ulong a, ulong b) 
                => a & b;

            [MethodImpl(Inline)]   
            public ulong or(ulong a, ulong b) 
                => a | b;

            [MethodImpl(Inline)]   
            public ulong xor(ulong a, ulong b) 
                => a ^ b;

            [MethodImpl(Inline)]   
            public ulong lshift(ulong a, int shift) 
                => a << shift;

            [MethodImpl(Inline)]   
            public ulong rshift(ulong a, int shift) 
                => a >> shift;

            [MethodImpl(Inline)]   
            public ulong flip(ulong a) 
                => ~ a;

            [MethodImpl(Inline)]   
            public BitString bitstring(ulong a) 
                => zcore.bitstring(a);

            // !! float
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public float and(float lhs, float rhs)
                => (int)lhs & (int)rhs;

            [MethodImpl(Inline)]   
            public float or(float lhs, float rhs)
                => (int)lhs | (int)rhs;

            [MethodImpl(Inline)]   
            public float xor(float lhs, float rhs)
                => (int)lhs ^ (int)rhs;

            [MethodImpl(Inline)]   
            public float flip(float x)
                => ~(int)x;

            [MethodImpl(Inline)]   
            public float lshift(float lhs, int rhs)
                => (int)lhs << rhs;

            [MethodImpl(Inline)]   
            public float rshift(float lhs, int rhs)
                => (int)lhs >> rhs;

            [MethodImpl(Inline)]   
            public BitString bitstring(float a) 
                => zcore.bitstring(a);

            // !! double
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public double and(double lhs, double rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public double or(double lhs, double rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public double xor(double lhs, double rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public double flip(double x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public double lshift(double lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public double rshift(double lhs, int rhs)
                => (long)lhs >> rhs;

            [MethodImpl(Inline)]   
            public BitString bitstring(double a) 
                => zcore.bitstring(a);


            // !! decimal
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public decimal and(decimal lhs, decimal rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public decimal or(decimal lhs, decimal rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public decimal xor(decimal lhs, decimal rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public decimal flip(decimal x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public decimal lshift(decimal lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public decimal rshift(decimal lhs, int rhs)
                => (long)lhs >> rhs;

            [MethodImpl(Inline)]   
            public BitString bitstring(decimal a) 
                => zcore.bitstring(a);

    
            // !! BigInteger
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public BigInteger and(BigInteger lhs, BigInteger rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public BigInteger or(BigInteger lhs, BigInteger rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public BigInteger xor(BigInteger lhs, BigInteger rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public BigInteger lshift(BigInteger lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public BigInteger rshift(BigInteger lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public BigInteger flip(BigInteger x) 
                => ~ x;

            [MethodImpl(Inline)]   
            public BitString bitstring(BigInteger a) 
                => zcore.bitstring(a);

        }

    }
}}