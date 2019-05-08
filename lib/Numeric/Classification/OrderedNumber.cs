//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Operative
    {
        /// <summary>
        /// Characterizes numeric operations in the presence of order
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface IOrderedNumberOps<T> : IStepwiseOps<T>,  IOrderedOps<T>, INumberOps<T> 
            where T : struct, IEquatable<T>
            { }

    }

    partial class Structures
    {
        public interface IOrderedNumber<S> :  IStepwise<S>,  IOrderable<S>,  INumber<S>
            where S : IOrderedNumber<S>, new() {}
        
        /// <summary>
        /// Characterizes a structural number with order
        /// </summary>
        /// <typeparam name="S">The reification type</typeparam>
        /// <typeparam name="T">The underlying type</typeparam>
        public interface OrderedNumber<S,T> : IOrderedNumber<S>
            where S : OrderedNumber<S,T>, new() {}
    }

}