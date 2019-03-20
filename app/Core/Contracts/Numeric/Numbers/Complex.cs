//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;


    partial class Class
    {

        public interface Complex<T> : Number<T>
            where T : Complex<T>,  new()
        {
            
        }

    }

    partial class Struct
    {

        /// <summary>
        /// Characterizes a complex number
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public interface Complex<S,T> : Number<S,T>
            where S : Complex<S,T>, new()
            where T : new()
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