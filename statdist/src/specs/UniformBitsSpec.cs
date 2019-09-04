//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a uniform distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    /// <remarks>See https://en.wikipedia.org/wiki/Uniform_distribution</remarks>
    public readonly struct UniformBitsSpec<T> :  IDistributionSpec<T>
        where T : unmanaged
    {   
        [MethodImpl(Inline)]
        public static UniformBitsSpec<T> Define()
            => new UniformBitsSpec<T>();        


         /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind Kind 
            => DistKind.UniformBits;
   }
}