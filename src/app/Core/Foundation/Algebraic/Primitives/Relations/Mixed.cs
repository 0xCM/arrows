//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;

    partial class Traits
    {

        /// <summary>
        /// Defines non-homogenous relations
        /// </summary>
        public static class Mixed
        {
            /// <summary>
            /// Specifies a relation between two sets (which may or may not be identical)
            /// </summary>
            /// <typeparam name="S">The departure set type</typeparam>
            /// <typeparam name="T">The destination set type</typeparam>
            public interface BinaryRelation<S,T>
            {
                bool related(S x, T y);
            }

            /// <summary>
            /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
            /// </summary>
            /// <typeparam name="S">The departure set type</typeparam>
            /// <typeparam name="T">The destination set type</typeparam>
            public interface Antisymmetric<S,T> : BinaryRelation<S,T>
            {

            }

            /// <summary>
            /// Spcifies that a ~ b iff b ~ a for every a:S,b:T
            /// </summary>
            /// <typeparam name="S">The departure set type</typeparam>
            /// <typeparam name="T">The destination set type</typeparam>
            public interface Symmetric<S,T> : BinaryRelation<S,T>
            {
                
            }

            /// <summary>
            /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
            /// </summary>
            /// <typeparam name="S">The departure set type</typeparam>
            /// <typeparam name="T">The destination set type</typeparam>
            public interface Transitive<S,T> : BinaryRelation<S,T>
            {

            }

        }



    }

}