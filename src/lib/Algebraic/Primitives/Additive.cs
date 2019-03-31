//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Traits;


    public static class Addition 
    {
        public static Addition<T> define<T>(Operative.Additive<T> x)
            => Addition<T>.define(x);
    }

    /// <summary>
    /// Reification of addition as a binary applicative
    /// </summary>
    public readonly struct Addition<T> : Operative.Additive<T>, Operative.BinaryApply<T>
    {
        [MethodImpl(Inline)]
        public static Addition<T> define(Operative.Additive<T> effector)
            => new Addition<T>(effector);

        readonly Operative.Additive<T> effector;
        
        [MethodImpl(Inline)]    
        public Addition(Operative.Additive<T> effector)
            => this.effector = effector;

        [MethodImpl(Inline)]    
        public T add(T lhs, T rhs)
            => effector.add(lhs,rhs);

        [MethodImpl(Inline)]    
        public T apply(T lhs, T rhs)
            => effector.add(lhs,rhs);
    }

    partial class Operative
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


    }

    partial class Structure
    {
        public interface Additive<S>
        {
            S add(S rhs);

        }

        public interface Additive<S,T> : Additive<S>, Structural<S,T>
            where S : Additive<S,T>, new()
        {
        }

    }


}