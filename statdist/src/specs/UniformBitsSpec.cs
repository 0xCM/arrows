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
    /// Defines operations specific to uniform bit distributions
    /// </summary>
    public static class UniformBitsSpec
    {
        /// <summary>
        /// Interprets a supplied spec as a uniform spec; an error
        /// is raised if the spec does not define a uniform bits distribution
        /// </summary>
        /// <param name="spec">The distribution specifier</param>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformBitsSpec<T> From<T>(IDistributionSpec<T> src)
            where T : unmanaged
                => (UniformBitsSpec<T>)src;
        
        /// <summary>
        /// Defines a unform bits distribution
        /// </summary>
        /// <typeparam name="T">The sample element type</typeparam>
        [MethodImpl(Inline)]
        public static UniformBitsSpec<T> Define<T>()
            where T : unmanaged
                => UniformBitsSpec<T>.Define();
    }

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

        [MethodImpl(Inline)]
        public UniformBitsSpec<uint> ToUInt32()
            => new UniformBitsSpec<uint>();

        [MethodImpl(Inline)]
        public UniformBitsSpec<ulong> ToUInt64()
            => new UniformBitsSpec<ulong>();

   }
}