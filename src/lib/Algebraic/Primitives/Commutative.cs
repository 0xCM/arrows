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

    partial class Operative
    {
        /// <summary>
        /// Characterizes commutative operations
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface Commutative<T>
        {

        }
    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes structural commutativity
        /// </summary>
        /// <typeparam name="S">The structure type</typeparam>
        public interface Commutative<S>
            where S : Commutative<S>, new()
        {

        }
    }
}