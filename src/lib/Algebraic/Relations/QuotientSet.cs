//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Structure
    {

        /// <summary>
        /// Characterizes a partition over a set effected via an equivalence relation. 
        /// In this context, a parition is a collection of mutually disjoint subsets 
        /// of a given set whose union recovers the original set
        /// </summary>
        /// <typeparam name="C">The equivalence class type</typeparam>
        /// <typeparam name="T">The set domain</typeparam>
        public interface QuotientSet<C,T> 
            where C : Structure.EquivalenceClass<C,T>, new()
            where T : Equality<T>, new()
        {
            /// <summary>
            /// Effects a partition via the equivalence
            /// </summary>
            /// <returns></returns>
            Z0.Seq<C> partition();

            /// <summary>
            /// The canonical surjective projection from the underlying set to the equivalence 
            /// partitions that maps a given element to the equivalence class in which it
            /// resides
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            C project(T x);
        }



    }

}