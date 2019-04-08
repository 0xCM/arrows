//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;


    partial class Structures
    {
        /// <summary>
        /// Characterizes a structure that represents a complex number
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        /// <typeparam name="T">The underlying numeric component type</typeparam>
        /// <typeparam name="C">The complex number type</typeparam>
        public interface Complex<S,T,C> : Number<S>
            where S : struct, Complex<S,T,C>, IEquatable<S>  
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