//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    partial class Traits
    {

        /// <summary>
        /// Characterizes operational invertivity
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Invertive<T>
        {
            T invert(T x);                
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

}
