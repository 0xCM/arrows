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
        
        ulong NextUInt64();

        ulong NextUInt64(ulong max);

        int NextInt32(int max);
        
        double NextDouble();

    }

    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of points
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IPointSource<out T>
        where T : struct
    {
        T Next();    
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


    /// <summary>
    /// Characterizes a pseudo-random or entropic point source
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRandomSource<T> : IPointSource<T>
        where T : struct
    {

    }


    public interface IBoundRandomSource<T> : IRandomSource<T>
        where T : struct
    {
        /// <summary>
        /// The range of the underlying random variable
        /// </summary>
        Interval<T> Range {get;}
    }

    public interface IRandomSource<N,T> : IPointSource<N,T>
        where N : ITypeNat,new()
        where T : struct
    {

    }

}