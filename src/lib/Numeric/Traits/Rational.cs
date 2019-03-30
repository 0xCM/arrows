//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    partial class Traits
    {
        
        /// <summary>
        /// Characterizes fractional operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Fractional<T> : RealNumber<T> 
        {
            T ceiling(T x);
            
            T floor(T x);

            
        }
        
        /// <summary>
        /// Characterizes operations over a numeric rational type R
        /// with integeral component type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="R"></typeparam>
        public interface Rational<T,R> : Reciprocative<R>, Fractional<R>
            where T : Integer<T>
        {
            T over(R x);

            T under(R x);

            (T over, T under) paired(R x);
        }


    }

    partial class Structure
    {
        /// <summary>
        /// Charactrizes a rational number
        /// </summary>
        public interface Rational<S, T, R> //: Reciprocative<T,R>
            where S : Rational<S,T,R>,  new()
        {
            /// <summary>
            /// The dividend
            /// </summary>
            T over();

            /// <summary>
            /// The divisor
            /// </summary>
            T under();

            (T over, T under) paired();
        }

    }
}