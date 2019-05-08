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

    /// <summary>
    /// Characterizes operational multiplication
    /// </summary>
    /// <typeparam name="T">The type subject to multiplication</typeparam>
    public interface IMultiplicativeOps<T>
    {
        T mul(T lhs, T rhs);
    }    

    public interface IMultiplicative<S>
        where S : IMultiplicative<S>, new()
    {
        S mul(S rhs);
    }

    /// <summary>
    /// Characterizes structural multiplication
    /// </summary>
    /// <typeparam name="S">The structure type</typeparam>
    /// <typeparam name="T">The individual type</typeparam>
    public interface IMultiplicative<S,T> : IMultiplicative<S>
        where S : IMultiplicative<S,T>, new()
    {
        
    }

    public static class Multiplication 
    {
        public static Multiplication<T> define<T>(IMultiplicativeOps<T> x)
            => new Multiplication<T>(x);
    }

    /// <summary>
    /// Reification of multiplication as a binary applicative
    /// </summary>
    public readonly struct Multiplication<T> : IMultiplicativeOps<T>, Operative.BinaryApply<T>
    {
        [MethodImpl(Inline)]
        public static Multiplication<T> define(IMultiplicativeOps<T> muliplier)
            => new Multiplication<T>(muliplier);

        readonly IMultiplicativeOps<T> effector;
        
        [MethodImpl(Inline)]    
        public Multiplication(IMultiplicativeOps<T> effector)
            => this.effector = effector;

        [MethodImpl(Inline)]    
        public T mul(T lhs, T rhs)
            => effector.mul(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.mul(lhs,rhs); 
    } 
} 
