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
        /// Specifies an homogenous relation on a given set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface BinaryRelation<T> : Mixed.BinaryRelation<T,T>
        {
            
        }


        /// <summary>
        /// Spcifies that a ~ a for every a:T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Reflexive<T> : BinaryRelation<T>
        {

        }


        /// <summary>
        /// Spcifies that a ~ b iff b ~ a for every a,b:T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Symmetric<T> : Mixed.Symmetric<T,T>
        {
            
        }

        /// <summary>
        /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Antisymmetric<T> : Mixed.Antisymmetric<T,T>
        {

        }

        /// <summary>
        /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Transitive<T> : Mixed.Transitive<T,T>
        {
            
        }

        
 
    }
}