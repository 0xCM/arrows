//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static zcore;

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


        public interface Seq<T> //: IEnumerable<T>
        {
            
        }

        public interface FiniteSeq<T> : Seq<T>, Finite<T>
        {
            /// <summary>
            /// Retrieves the 0-based i'th element of the sequence
            /// </summary>
            /// <value></value>
            T this[int i] {get;}
        }

    }


}