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
        /// <summary>
        /// Function grab-bag
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface ISpecialOps<T>
        {
            /// <summary>
            /// Computes the square root of the operand, truncating as 
            /// necessary to conform to the characteristics of the 
            /// primitive
            /// </summary>
            /// <param name="src">The source value</param>
            T sqrt(T src);

            /// <summary>
            /// Given x:T, computes the smallest whole number y:T  such that x >= y
            /// </summary>
            /// <param name="src">The source value</param>
            /// <returns></returns>
            T floor(T src);

            T ceiling(T src);

            T pow(T src, int exp);

            T fact(T src);
        }
    }
    
    partial class PrimOps { partial class Reify
    {
        public readonly struct Special : 
            ISpecialOps<byte>, 
            ISpecialOps<sbyte>, 
            ISpecialOps<short>, 
            ISpecialOps<ushort>, 
            ISpecialOps<int>, 
            ISpecialOps<uint>, 
            ISpecialOps<long>, 
            ISpecialOps<ulong>, 
            ISpecialOps<float>, 
            ISpecialOps<double>, 
            ISpecialOps<decimal>,
            ISpecialOps<BigInteger>
        {
            public static readonly Special Inhabitant = default;
            
            [MethodImpl(Inline)]
            public static ISpecialOps<T> Operator<T>() 
                => cast<ISpecialOps<T>>(Inhabitant);

            // ! sbyte
            // ! --------------------------------------------------------------

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
            public sbyte pow(sbyte @base, int exp)
            {
                var result = 1;
                for(var i= 0; i<exp; i++)
                    result =  result * @base;
                return (sbyte)result;
            }

            [MethodImpl(Inline)]
            public sbyte fact(sbyte src)
            {
                var result = (sbyte)1;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! byte
            // ! --------------------------------------------------------------

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
            public byte pow(byte @base, int exp)
            {
                var result = 1;
                for(var i= 0; i<exp; i++)
                    result =  result * @base;
                return (byte)result;
            }

            [MethodImpl(Inline)]
            public byte fact(byte src)
            {
                var result = (byte)1;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! short
            // ! --------------------------------------------------------------

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
            public short pow(short @base, int exp)
            {
                var result = 1;
                for(var i= 0; i<exp; i++)
                    result =  result * @base;
                return (short)result;
            }

            [MethodImpl(Inline)]
            public short fact(short src)
            {
                var result = (short)1;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! ushort
            // ! --------------------------------------------------------------

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
            public ushort pow(ushort @base, int exp)
            {
                var result = 1;
                for(var i= 0; i<exp; i++)
                    result =  result * @base;
                return (ushort)result;
            }

            [MethodImpl(Inline)]
            public ushort fact(ushort src)
            {
                var result = (ushort)1;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! int
            // ! --------------------------------------------------------------

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
            public int pow(int @base, int exp)
            {
                var result = 1;
                for(var i= 0; i<exp; i++)
                    result = result * @base;
                return result;
            }

            [MethodImpl(Inline)]
            public int fact(int src)
            {
                var result = 1;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! uint
            // ! --------------------------------------------------------------

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
            public uint pow(uint @base, int exp)
            {
                var result = 1u;
                for(var i= 0; i<exp; i++)
                    result = result * @base;
                return result;
            }

            [MethodImpl(Inline)]
            public uint fact(uint src)
            {
                var result = 1u;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! long
            // ! --------------------------------------------------------------

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
            public long pow(long @base, int exp)
            {
                var result = 1L;
                for(var i= 0; i<exp; i++)
                    result = result * @base;
                return result;
            }

            [MethodImpl(Inline)]
            public long fact(long src)
            {
                var result = 1L;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }


            // ! ulong
            // ! --------------------------------------------------------------

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
            public ulong pow(ulong @base, int exp)
            {
                var result = 1UL;
                for(var i= 0; i<exp; i++)
                    result = result * @base;
                return result;
            }

            [MethodImpl(Inline)]
            public ulong fact(ulong src)
            {
                var result = 1UL;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }

            // ! float
            // ! --------------------------------------------------------------

            [MethodImpl(Inline)]
            public float sqrt(float src)
                => MathF.Sqrt(src);

            [MethodImpl(Inline)]
            public float ceiling(float src)
                => MathF.Ceiling(src);

            [MethodImpl(Inline)]
            public float floor(float src)
                => MathF.Floor(src);

            [MethodImpl(Inline)]
            public float pow(float src, int exp)
                => MathF.Pow(src,exp);

            [MethodImpl(Inline)]
            public float fact(float src)
            {
                var result = 1f;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }


            // ! double
            // ! --------------------------------------------------------------

            [MethodImpl(Inline)]
            public double sqrt(double src)
                => Math.Sqrt(src);

            [MethodImpl(Inline)]
            public double ceiling(double src)
                => Math.Ceiling(src);

            [MethodImpl(Inline)]
            public double floor(double src)
                => Math.Floor(src);

            [MethodImpl(Inline)]
            public double pow(double src, int exp)
                => Math.Pow(src,exp);

            [MethodImpl(Inline)]
            public double fact(double src)
            {
                var result = 1d;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }


            // ! decimal
            // ! --------------------------------------------------------------
            
            [MethodImpl(Inline)]   
            public decimal sqrt(decimal x)
                => (decimal)Math.Sqrt((double)x);

            [MethodImpl(Inline)]   
            public decimal ceiling(decimal x)
                => decimal.Ceiling(x);

            [MethodImpl(Inline)]   
            public decimal floor(decimal x)
                => decimal.Floor(x);

            [MethodImpl(Inline)]
            public decimal pow(decimal b, int exp)
                => (decimal)Math.Pow((double)b, exp);

            [MethodImpl(Inline)]
            public decimal fact(decimal src)
            {
                var result = 1m;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }


            // ! BigInteger
            // ! --------------------------------------------------------------

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
                => BigInteger.Pow(b,exp);

            [MethodImpl(Inline)]
            public BigInteger fact(BigInteger src)
            {
                var result = BigInteger.One;
                for(var i = src; i>=1; i--)
                    result *=i;
                return result;
            }


        }

    }
}}
