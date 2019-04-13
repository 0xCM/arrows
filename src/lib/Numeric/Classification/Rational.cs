//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    partial class Operative
    {
        
        /// <summary>
        /// Characterizes fractional operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Fractional<T> : RealNumber<T> 
            where T : struct, IEquatable<T>
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
            where T : struct, IEquatable<T>, Integer<T>
            where R : struct, IEquatable<R>


        {
            T over(R x);

            T under(R x);

            (T over, T under) paired(R x);
        }


    }

    partial class Structures
    {
         public interface Fractional<S> : RealNumber<S> 
            where S : Fractional<S>, new()
         {
            S ceiling();
            
            S floor();

         }

        /// <summary>
        /// Characterizes a fractional structure
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Fractional<S,T> : Fractional<S>, RealNumber<S,T> 
            where S : Fractional<S,T>, new()
        {

            
        }

        public interface Rational<T>
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
        
        public interface Rational<T,R> : Rational<T>
        {

        }

        /// <summary>
        /// Charactrizes a rational number
        /// </summary>
        public interface Rational<S, T, R> : Rational<T,R>
            where S : Rational<S,T,R>,  new()
        {
        }

    }
}