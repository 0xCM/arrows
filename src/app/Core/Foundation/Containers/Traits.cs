//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    partial class Traits
    {
        
        public interface Array<N,T> : Enumerable<N,T>
            where N : TypeNat, new()
        {
            T this[int ix] {get; set;}

        }

        
        /// <summary>
        /// Characterizes a set indexed by another set
        /// </summary>
        /// <typeparam name="I">The indexing set</typeparam>
        /// <typeparam name="X">The indexed set</typeparam>
        public interface Index<I,T> : Container<KeyedValue<I,T>>
        {
            /// <summary>
            /// Retrives an indexed value
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T item(I index);

            /// <summary>
            /// Retrives an indexed value via an index operator
            /// </summary>
            /// <param name="index">The index value</param>
            /// <returns>The indexed value</returns>
            T  this[I ix] {get;}
        }


    }


}