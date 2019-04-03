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

    partial class Operative
    {
        public interface Divisive<T>
        {
            T div(T lhs, T rhs);        

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);        

            T mod(T lhs, T rhs);
        }



    }

    partial class Structures
    {
        public interface Divisive<S> : Structure<S>
            where S : Divisive<S>, new()
        {

            S div(S rhs);        

            S gcd(S rhs);

            Quorem<S> divrem(S rhs);        

            S mod(S rhs);
        }

        public interface Divisive<S,T> : Divisive<S>
            where S : Divisive<S,T>, new()
        {

        }
    }

    public readonly struct Divisive 
        : Divisive<sbyte>, Divisive<byte>, 
            Divisive<short>, Divisive<ushort>, 
            Divisive<int>, Divisive<uint>,
            Divisive<long>, Divisive<ulong>,
            Divisive<BigInteger>,
            Divisive<float>, Divisive<double>, 
            Divisive<decimal>
            
    {
        public static Additive Inhabitant = default;

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
            => Quorem.define((sbyte) (lhs / rhs), (sbyte)(lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<byte> divrem(byte lhs, byte rhs)
            => Quorem.define((byte) (lhs / rhs), (byte)(lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<short> divrem(short lhs, short rhs)
            => Quorem.define((short)(lhs / rhs), (short)(lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<ushort> divrem(ushort lhs, ushort rhs)
            => Quorem.define((ushort) (lhs / rhs), (ushort)(lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<int> divrem(int lhs, int rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<uint> divrem(uint lhs, uint rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<long> divrem(long lhs, long rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<ulong> divrem(ulong lhs, ulong rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<float> divrem(float lhs, float rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<double> divrem(double lhs, double rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<decimal> divrem(decimal lhs, decimal rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public Quorem<BigInteger> divrem(BigInteger lhs, BigInteger rhs)
            => Quorem.define((lhs / rhs), (lhs % rhs));

        [MethodImpl(Inline)]
        public sbyte gcd(sbyte lhs, sbyte rhs)
            => throw new NotImplementedException();
        // {
        //     lhs = abs(lhs);
        //     rhs = abs(lhs);
        //     while (rhs != Zero)
        //     {
        //         var rem = mod(lhs,rhs);
        //         lhs = rhs;
        //         rhs = rem;
        //     }
        //     return lhs;
        // }

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

        public ushort gcd(ushort lhs, ushort rhs)
        {
            throw new NotImplementedException();
        }

        public short gcd(short lhs, short rhs)
        {
            throw new NotImplementedException();
        }

        public uint gcd(uint lhs, uint rhs)
        {
            throw new NotImplementedException();
        }

        public ulong gcd(ulong lhs, ulong rhs)
        {
            throw new NotImplementedException();
        }

        public double gcd(double lhs, double rhs)
        {
            throw new NotImplementedException();
        }

        public decimal gcd(decimal lhs, decimal rhs)
        {
            throw new NotImplementedException();
        }

        public BigInteger gcd(BigInteger lhs, BigInteger rhs)
        {
            throw new NotImplementedException();
        }

        public int gcd(int lhs, int rhs)
        {
            throw new NotImplementedException();
        }

        public long gcd(long lhs, long rhs)
        {
            throw new NotImplementedException();
        }

        public float gcd(float lhs, float rhs)
        {
            throw new NotImplementedException();
        }

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