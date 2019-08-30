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

    /// <summary>
    /// Identifies a supported distribution
    /// </summary>
    public enum DistKind
    {
        Uniform,

        UniformRange,

        UniformBits,

        Bernoulli,

        Beta,

        Binomial,

        Cauchy,

        Chi2,

        Exponential,

        Gamma,

        Gaussian,

        Geometric,

        Laplace,

        Poisson,

        Rayleigh,

        Weibull,

        Lognormal



    }

}