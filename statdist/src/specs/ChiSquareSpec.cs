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
    public readonly struct ChiSquareSpec<T> : IDistributionSpec<T>
        where T : unmanaged
    {        
        [MethodImpl(Inline)]
        public static implicit operator ChiSquareSpec<T>(int freedom)
            => Define(freedom);

        [MethodImpl(Inline)]
        public static implicit operator int(ChiSquareSpec<T> src)
            => src.Freedom;

        [MethodImpl(Inline)]
        public static ChiSquareSpec<T> Define(int freedom)
            => new ChiSquareSpec<T>(freedom);
        
        [MethodImpl(Inline)]
        public ChiSquareSpec(int freedom)
        {
            this.Freedom = freedom;
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