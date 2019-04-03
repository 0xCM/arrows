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
        /// Characterizes a type that defines a notion of commutative additivity
        /// </summary>
        /// <typeparam name="T">The type subject to addition</typeparam>
        public interface Additive<T>
        {

            /// <summary>
            /// Alias for commutative semigroup composition operator
            /// </summary>
            /// <param name="lhs">The first element</param>
            /// <param name="rhs">The second element</param>
            T add(T lhs, T rhs);                    
        }
    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a structure that supports semigroup additivity
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Additive<S> : Structure<S>
            where S : Additive<S>, new()
        {
            S add(S rhs);
        }

        /// <summary>
        /// Characterizes an additive structure S parameterized by 
        /// a type T 
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Additive<S,T> : Additive<S>
            where S : Additive<S,T>, new()
        {
        }
    }
 
    /// <summary>
    /// Reification of addition as a binary applicative
    /// </summary>
    public readonly struct Addition<T> : Additive<T>, BinaryApply<T>
        where T : Operative.Additive<T>, new()
    {
        static readonly Addition<T> effector = default;
        

        [MethodImpl(Inline)]    
        public T add(T lhs, T rhs)
            => effector.add(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.add(lhs,rhs);
    }


    public readonly struct Additive 
        : Additive<sbyte>, Additive<byte>, 
            Additive<short>, Additive<ushort>, 
            Additive<int>, Additive<uint>,
            Additive<long>, Additive<ulong>,
            Additive<BigInteger>,
            Additive<float>, Additive<double>, 
            Additive<decimal>
            
    {
        public static Additive Inhabitant = default;

        [MethodImpl(Inline)]
        public byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        public sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        public ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        public short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        public int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public uint add(uint lhs, uint rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public decimal add(decimal lhs, decimal rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public double add(double lhs, double rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public float add(float lhs, float rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public BigInteger add(BigInteger lhs, BigInteger rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public long add(long lhs, long rhs)
            => lhs + rhs;
    }
}