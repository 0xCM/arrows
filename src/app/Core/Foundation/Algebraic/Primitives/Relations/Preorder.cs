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
        /// Characterizes a preorder, i.e. a reflexive and transitive
        /// binary relation over its domain
        /// </summary>
        /// <typeparam name="T">The preorder domain</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Preorder </remarks>
        public interface Preorder<T> : Reflexive<T>, Transitive<T>            
        {

        }        


        /// <summary>
        /// Characterizes a set equipped with a preorder
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <remarks>See https://en.wikipedia.org/wiki/Preorder </remarks>
        public interface Proset<T> : Preorder<T>, Set<T>
            where T : IEquatable<T>

        {

        }
    }



}