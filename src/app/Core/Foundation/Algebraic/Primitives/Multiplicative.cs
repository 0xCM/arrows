//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {

        /// <summary>
        /// Characterizes operational multiplication
        /// </summary>
        /// <typeparam name="T">The type subject to multiplication</typeparam>
        public interface Multiplicative<T> : BinaryOp<T>
        {
            T mul(T a, T b);

        }

        /// <summary>
        /// Characterizes structural multiplication
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