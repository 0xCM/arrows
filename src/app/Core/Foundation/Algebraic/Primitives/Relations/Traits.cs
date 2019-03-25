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

        /// <summary>
        ///  Characterizes a reflexive, symmetric and transitive binary relation over a set
        ///  that, consequently, effects a partition on said set
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Equivalence_relation</remarks>
        public interface Equivalence<T> : Reflexive<T>, Symmetric<T>, Transitive<T>
        {

        }
        
        /// <summary>
        /// Characterizes an equivalence class, i.e. a segment of a partition effected via 
        /// an equivalence relation
        /// </summary>
        /// <typeparam name="T">The classified type</typeparam>
        public interface EqClass<T> : NonempySet<T>
            where T : IEquatable<T>

        {
            T representative {get;}

        }

        /// <summary>
        /// Characterizes a constructive equivalence class, i.e. an equivalnce class 
        /// with enumerable content
        /// </summary>
        /// <typeparam name="T">The content type</typeparam>
        public interface DiscreteEqClass<T> : EqClass<T>, DiscreteSet<T>
            where T : IEquatable<T>

        {

        }

        /// <summary>
        /// Characterizes a partition over a set effected via an equivalence relation. 
        /// In this context, a parition is a collection of mutually disjoint subsets 
        /// of a given set whose union recovers the original set
        /// </summary>
        /// <typeparam name="C">The equivalence class type</typeparam>
        /// <typeparam name="T">The set domain</typeparam>
        public interface QuotientSet<C,T> : Set<T>, Equivalence<T>
            where T : IEquatable<T>
            where C : EqClass<T>
        {
            /// <summary>
            /// Effects a partition via the equivalence
            /// </summary>
            /// <returns></returns>
            Core.Seq<C> partition();

            /// <summary>
            /// The canonical surjective projection from the underlying set to the equivalence 
            /// partitions that maps a given element to the equivalence class in which it
            /// resides
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            C project(T x);
        }

        /// <summary>
        /// Characterizes a discrete partition over a discrete set and, consequently, 
        /// is a constructive presentation of an equivalence relation. In this context, a parition
        /// is a collection of mutually disjoint subsets of a given set whose union
        /// is recovers the original set
        /// </summary>
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Setoid</remarks>
        public interface Setoid<C,T> : QuotientSet<C,T>
            where T : IEquatable<T>
            where C : DiscreteEqClass<T>
        {

        }
    }
}