//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;


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
        Vector<N,T> Next();
    }


}