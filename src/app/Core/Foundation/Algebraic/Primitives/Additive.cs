//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using static Traits;


    public static class Addition 
    {
        public static Addition<T> define<T>(Additive<T> x)
            => Addition<T>.define(x);
    }

    /// <summary>
    /// Reification of addition as a binary applicative
    /// </summary>
    public readonly struct Addition<T> : Additive<T>, BinaryApply<T>
    {
        [MethodImpl(Inline)]
        public static Addition<T> define(Additive<T> effector)
            => new Addition<T>(effector);

        readonly Traits.Additive<T> effector;
        
        [MethodImpl(Inline)]    
        public Addition(Additive<T> effector)
            => this.effector = effector;

        [MethodImpl(Inline)]    
        public T add(T lhs, T rhs)
            => effector.add(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.add(lhs,rhs);
    }

    partial class Traits
    {
        /// <summary>
        /// Characterizes a type that defines a notion of additivity
        /// </summary>
        /// <typeparam name="T">The type subject to addition</typeparam>
        public interface Additive<T> : BinaryOp<T>
        {

            /// <summary>
            /// Alias for the group composition operator in the commutative context
            /// </summary>
            /// <param name="lhs">The first element</param>
            /// <param name="rhs">The second element</param>
            /// <returns></returns>
            T add(T lhs, T rhs);
            
            
        }

        public interface Additive<S,T> : Structure<S,T>
            where S : Additive<S,T>, new()
        {
            S add(S rhs);
        }


    }


}