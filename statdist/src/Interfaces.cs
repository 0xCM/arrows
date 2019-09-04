//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using static zfunc;

    public interface IDistributionSpec
    {
        DistKind Kind {get;}
        
    }

    /// <summary>
    /// Characterizes a distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    public interface IDistributionSpec<T> : IDistributionSpec
        where T : unmanaged
    {

        
    }

    /// <summary>
    /// Characterizes a sample that was drawn using a specific RNG
    /// </summary>
    /// <typeparam name="T">The sampled data type</typeparam>
    public interface ISample<T>
        where T : unmanaged
    {
        /// <summary>
        /// Identfies the facilitating RNG
        /// </summary>
        RngKind Rng {get;}

        /// <summary>
        /// The sampled data
        /// </summary>
        MemorySpan<T> Data {get;}            
    }

    /// <summary>
    /// Characterizes a sample that was drawn using a specific RNG and 
    /// distribution spec
    /// </summary>
    /// <typeparam name="T">The sampled data type</typeparam>
    public interface ISample<T,D> : ISample<T>
        where T : unmanaged
        where D : struct, IDistributionSpec
    {
        /// <summary>
        /// Characterizes the specified sample distribution
        /// </summary>
        D DistSpec {get;}
    }
}