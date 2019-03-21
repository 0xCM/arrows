//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Class
    {

        /// <summary>
        /// Characterizes a type that defines a notion of additivity
        /// </summary>
        /// <typeparam name="T">The type subject to multiplication</typeparam>
        public interface Multiplicative<T> : BinaryOp<T>, TypeClass
        {
            T mul(T a, T b);

        }

        /// <summary>
        /// Characterizes a type that defines a notion of additivity
        /// </summary>
        /// <typeparam name="T">The type subject to multiplication</typeparam>
        public interface Multiplicative<H,T> : TypeClass<H>, Multiplicative<T>
            where H : Multiplicative<H,T>, new()
        {

        }
    
    }

    partial class Struct
    {

        /// <summary>
        /// Characterizes structural multiplicativity
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The individual type</typeparam>
        public interface Multiplicative<S,T> : Structure<S,T>
            where S : Multiplicative<S,T>, new()
        {
            S mul(S a);

        }

    }

}