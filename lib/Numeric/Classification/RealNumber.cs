//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    partial class Operative
    {

        public interface RealNumber<T> : OrderedNumber<T>, Trigonmetric<T>
            where T : struct, IEquatable<T>

        {

        }

        /// <summary>
        /// Characterizes operations over (ordered) values that 
        /// exist between upper and lower bounds
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public interface BoundReal<T> : RealNumber<T>
            where T : struct, IEquatable<T>
        {

        }


    }

    partial class Structures
    {
        /// <summary>
        /// Characterizes a structured real
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        public interface RealNumber<S> : OrderedNumber<S>, Trigonmetric<S>, IComparable<S>
            where S : RealNumber<S>, new()
        {

        }

        public interface BoundReal<S> :  RealNumber<S>
            where S : BoundReal<S>, new()
        {

        }


        /// <summary>
        /// Characterizes a reification structure over real numbers
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface RealNumber<S,T> : RealNumber<S>
            where S : RealNumber<S,T>, new()
        {

        }

    }


    partial class C
    {
        
    }
}