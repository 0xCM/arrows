//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {
        /// <summary>
        /// Characterizes a type whose instances can be identified within
        /// some context by some context-specific identifier
        /// </summary>
        /// <typeparam name="I">The identifier type</typeparam>
        /// <typeparam name="T">The identifiedtyp</typeparam>
        public interface Identifiable<I,T>
        {
            /// <summary>
            /// Defines logical/representational identity that is contexutally unique
            /// </summary>
            I identity {get;}

        }

        public interface AliasedIdentity<I,T> : Identifiable<I,T>
        {
            /// <summary>
            /// Defines an alternate identity representation which,
            /// like identifiers, are contextually unique; however,
            /// assuming these uniqueness requirements for aliases,
            /// an arbitrary number of alias values may identify
            /// the same identifiable thing.
            /// </summary>
            I alias {get;}
        }

    }

}