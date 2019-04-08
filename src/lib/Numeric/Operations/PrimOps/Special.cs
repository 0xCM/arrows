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

    partial class Operative
    {
        public interface Special<T>
        {
            T sqrt(T src);

            T floor(T src);

            T ceiling(T src);

            T pow(T src, int exp);
        }
    }
    
    partial class PrimOps { partial class Reify
    {
        public readonly struct Special : 
            Special<byte>, 
            Special<sbyte>, 
            Special<short>, 
            Special<ushort>, 
            Special<int>, 
            Special<uint>, 
            Special<long>, 
            Special<ulong>, 
            Special<float>, 
            Special<double>, 
            Special<decimal>,
            Special<BigInteger>
        {
            static readonly Special Inhabitant = default;
            
            [MethodImpl(Inline)]
            public static Special<T> Operator<T>() 
                => cast<Special<T>>(Inhabitant);

            // ! sbyte

            [MethodImpl(Inline)]   
            public sbyte sqrt(sbyte x)
                => (sbyte)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public sbyte ceiling(sbyte x)
                => x;

            [MethodImpl(Inline)]   
            public sbyte floor(sbyte x)
                => x;

            [MethodImpl(Inline)]   
            public sbyte pow(sbyte b, int exp) 
                => fold(repeat(b,exp),(x,y) => (sbyte) (x*y), (sbyte)1);


            // ! sbyte

            [MethodImpl(Inline)]   
            public byte sqrt(byte x)
                => (byte)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public byte ceiling(byte x)
                => x;

            [MethodImpl(Inline)]   
            public byte floor(byte x)
                => x;

            [MethodImpl(Inline)]   
            public byte pow(byte b, int exp) 
                => fold(repeat(b,exp),(x,y) => (byte) (x*y), (byte)1);


            // ! short

            [MethodImpl(Inline)]   
            public short sqrt(short x)
                => (short)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public short ceiling(short x)
                => x;

            [MethodImpl(Inline)]   
            public short floor(short x)
                => x;

            [MethodImpl(Inline)]   
            public short pow(short b, int exp) 
                => fold(repeat(b,exp),(x,y) => (short) (x*y), (short)1);


            // ! ushort

            [MethodImpl(Inline)]   
            public ushort sqrt(ushort x)
                => (ushort)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public ushort ceiling(ushort x)
                => x;

            [MethodImpl(Inline)]   
            public ushort floor(ushort x)
                => x;

            [MethodImpl(Inline)]   
            public ushort pow(ushort b, int exp) 
                => fold(repeat(b,exp),(x,y) => (ushort) (x*y), (ushort)1);


            // ! int

            [MethodImpl(Inline)]   
            public int sqrt(int x)
                => (int)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public int ceiling(int x)
                => x;

            [MethodImpl(Inline)]   
            public int floor(int x)
                => x;

            [MethodImpl(Inline)]   
            public int pow(int b, int exp) 
                => fold(repeat(b,exp),(x,y) => x*y, 1);


            // ! uint

            [MethodImpl(Inline)]   
            public uint sqrt(uint x)
                => (uint)MathF.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public uint ceiling(uint x)
                => x;

            [MethodImpl(Inline)]   
            public uint floor(uint x)
                => x;

            [MethodImpl(Inline)]   
            public uint pow(uint b, int exp) 
                => fold(repeat(b,exp),(x,y) => x*y, 1u);

            // ! long

            [MethodImpl(Inline)]   
            public long sqrt(long x)
                => (long)Math.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public long ceiling(long x)
                => x;

            [MethodImpl(Inline)]   
            public long floor(long x)
                => x;

            [MethodImpl(Inline)]   
            public long pow(long b, int exp) 
                => fold(repeat(b,exp),(x,y) => x*y, 1L);

            // ! ulong

            [MethodImpl(Inline)]   
            public ulong sqrt(ulong x)
                => (ulong)Math.Sqrt(x);
    
            [MethodImpl(Inline)]   
            public ulong ceiling(ulong x)
                => x;

            [MethodImpl(Inline)]   
            public ulong floor(ulong x)
                => x;

            [MethodImpl(Inline)]   
            public ulong pow(ulong b, int exp) 
                => fold(repeat(b,exp),(x,y) => x*y, 1UL);


            // ! float

            [MethodImpl(Inline)]
            public float sqrt(float src)
                => MathF.Sqrt(src);

            [MethodImpl(Inline)]
            public float pow(float src, int exp)
                => MathF.Pow(src,exp);

            [MethodImpl(Inline)]
            public float ceiling(float src)
                => MathF.Ceiling(src);

            [MethodImpl(Inline)]
            public float floor(float src)
                => MathF.Floor(src);

            // ! double
            [MethodImpl(Inline)]
            public double sqrt(double src)
                => Math.Sqrt(src);

            [MethodImpl(Inline)]
            public double pow(double src, int exp)
                => Math.Pow(src,exp);

            [MethodImpl(Inline)]
            public double ceiling(double src)
                => Math.Ceiling(src);

            [MethodImpl(Inline)]
            public double floor(double src)
                => Math.Floor(src);


            // ! decimal

            [MethodImpl(Inline)]   
            public decimal sqrt(decimal x)
                => (decimal)Math.Sqrt((double)x);

            [MethodImpl(Inline)]
            public decimal pow(decimal b, int exp)
                => (decimal)Math.Pow((double)b, exp);

            [MethodImpl(Inline)]   
            public decimal ceiling(decimal x)
                => decimal.Ceiling(x);

            [MethodImpl(Inline)]   
            public decimal floor(decimal x)
                => decimal.Floor(x);


            // ! BigInteger

            [MethodImpl(Inline)]   
            public BigInteger sqrt(BigInteger x)
                => (BigInteger)Math.Sqrt((double)x);
    
            [MethodImpl(Inline)]   
            public BigInteger ceiling(BigInteger x)
                => x;

            [MethodImpl(Inline)]   
            public BigInteger floor(BigInteger x)
                => x;

            [MethodImpl(Inline)]   
            public BigInteger pow(BigInteger b, int exp) 
                => fold(repeat(b,exp),(x,y) => x*y, BigInteger.One);

        }

    }
}}
