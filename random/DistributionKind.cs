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
    using Z0.Mkl;

    public enum DistributionKind
    {
        Uniform,

        UniformRange,

        UniformBits,

        Gaussian,

        Bernoulli,

        Cauchy,

        Chi2,

        Exponential,

        Gamma,
        
        Geometric,

        Laplace,

        Poisson,

        Rayleigh,

        Weibull,

        Lognormal



    }

}