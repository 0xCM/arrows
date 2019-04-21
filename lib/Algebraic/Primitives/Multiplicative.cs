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
} 