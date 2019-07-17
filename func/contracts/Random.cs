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
    /// Characterizes a pseudo-random or entropic point source
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRandomSource<out T> : IPointSource<T>
        where T : struct
    {

    }

    public interface IRandomSource<N,T> : IPointSource<N,T>
        where N : ITypeNat,new()
        where T : struct
    {

    }

}