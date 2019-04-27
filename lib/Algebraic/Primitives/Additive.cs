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
        /// Characterizes a type for which commutative additivity can be defined
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Additive<T> : Commutative<T>
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
        public interface Additive<S> : Commutative<S>
            where S : Additive<S>, new()
        {
            S add(S rhs);
        }

    }

}