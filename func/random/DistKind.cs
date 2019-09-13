//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    /// <summary>
    /// Identifies a supported distribution
    /// </summary>
    public enum DistKind
    {        
        /// <summary>
        /// Identifies a uniform distribution
        /// </summary>
        Uniform,

        /// <summary>
        /// Identifies a uniform distribution bound to a particular range
        /// </summary>
        UniformRange,

        /// <summary>
        /// Identifies a bitwise uniform distribution
        /// </summary>
        UniformBits,

        /// <summary>
        /// Identifies a Bernoulli distribution
        /// </summary>
        Bernoulli,

        /// <summary>
        /// Identifies a Beta distribution
        /// </summary>
        Beta,

        /// <summary>
        /// Identifies a Binomial distribution
        /// </summary>
        Binomial,

        /// <summary>
        /// Identifies a Cauchy distribution
        /// </summary>
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