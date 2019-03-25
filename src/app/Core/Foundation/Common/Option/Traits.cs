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
        /// Characterizes an untyped optional value
        /// </summary>
        public interface IOption
        {
            /// <summary>
            /// The encapsualted value, if any
            /// </summary>
            object Value { get; }

            /// <summary>
            /// True if a value does exists, false otherwise
            /// </summary>
            bool IsSome { get; }

            /// <summary>
            /// True if a value does not exist, false otherwise
            /// </summary>
            bool IsNone { get; }

            /// <summary>
            /// The type of the encapsulated value, if present
            /// </summary>
            Type ValueType { get; }
        }

        /// <summary>
        /// Characterizes an typed optional value
        /// </summary>
        public interface IOption<T> : IOption
        {
            /// <summary>
            /// The encapsualted value, if any
            /// </summary>
            new T Value { get; }
        }
    }
}