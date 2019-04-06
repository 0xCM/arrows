//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class Operative
    {
        public interface Negatable<T> //: Subtractive<T>
        {
            /// <summary>
            /// Unary negation of input
            /// </summary>
            /// <param name="x">The input value</param>
            T negate(T x);

        }

    }

    partial class Structures
    {
        public interface Negatable<S> //: Subtractive<S>
            where S : Negatable<S>, new()
        {
            /// <summary>
            /// Unary structural negation
            /// </summary>
            /// <param name="a">The input value</param>
            S negate();
        }

    }

}