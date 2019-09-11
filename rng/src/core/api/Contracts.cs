//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    using static As;

    /// <summary>
    /// Characterizes a suite of random number generators
    /// </summary>
    /// <typeparam name="N">The number of generators in the suite</typeparam>
    public interface IRngSuite<N>
        where N : ITypeNat, new()
    {
        /// <summary>
        /// Retrieves the next vector from the suite, where the components 
        /// are bound only by the domain of the type
        /// </summary>
        BlockVector<N,T> Next<T>()
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        BlockVector<N,T> Next<T>(T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by both lower and upper bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        BlockVector<N,T> Next<T>(T min, T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an interval domain
        /// </summary>
        /// <param name="domain">The range</param>
        /// <typeparam name="T">The point type</typeparam>
        BlockVector<N,T> Next<T>(Interval<T> domain)
            where T : struct;
        
        /// <summary>
        /// Retrieves the generator corresponding to a specified index that
        /// is in the range 0, 1, ..., N - 1
        /// </summary>
        /// <param name="index">The rng index</param>
        IPolyrand Select(int index);
    }


    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of N-dimensional points/vectors
    /// </summary>
    /// <typeparam name="T">The primal component type</typeparam>
    public interface IPointSource<N,T>
        where N : ITypeNat, new()
        where T : struct
    {
        Span<N,T> Next();
    }

}