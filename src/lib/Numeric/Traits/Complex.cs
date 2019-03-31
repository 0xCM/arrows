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
        /// Characterizes operations over complex numbers
        /// </summary>
        /// <typeparam name="T">The component type</typeparam>
        /// <typeparam name="C">The operand type</typeparam>
        public interface Complex<T,C> : Number<C>
        {
            
        }

    }


    partial class Structure
    {
        /// <summary>
        /// Characterizes a structure that represents a complex number
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying numeric component type</typeparam>
        /// <typeparam name="C">The complex number type</typeparam>
        public interface Complex<S,T,C> : Number<S,C>
            where S : Complex<S,T,C>,  new()
        {
            /// <summary>
            /// The real part
            /// </summary>
            /// <value></value>
            T re {get;}

            /// <summary>
            /// The imaginary part
            /// </summary>
            /// <value></value>
            T im {get;}


        }

    }

}