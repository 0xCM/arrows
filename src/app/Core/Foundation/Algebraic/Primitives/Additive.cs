//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using static corefunc;

    partial class Class
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