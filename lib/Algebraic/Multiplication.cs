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


    public static class Multiplication 
    {
        public static Multiplication<T> define<T>(IMultiplicativeOps<T> x)
            => new Multiplication<T>(x);
    }

    /// <summary>
    /// Reification of multiplication as a binary applicative
    /// </summary>
    public readonly struct Multiplication<T> : IMultiplicativeOps<T>, IBinaryApplyOp<T>
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
