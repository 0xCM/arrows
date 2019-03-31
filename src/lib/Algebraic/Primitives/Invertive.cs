//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Operative
    {

        /// <summary>
        /// Characterizes operational inversion
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Invertive<T>
        {

        }


        /// <summary>
        /// Characterizes operational multiplicative inversion
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InvertiveM<T> : Invertive<T>
        {
            T invertM(T x);
        }

        /// <summary>
        /// Characterizes operational additive inversion
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface InvertiveA<T> : Invertive<T>
        {
            T invertA(T x);
        }

    }

    partial class Structure
    {
        
        /// <summary>
        /// Characterizes structural inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Invertive<S>
        {
            
        }

        /// <summary>
        /// Characterizes structural multiplicative inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface InvertiveM<S> : Invertive<S>
        {
            /// <summary>
            /// Effects multiplicative inversion
            /// </summary>
            S invertM();
        }

        /// <summary>
        /// Characterizes structural multiplicative inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface InvertiveA<S> : Invertive<S>
        {
            /// <summary>
            /// Effects additive inversion
            /// </summary>
            S invertA();
        }


        /// <summary>
        /// Characterizes structural inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Invertive<S,T> : Invertive<S>, Structural<S,T>
            where S : Invertive<S,T>, new()
        {

        }

        /// <summary>
        /// Characterizes structural multiplicative inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface InvertiveM<S,T> : InvertiveM<S>, Invertive<S,T>
            where S : InvertiveM<S,T>, new()
        {

        }



        /// <summary>
        /// Characterizes structural additive inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        /// <typeparam name="S">The structure type</typeparam>
        public interface InvertiveA<S,T> : InvertiveA<S>, Invertive<S,T>
            where S : InvertiveA<S,T>, new()
        {

        }
    }
}
 