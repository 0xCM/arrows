//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Traits;

    public static class Multiplication 
    {
        public static Multiplication<T> define<T>(Multiplicative<T> x)
            => Multiplication<T>.define(x);
    }

    /// <summary>
    /// Reification of multiplication as a binary applicative
    /// </summary>
    public readonly struct Multiplication<T> : Multiplicative<T>, BinaryApply<T>
    {
        [MethodImpl(Inline)]
        public static Multiplication<T> define(Multiplicative<T> muliplier)
            => new Multiplication<T>(muliplier);

        readonly Traits.Multiplicative<T> effector;
        
        [MethodImpl(Inline)]    
        public Multiplication(Traits.Multiplicative<T> effector)
            => this.effector = effector;

        [MethodImpl(Inline)]    
        public T mul(T lhs, T rhs)
            => effector.mul(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.mul(lhs,rhs);

    }

    partial class Traits
    {

        /// <summary>
        /// Characterizes operational multiplication
        /// </summary>
        /// <typeparam name="T">The type subject to multiplication</typeparam>
        public interface Multiplicative<T> : BinaryOp<T>
        {
            T mul(T lhs, T rhs);

        }
    

        /// <summary>
        /// Characterizes structural multiplication
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Multiplicative<S,T> : Structure<S,T>
            where S : Multiplicative<S,T>, new()
        {
            S mul(S rhs);

        }
    
    }


}