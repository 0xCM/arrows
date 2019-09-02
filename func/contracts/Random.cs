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
    /// Characterizes a source capable of producing an interminable 
    /// sequence of bounded/unbounded points of specific primal type
    /// </summary>
    /// <typeparam name="T">The primal type</typeparam>
    public interface IPointSource<T>
        where T : struct
    {
        T Next();    

        T Next(T max);    
        
        T Next(T min, T max);

    }

    public interface IStepwiseSource<T> : IPointSource<T>
        where T : struct
    {
        void Advance(ulong steps);

        void Retreat(ulong steps);

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
        T Next<T>()
            where T : struct;

        T Next<T>(T max)
            where T : struct;

        T Next<T>(T min, T max)
            where T : struct;
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