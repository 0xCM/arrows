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
        /// Specifies a relation between two sets (which may or may not be identical)
        /// </summary>
        /// <typeparam name="S">The departure set type</typeparam>
        /// <typeparam name="T">The destination set type</typeparam>
        public interface BinaryRelation<S,T>
        {
            bool related(S x, T y);
        }

        /// <summary>
        /// Specifies an homogenous relation on a given set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface BinaryRelation<T> : BinaryRelation<T,T>
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
        /// Spcifies that a ~ b iff b ~ a for every a:S,b:T
        /// </summary>
        /// <typeparam name="S">The departure set type</typeparam>
        /// <typeparam name="T">The destination set type</typeparam>
        public interface Symmetric<S,T> : BinaryRelation<S,T>
        {
            
        }

        /// <summary>
        /// Spcifies that a ~ b iff b ~ a for every a,b:T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Symmetric<T> : Symmetric<T,T>
        {
            
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
        /// Spcifies if a,b:T & a!=b then a ~ b & b ~ a => a = b
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Antisymmetric<T> : Antisymmetric<T,T>
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

        /// <summary>
        /// Spcifies a ~ b & b ~ c => a ~ c for every a,b,c:T
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Transitive<T> : Transitive<T,T>
        {
            
        }

        /// <summary>
        ///  Defines a relation on a set that effects a partition on the set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
        public interface Equivalence<T> : Reflexive<T>, Symmetric<T>, Transitive<T>
        {

        }

        public interface PartialOrder<T> : Reflexive<T>, Antisymmetric<T>, Transitive<T>
        {

        }

        public interface Segment<T> : NonempySet<T>
        {
            T representative {get;}
                    
        }

        public interface Partition<T>
        {
            Set<T> source {get;}

            IEnumerable<Segment<T>> parts();
        }

        /// <summary>
        /// Characterizes a Setoid: A set S along with a binary relation SxS->S that effects
        /// a partition of S
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        public interface Setoid<T> : Set<T>, Equivalence<T>
        {
            Partition<T> partition();

            /// <summary>
            /// The canonical surjective projection from the underlying set to the equivalence 
            /// partitions that maps a given element to the equivalence class in which it
            /// resides
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            Segment<T> project(T x);
        }

        /// <summary>
        /// Characterizes a partially-ordered set
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Partially_ordered_set </remarks>
        public interface Poset<T> : Set<T>, PartialOrder<T>
        {
            /// <summary>
            /// Determines whether order may be adjudicated between two particluar elements
            /// </summary>
            /// <param name="x">The left element</param>
            /// <param name="y">The right element</param>
            /// <returns>Returns true if either a ~ b or b ~ a and false oterwise</returns>
            bool comparable(T x, T y);
        }
    }
}