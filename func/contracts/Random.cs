//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines required operations for all RNG's 
    /// </summary>
    public interface IRandomSource
    {
        
        ulong NextInteger();

        double NextDouble();

    }


    public interface IRandomSource<T> : IRandomSource
        where T : struct
    {
                
    }

    public interface ISampleDefaults
    {
        int SampleSize {get;}

    }
    
    public interface ISampleDefaults<T> : ISampleDefaults
        where T : struct
    {
        Interval<T> SampleDomain {get;}
    }


}