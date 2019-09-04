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
    /// Characterizes a bernouli distribution
    /// </summary>    
    /// <typeparam name="T">The sample value type</typeparam>
    public readonly struct Chi2Spec<T> : IDistributionSpec<T>
        where T : unmanaged
    {        
        [MethodImpl(Inline)]
        public static implicit operator Chi2Spec<T>(int p)
            => Define(p);

        [MethodImpl(Inline)]
        public static implicit operator int(Chi2Spec<T> p)
            => p.Freedom;

        [MethodImpl(Inline)]
        public static Chi2Spec<T> Define(int p)
            => new Chi2Spec<T>(p);
        
        [MethodImpl(Inline)]
        public Chi2Spec(int p)
        {
            this.Freedom = p;
        }
        
        /// <summary>
        /// The number of degrees of freedom
        /// </summary>
        public readonly int Freedom;

        /// <summary>
        /// Classifies the distribution spec
        /// </summary>
        public DistKind Kind 
            => DistKind.Chi2;

    }

}