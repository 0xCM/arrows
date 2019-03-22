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
        /// Characterizes a type in the sense that an object A is a type if it inhabits
        /// some universe
        /// </summary>
        public interface Inhabitant
        {
            /// <summary>
            /// The least universe, with respect to hierarchy, if known/relevant, in which the
            /// inhabitant may be found
            /// </summary>
            /// <value></value>
            Option<Universe> Location {get;}
        }

        /// <summary>
        /// Characterizes a type that inhabits a specific universe
        /// </summary>
        public interface Inhabitant<U> : Inhabitant
            where U : Universe
        {
            /// <summary>
            /// The least universe, with respect to hierarchy, if known/relevant, in which the
            /// inhabitant may be found
            /// </summary>
            /// <value></value>
            new Option<U> Location {get;}
        }

        


        /// <summary>
        /// Characterizes a type that is inhabited by other types
        /// </summary>
        /// <remarks>
        /// See http://localhost:9000/refs/books/Y2013HTT.pdf#page=36
        /// </remarks>
        public interface Universe : Inhabitant
        {
            IEnumerable<Inhabitant> inhabitants {get;}
        }

        

        /// <summary>
        /// Characterizes a universe at a specific level in a given hierarchy of universes
        /// </summary>
        public interface IndexedUniverse : Universe
        {
            /// <summary>
            /// The location of the universe within the context of a universe hierachy
            /// </summary>
            /// <value></value>
            int level {get;}
        }
        
        /// <summary>
        /// Characterizes a universe that is inhabited by a specified type
        /// </summary>
        /// <typeparam name="A">The type contained by the universe</typeparam>
        public interface Universe<A> : Universe
            where A : Inhabitant
        {

        }

        /// <summary>
        /// Characterizes a universe that is simultaneously inhabited by 
        /// two specified types
        /// </summary>
        /// <typeparam name="A">The type contained by the universe</typeparam>
        public interface Universe<A,B> : Universe
            where A : Inhabitant
            where B : Inhabitant
        {

        }

    }
}