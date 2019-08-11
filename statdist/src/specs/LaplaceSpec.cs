
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Characterizes a Laplace distribution
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Laplace_distribution</remarks>
    public readonly struct LaplaceSpec : IDistributionSpec
    {
        public LaplaceSpec(float mean, float scale)
        {
            this.Mean = mean;
            this.Scale = scale;
        }

        /// <summary>
        /// The mean of the distribtion that serves as the location parameter
        /// </summary>

        [Symbol(Greek.mu)]
        public readonly float Mean;

        /// <summary>
        /// The standard deviation
        /// </summary>

        [Symbol(Greek.sigma)]
        public readonly float Scale;


    }

}