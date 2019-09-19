//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitMasks;
    using static As;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and 
    /// partitions the value, or portion thereof, into segments of common length 
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    public delegate void Partitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static partial class BitParts
    {        
    }


}