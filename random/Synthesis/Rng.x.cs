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
        Vector<N,T> Next<T>()
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        Vector<N,T> Next<T>(T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by both lower and upper bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        Vector<N,T> Next<T>(T min, T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next vector from the suite, where each component is 
        /// constrained by an interval domain
        /// </summary>
        /// <param name="domain">The range</param>
        /// <typeparam name="T">The point type</typeparam>
        Vector<N,T> Next<T>(Interval<T> domain)
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

    public static class RandSynth
    {
        /// <summary>
        /// Creates a polyrand rng from a point source
        /// </summary>
        /// <param name="rng">The source rng</param>
        public static IPolyrand ToPolyrand(this IPointSource<ulong> source)        
            => new Polyrand(source);

        /// <summary>
        /// Creates a System.Random rng from a random source
        /// </summary>
        /// <param name="rng"></param>
        [MethodImpl(Inline)]
        public static System.Random ToSysRand(this IPolyrand rng)
            => SysRand.Derive(rng);

        /// <summary>
        /// Creates a polyrand based on a specified source
        /// </summary>
        /// <param name="random">The random source</param>
        public static IPolyrand ToPolyrand(this IStepwiseSource<ulong> random)
            => new Polyrand(random);

    }


}