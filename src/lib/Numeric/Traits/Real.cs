//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Traits
    {
        /// <summary>
        ///  Conceptually subsumes all aspects of real numbers, 
        ///  and may parameterized by any numeric type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Real<T> : Integer<T>, Floating<T>
        {
            /// <summary>
            /// Specifies whether the operand type is capable of supporing arbitrary
            /// precision arithmetic
            /// </summary>
            bool infinite {get;}

        }

        /// <summary>
        /// Characterizes an extended structual real
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Real<S,T> : IComparable<S>, Real<S>, Structure<S,T>
            where S : Real<S,T>, new()
            
        {

        }

        /// <summary>
        /// Characterizes finite real operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteReal<T> : Bounded<T>, Real<T>
        {

        }


        /// <summary>
        /// Characterizes a stuctural finite real type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface FiniteReal<S,T> : FiniteReal<S>, Structure<S,T>
            where S : FiniteReal<S,T>, new()
        {

        }
    }


}