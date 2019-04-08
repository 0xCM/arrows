//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zcore;


    partial class Operative
    {
        /// <summary>
        /// Characterizes a conversion operation, x:S => x:T
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target value</typeparam>
        public interface Conversion<S,T>
        {
            /// <summary>
            /// Converts the source value to a target value
            /// </summary>
            /// <param name="src">The value to convert</param>
            T convert(S src);

            /// <summary>
            /// Converts the source value to a target value
            /// </summary>
            /// <param name="src">The value to convert</param>
            T convert(S src, out T dst);
        }

        /// <summary>
        /// Characterizes conversion operations from one
        /// clr-defined primitive to another
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target value</typeparam>
        public interface ClrConverter<S,T> : Conversion<S,T>
        {
            
            IReadOnlyList<T> convert(IReadOnlyList<S> src);
        }
         
    }



}