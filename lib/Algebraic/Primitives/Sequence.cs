//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using static zcore;


    partial class Structures
    {
        /// <summary>
        /// Characterizes a mathematical sequence that carries an integer to a term 
        /// and may be empty, finite or infinite
        /// </summary>
        /// <typeparam name="I">The sequence domain</typeparam>
        /// <typeparam name="T">The sequence codomain</typeparam>
        public interface Sequence<I,T> : Structure<I>
            where I : Sequence<I,T>, new()
        {

            /// <summary>
            /// Yields 0 or more terms t(0), t(1),... of the sequence, contingent upon
            /// both demand and availability
            /// </summary>
            /// <returns></returns>
            IEnumerable<KeyedValue<I,T>> terms();
        }

        /// <summary>
        /// Characterizes a sequence that has at least one term
        /// </summary>
        /// <typeparam name="I">The sequence domain</typeparam>
        /// <typeparam name="T">The sequence codomain</typeparam>
        public interface NonemptySequence<I,T> : Sequence<I,T>
            where I : NonemptySequence<I,T>, new()
        {
            /// <summary>
            /// The first element of the sequence
            /// </summary>
            /// <value></value>
            KeyedValue<I,T> head {get;}

            /// <summary>
            /// All elements of the sequence except the first
            /// </summary>
            /// <value></value>
            Sequence<I,T> tail {get;}
        }

        /// <summary>
        /// Characterizes an infinite sequence
        /// </summary>
        /// <typeparam name="I">The sequence domain</typeparam>
        /// <typeparam name="T">The sequence codomain</typeparam>
        public interface InfiniteSequence<I,T> : NonemptySequence<I,T>
            where I : InfiniteSequence<I,T>, new()
        {

        }

        /// <summary>
        /// Characterizes a finite sequence which may be empty
        /// </summary>
        /// <typeparam name="I">The sequence domain</typeparam>
        /// <typeparam name="T">The sequence codomain</typeparam>
        public interface FiniteSequence<I,T> : Sequence<I,T>
            where I : FiniteSequence<I,T>, new()
        {
            int length {get;}

            bool empty {get;}

        }
    }
}