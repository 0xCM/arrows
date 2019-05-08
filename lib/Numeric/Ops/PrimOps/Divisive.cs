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
        public readonly struct Divisive : 
            IDivisiveOps<byte>, 
            IDivisiveOps<sbyte>, 
            IDivisiveOps<short>,
            IDivisiveOps<ushort>, 
            IDivisiveOps<int>,
            IDivisiveOps<uint>,
            IDivisiveOps<long>,
            IDivisiveOps<ulong>,            
            IDivisiveOps<float>,
            IDivisiveOps<double>, 
            IDivisiveOps<decimal>,
            IDivisiveOps<BigInteger>                
        {
            static readonly Divisive Inhabitant = default;

            [MethodImpl(Inline)]
            public static IDivisiveOps<T> Operator<T>() 
                => cast<IDivisiveOps<T>>(Inhabitant);

            [MethodImpl(Inline)]
            public byte div(byte lhs, byte rhs)
                => (byte)(lhs / rhs);

            [MethodImpl(Inline)]
            public sbyte div(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs / rhs);

            [MethodImpl(Inline)]
            public ushort div(ushort lhs, ushort rhs)
                => (ushort)(lhs / rhs);

            [MethodImpl(Inline)]
            public short div(short lhs, short rhs)
                => (short)(lhs / rhs);

            [MethodImpl(Inline)]
            public int div(int lhs, int rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public uint div(uint lhs, uint rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public ulong div(ulong lhs, ulong rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public decimal div(decimal lhs, decimal rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public double div(double lhs, double rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public float div(float lhs, float rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public BigInteger div(BigInteger lhs, BigInteger rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public long div(long lhs, long rhs)
                => lhs / rhs;

            [MethodImpl(Inline)]
            public Quorem<sbyte> divrem(sbyte lhs, sbyte rhs)
            {
                var x = Math.Abs(lhs);
                var y = Math.Abs(rhs);
                var quo = div(x, y);
                var rem = (sbyte)(x - quo*y);
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<byte> divrem(byte lhs, byte rhs)
            {
                var quo = div(lhs, rhs);
                var rem = (byte)(lhs - quo*rhs);
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<short> divrem(short lhs, short rhs)
            {
                var x = Math.Abs(lhs);
                var y = Math.Abs(rhs);
                var quo = div(x, y);
                var rem = (short)(x - quo*y);
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<ushort> divrem(ushort lhs, ushort rhs)
            {
                var quo = div(lhs, rhs);
                var rem = (ushort)(lhs - quo*rhs);
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<int> divrem(int lhs, int rhs)
            {
                var x = Math.Abs(lhs);
                var y = Math.Abs(rhs);
                var quo = div(x, y);
                var rem = x - quo*y;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<uint> divrem(uint lhs, uint rhs)
            {
                var quo = div(lhs, rhs);
                var rem = lhs - quo*rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<long> divrem(long lhs, long rhs)
            {
                var x = Math.Abs(lhs);
                var y = Math.Abs(rhs);
                var quo = div(x, y);
                var rem = x - quo*y;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<ulong> divrem(ulong lhs, ulong rhs)
            {
                var quo = div(lhs, rhs);
                var rem = lhs - quo*rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<float> divrem(float lhs, float rhs)
            {
                var quo = div(lhs, rhs);
                var rem = lhs - quo*rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<double> divrem(double lhs, double rhs)
            {
                var quo = div(lhs, rhs);
                var rem = lhs - quo*rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<decimal> divrem(decimal lhs, decimal rhs)
            {
                var quo = div(lhs, rhs);
                var rem = lhs - quo*rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public Quorem<BigInteger> divrem(BigInteger lhs, BigInteger rhs)
            {
                var rem = BigInteger.Zero;
                var div = BigInteger.DivRem(lhs, rhs, out rem);  
                return Quorem.define(div,rem);                  
            }

            [MethodImpl(Inline)]
            public byte gcd(byte lhs, byte rhs)
            {
                while (rhs != 0)
                {
                    var rem = mod(lhs,rhs);
                    lhs = rhs;
                    rhs = rem;
                }
                return lhs;
            }


            [MethodImpl(Inline)]
            public sbyte gcd(sbyte lhs, sbyte rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = (sbyte)(x % y);
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public short gcd(short lhs, short rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = (short)(x % y);
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public ushort gcd(ushort lhs, ushort rhs)
            {
                while (rhs != 0)
                {
                    var rem = mod(lhs,rhs);
                    lhs = rhs;
                    rhs = rem;
                }
                return lhs;
            }

            [MethodImpl(Inline)]
            public ulong gcd(ulong lhs, ulong rhs)
            {
                while (rhs != 0)
                {
                    var rem = mod(lhs,rhs);
                    lhs = rhs;
                    rhs = rem;
                }
                return lhs;
            }

            [MethodImpl(Inline)]
            public double gcd(double lhs, double rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = x % y;
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public decimal gcd(decimal lhs, decimal rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = x % y;
                    x = y;
                    y = rem;
                }
                return x;
            }


            [MethodImpl(Inline)]
            public int gcd(int lhs, int rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = (x % y);
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public uint gcd(uint lhs, uint rhs)
            {
                while (rhs != 0)
                {
                    var rem = mod(lhs,rhs);
                    lhs = rhs;
                    rhs = rem;
                }
                return lhs;
            }

            [MethodImpl(Inline)]
            public long gcd(long lhs, long rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = (x % y);
                    x = y;
                    y = rem;
                }
                return x;
            }


            [MethodImpl(Inline)]
            public float gcd(float lhs, float rhs)
            {
                var x = abs(lhs);
                var y = abs(rhs);
                while (y != 0)
                {
                    var rem = (x % y);
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public BigInteger gcd(BigInteger lhs, BigInteger rhs)
                => BigInteger.GreatestCommonDivisor(lhs,rhs);

            [MethodImpl(Inline)]
            public sbyte mod(sbyte lhs, sbyte rhs)
                => (sbyte)(lhs % rhs);

            [MethodImpl(Inline)]
            public byte mod(byte lhs, byte rhs)
                => (byte)(lhs % rhs);

            [MethodImpl(Inline)]
            public ushort mod(ushort lhs, ushort rhs)
                => (ushort)(lhs % rhs);

            [MethodImpl(Inline)]
            public short mod(short lhs, short rhs)
                => (short)(lhs % rhs);

            [MethodImpl(Inline)]
            public int mod(int lhs, int rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public uint mod(uint lhs, uint rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public long mod(long lhs, long rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public ulong mod(ulong lhs, ulong rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public BigInteger mod(BigInteger lhs, BigInteger rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public float mod(float lhs, float rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public double mod(double lhs, double rhs)
                => lhs % rhs;

            [MethodImpl(Inline)]
            public decimal mod(decimal lhs, decimal rhs)
                => lhs % rhs;
        }    

    }
}}