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

    partial class Structures
    {
        
        /// <summary>
        /// Characterizes structural inversion
        /// </summary>
        /// <typeparam name="T">The type over which the structrue is defined</typeparam>
        public interface Invertive<S>
        {
            
        }

        /// <summary>
        /// Characterizes structural multiplicative inversion
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface InvertiveM<S> : Invertive<S>, Multiplicative<S>
            where S : InvertiveM<S>, new()
        {
            /// <summary>
            /// Effects multiplicative inversion
            /// </summary>
            S invertM();
        }

        /// <summary>
        /// Characterizes structural additive inversion
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface InvertiveA<S> : Invertive<S>, Additive<S>
            where S : InvertiveA<S>, new()
        {
            /// <summary>
            /// Effects additive inversion
            /// </summary>
            S invertA();
        }

    }
}
 