//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Characterizes a geometric distribution
    /// </summary>    
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct GeometricSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static GeometricSpec<T> Define(double p)
            => new GeometricSpec<T>(p);
        
        [MethodImpl(Inline)]
        public static implicit operator GeometricSpec<T>(double p)
            => Define(p);

        [MethodImpl(Inline)]
        public static implicit operator double(GeometricSpec<T> p)
            => p.Success;
        
        [MethodImpl(Inline)]
        public GeometricSpec(double p)
        {
            this.Success = p;
        }
        
        /// <summary>
        /// Specifies a value within the unit interval [0,1] that represents the probability of success
        /// </summary>
        public readonly double Success;

        public DistKind Kind 
            => DistKind.Geometric;
    }
}