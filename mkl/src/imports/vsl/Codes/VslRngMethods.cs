//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
	using System;
    using static VslRngMethod;

    public enum VslRngMethod
    {
        VSL_RNG_METHOD_UNIFORM_STD = 0,
        
        [MklCode("")]
        VSL_RNG_METHOD_UNIFORMBITS32_STD = 0, 
        
        [MklCode("")]
        VSL_RNG_METHOD_UNIFORMBITS64_STD = 0,

        /// <summary>
        /// Generates normally distributed random number x thru the pair of uniformly distributed numbers u1 and u2 according to the formula:
        /// x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>       
        [MklCode("")]
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER = 0,

        /// <summary>
        /// Generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly distributed numbers u1 and u2
        /// according to the formula 
        /// x1=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// NOTE: implementation correctly works with odd vector lengths
        /// </summary>       
        [MklCode("")]
        VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2 = 1, 

        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>       
        [MklCode("")]
        VSL_RNG_METHOD_GAUSSIAN_ICDF = 2,

        [MklCode("")]
        VSL_RNG_METHOD_ACCURACY_FLAG  = (1<<30),

        [MklCode("")]
        VSL_RNG_METHOD_GAMMA_GNORM = 0,

        [MklCode("")]
        VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE = VSL_RNG_METHOD_GAMMA_GNORM | VSL_RNG_METHOD_ACCURACY_FLAG,

    }

    enum VslGaussianMethod
    {
        [MklCode("")]
        BoxMuller1 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER,

        [MklCode("")]
        BoxMuller2 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2,

        [MklCode("")]
        IDCF = VSL_RNG_METHOD_GAUSSIAN_ICDF,
    }

    enum VslGammaMethod
    {
        [MklCode("")]
        GNorm = VSL_RNG_METHOD_GAMMA_GNORM,

        [MklCode("")]
        GNormAccurate = VSL_RNG_METHOD_GAMMA_GNORM_ACCURATE
    }

    /// <summary>
    ///  Multivariate (correlated) normal random number generator is based on uncorrelated 
    /// Gaussian random number generator (see vslsRngGaussian and vsldRngGaussian functions)
    /// </summary>
    enum VslGaussianMVMethod
    {

        /// <summary>
        /// BOXMULLER  generates normally distributed random number x thru the pair of uniformly distributed 
        /// numbers u1 and u2 according to the formula: x=sqrt(-ln(u1))*sin(2*Pi*u2)
        /// </summary>
        BoxMuller1 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER,

        /// <summary>
        /// generates pair of normally distributed random numbers x1 and x2 thru the pair of uniformly 
        /// dustributed numbers u1 and u2 according to the formula x1=sqrt(-ln(u1))*sin(2*Pi*u2) 
        /// and x2=sqrt(-ln(u1))*cos(2*Pi*u2)
        /// </summary>
        BoxMuller2 = VSL_RNG_METHOD_GAUSSIAN_BOXMULLER2,
        
        /// <summary>
        /// inverse cumulative distribution function method
        /// </summary>
        ICDF    = VSL_RNG_METHOD_GAUSSIAN_ICDF 

    }

    enum VslPoissonMethod
    {
        ///<summary>
        /// Pif lambda>=27, acceptance/rejection method is used with decomposition onto 4 regions:
        /// - 2 parallelograms;
        /// - triangle;
        /// - left exponential tail;
        /// - right exponential tail.
        /// othewise table lookup method is used        
        ///</summary>
        PTPE  =   0,
        
        ///<summary>
        ///for lambda>=1 method is based on Poisson inverse CDF approximation by 
        /// Gaussian inverse CDF; for lambda < 1 table lookup method is used.    
        ///</summary>
        POISNORM  = 1

    }


}