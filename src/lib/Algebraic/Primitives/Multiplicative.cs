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

        /// <summary>
        /// Characterizes operational multiplication
        /// </summary>
        /// <typeparam name="T">The type subject to multiplication</typeparam>
        public interface Multiplicative<T>
        {
            T mul(T lhs, T rhs);
        }    
    }

    partial class Structures
    {

        public interface Multiplicative<S>
            where S : Multiplicative<S>, new()
        {
            S mul(S rhs);
        }

        /// <summary>
        /// Characterizes structural multiplication
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Multiplicative<S,T> : Multiplicative<S>
            where S : Multiplicative<S,T>, new()
        {
            
        }
    }


    public static class Multiplication 
    {
        public static Multiplication<T> define<T>(Operative.Multiplicative<T> x)
            => new Multiplication<T>(x);
    }

    /// <summary>
    /// Reification of multiplication as a binary applicative
    /// </summary>
    public readonly struct Multiplication<T> : Operative.Multiplicative<T>, Operative.BinaryApply<T>
    {
        [MethodImpl(Inline)]
        public static Multiplication<T> define(Operative.Multiplicative<T> muliplier)
            => new Multiplication<T>(muliplier);

        readonly Operative.Multiplicative<T> effector;
        
        [MethodImpl(Inline)]    
        public Multiplication(Operative.Multiplicative<T> effector)
            => this.effector = effector;

        [MethodImpl(Inline)]    
        public T mul(T lhs, T rhs)
            => effector.mul(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.mul(lhs,rhs); 
    }

 
   public readonly struct Multiplicative 
        : Multiplicative<sbyte>, Multiplicative<byte>, 
            Multiplicative<short>, Multiplicative<ushort>, 
            Multiplicative<int>, Multiplicative<uint>,
            Multiplicative<long>, Multiplicative<ulong>,
            Multiplicative<BigInteger>,
            Multiplicative<float>, Multiplicative<double>, 
            Multiplicative<decimal>
            
    {
        public static Additive Inhabitant = default;

       [MethodImpl(Inline)]
        public sbyte mul(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs * rhs);

        [MethodImpl(Inline)]
        public byte mul(byte lhs, byte rhs)
            => (byte)(lhs * rhs);

        [MethodImpl(Inline)]
        public short mul(short lhs, short rhs)
            => (short)(lhs * rhs);
     
        [MethodImpl(Inline)]
        public ushort mul(ushort lhs, ushort rhs)
            => (ushort)(lhs * rhs);

        [MethodImpl(Inline)]
        public int mul(int lhs, int rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public uint mul(uint lhs, uint rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public long mul(long lhs, long rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public ulong mul(ulong lhs, ulong rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public float mul(float lhs, float rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public double mul(double lhs, double rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public decimal mul(decimal lhs, decimal rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public BigInteger mul(BigInteger lhs, BigInteger rhs)
            => lhs * rhs;

    }
} 
