//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    /// <summary>
    /// Identifies a source of random data
    /// </summary>
    public interface IRandomSource
    {
        /// <summary>
        /// Identifies the rng that drives the source
        /// </summary>
        /// <value></value>
        RngKind RngKind {get;}
    }

    public interface IPointSource<T> : IRandomSource
        where T : struct
    {
        /// <summary>
        /// Retrieves the next point from the source
        /// </summary>
        T Next();    
    }

    /// <summary>
    /// Characterizes a stream of random values of parametric type
    /// </summary>
    /// <typeparam name="T">The random value type</typeparam>
    public interface IRandomStream<T> : IPointSource<T>, IEnumerable<T>
        where T: struct
    {
        /// <summary>
        /// Retrieves a specified number points from the source
        /// </summary>
        /// <param name="count">The number of elements</param>
        IEnumerable<T> Next(int count);
    }

    public interface ISampler<T> : IRandomStream<T>
        where T : unmanaged
    {
        /// <summary>
        /// The length of the sampler's internal buffer
        /// </summary>
        int BufferLength {get;}

        /// <summary>
        /// The type of distibution being sampled
        /// </summary>
        DistKind DistKind{get;}
    }

    
    /// <summary>
    /// Characterizes a random source that can produce points bounded by a range
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IBoundPointSource<T> : IPointSource<T>
        where T : struct
    {
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
    /// Characterizes a random stream navigator
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

    /// <summary>
    /// Characterizes a random source that can be navigated
    /// </summary>
    /// <typeparam name="T">The primal element type</typeparam>
    public interface IStepwiseSource<T> : IBoundPointSource<T>, IRandomNav
        where T : struct
    {

    }


    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of bounded points 
    /// of any canonical scalar type [sbyte, byte, short, ushort, int, uint, long, ulong, float, double]
    /// </summary>
   public interface IPolyrand : 
        IBoundPointSource<sbyte>,
        IBoundPointSource<byte>,
        IBoundPointSource<short>,
        IBoundPointSource<ushort>,
        IBoundPointSource<int>, 
        IBoundPointSource<uint>, 
        IBoundPointSource<long>,
        IBoundPointSource<ulong>, 
        IBoundPointSource<float>,
        IBoundPointSource<double> 
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