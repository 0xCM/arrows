//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    public interface IRandomSource
    {
        RngKind RngKind {get;}
    }

    /// <summary>
    /// Characterizes a stream of random values of parametric type
    /// </summary>
    /// <typeparam name="T">The random value type</typeparam>
    public interface IRandomStream<T> : IRandomSource, IEnumerable<T>
        where T: struct
    {
        /// <summary>
        /// Retrieves a specified number of elements from the stream; equivalent to Take(count)
        /// </summary>
        /// <param name="count">The number of elements</param>
        IEnumerable<T> Next(int count);
    }

    /// <summary>
    /// Characterizes a random source capable of producing constraint point values 
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IPointSource<T> : IRandomSource
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        T Next();    

        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bound
        /// </summary>
        /// <param name="max">The exclusive upper bound</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next(T max);    
        
        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive lower bound</param>
        /// <param name="max">The exclusive max value</param>
        T Next(T min, T max);

    }

    /// <summary>
    /// Characterizes a random source navigator
    /// </summary>
    public interface IRandomNav
    {
        /// <summary>
        /// Moves the stream a specified number of steps forward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Advance(ulong steps);

        /// <summary>
        /// Moves the stream a specified number of steps backward
        /// </summary>
        /// <param name="steps">The step count</param>
        void Retreat(ulong steps);
    }

    public interface IStepwiseSource<T> : IPointSource<T>, IRandomNav
        where T : struct
    {

    }


    /// <summary>
    /// Characterizes source capable of producing an interminable 
    /// sequence of bounded/unbounded points of any scalar primal type
    /// </summary>
   public interface IPolyrand : 
        IPointSource<sbyte>,
        IPointSource<byte>,
        IPointSource<short>,
        IPointSource<ushort>,
        IPointSource<int>, 
        IPointSource<uint>, 
        IPointSource<long>,
        IPointSource<ulong>, 
        IPointSource<float>,
        IPointSource<double> 
    {
        /// <summary>
        /// Retrieves the next point from the source, bound only by the domain of the type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>()
            where T : struct;

        /// <summary>
        /// Retrieves the next point from the source, constrained by an upper bounds
        /// </summary>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next point from the source, constrained by upper and lower bounds
        /// </summary>
        /// <param name="min">The inclusive min value</param>
        /// <param name="max">The exclusive max value</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(T min, T max)
            where T : struct;

        /// <summary>
        /// Retrieves the next point from the source, bound within a specified interval
        /// </summary>
        /// <param name="src">The random source</param>
        /// <param name="domain">The domain of the random variable</param>
        /// <typeparam name="T">The point type</typeparam>
        T Next<T>(Interval<T> domain)
            where T : struct;

        /// <summary>
        /// Retrieves the random  stream navigator, if supported
        /// </summary>
        Option<IRandomNav> Nav {get;}
    
    }

}