#ifndef _VSL_H_
#define _VSL_H_

#ifdef __cplusplus
extern "C" {
#endif /* __cplusplus */

#include "../sdk/mkl_vsl_defines.h"
#include "../sdk/mkl_vsl_types.h"

#if !defined(MKL_CALL_CONV)
#   if defined(__MIC__) || defined(__TARGET_ARCH_MIC)
#       define MKL_CALL_CONV
#   else
#       if defined(MKL_STDCALL)
#           define MKL_CALL_CONV __stdcall
#       else
#           define MKL_CALL_CONV __cdecl
#       endif
#   endif
#endif

#if  !defined(_Mkl_Api)
#define _Mkl_Api(rtype,name,arg)   extern rtype MKL_CALL_CONV   name    arg;
#endif

#if  !defined(_mkl_api)
#define _mkl_api(rtype,name,arg)   extern rtype MKL_CALL_CONV   name    arg;
#endif

#if  !defined(_MKL_API)
#define _MKL_API(rtype,name,arg)   extern rtype MKL_CALL_CONV   name    arg;
#endif

/*
//++
//  VSL CONTINUOUS DISTRIBUTION GENERATOR FUNCTION DECLARATIONS.
//--
*/
/* Cauchy distribution */
_Mkl_Api(int,vdRngCauchy,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngCauchy,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

/* Uniform distribution */
_Mkl_Api(int,vdRngUniform,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngUniform,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

/* Gaussian distribution */
_Mkl_Api(int,vdRngGaussian,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngGaussian,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

/* GaussianMV distribution */
_Mkl_Api(int,vdRngGaussianMV,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const MKL_INT  ,  const MKL_INT  , const double *, const double *))
_Mkl_Api(int,vsRngGaussianMV,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const MKL_INT  ,  const MKL_INT  , const float *,  const float * ))

/* Exponential distribution */
_Mkl_Api(int,vdRngExponential,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  double [], const double  , const double  ))
_Mkl_Api(int,vsRngExponential,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  float [],  const float  ,  const float   ))

/* Laplace distribution */
_Mkl_Api(int,vdRngLaplace,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngLaplace,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

/* Weibull distribution */
_Mkl_Api(int,vdRngWeibull,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  ))
_Mkl_Api(int,vsRngWeibull,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float   ))

/* Rayleigh distribution */
_Mkl_Api(int,vdRngRayleigh,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  double [], const double  , const double  ))
_Mkl_Api(int,vsRngRayleigh,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  ,  float [],  const float  ,  const float   ))

/* Lognormal distribution */
_Mkl_Api(int,vdRngLognormal,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  , const double  ))
_Mkl_Api(int,vsRngLognormal,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float  ,  const float   ))

/* Gumbel distribution */
_Mkl_Api(int,vdRngGumbel,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  ))
_Mkl_Api(int,vsRngGumbel,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float   ))

/* Gamma distribution */
_Mkl_Api(int,vdRngGamma,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  ))
_Mkl_Api(int,vsRngGamma,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float   ))

/* Beta distribution */
_Mkl_Api(int,vdRngBeta,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const double  , const double  , const double  , const double  ))
_Mkl_Api(int,vsRngBeta,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const float  ,  const float  ,  const float  ,  const float   ))

/* Chi-square distribution */
_Mkl_Api(int,vdRngChiSquare,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , double [], const int  ))
_Mkl_Api(int,vsRngChiSquare,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , float [],  const int  ))

/*
//++
//  VSL DISCRETE DISTRIBUTION GENERATOR FUNCTION DECLARATIONS.
//--
*/
/* Bernoulli distribution */
_Mkl_Api(int,viRngBernoulli,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const double  ))

/* Uniform distribution */
_Mkl_Api(int,viRngUniform,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const int  , const int  ))

/* UniformBits distribution */
_Mkl_Api(int,viRngUniformBits,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , unsigned int []))

/* UniformBits32 distribution */
_Mkl_Api(int,viRngUniformBits32,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , unsigned int []))

/* UniformBits64 distribution */
_Mkl_Api(int,viRngUniformBits64,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , unsigned MKL_INT64 []))

/* Geometric distribution */
_Mkl_Api(int,viRngGeometric,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const double  ))

/* Binomial distribution */
_Mkl_Api(int,viRngBinomial,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const int  , const double  ))

/* Multinomial distribution */
_Mkl_Api(int,viRngMultinomial,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const int  , const int  , const double []))

/* Hypergeometric distribution */
_Mkl_Api(int,viRngHypergeometric,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const int  , const int  , const int  ))

/* Negbinomial distribution */
_Mkl_Api(int,viRngNegBinomial,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const double  , const double  ))

/* Poisson distribution */
_Mkl_Api(int,viRngPoisson,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const double  ))

/* PoissonV distribution */
_Mkl_Api(int,viRngPoissonV,(const MKL_INT  , VSLStreamStatePtr  , const MKL_INT  , int [], const double []))

/*
//++
//  VSL SERVICE FUNCTION DECLARATIONS.
//--
*/
/* NewStream - stream creation/initialization */
_Mkl_Api(int,vslNewStream,(VSLStreamStatePtr* , const MKL_INT  , const MKL_UINT  ))

/* NewStreamEx - advanced stream creation/initialization */
_Mkl_Api(int,vslNewStreamEx,(VSLStreamStatePtr* , const MKL_INT  , const MKL_INT  , const unsigned int[]))
_Mkl_Api(int,vsliNewAbstractStream,(VSLStreamStatePtr* , const MKL_INT  , const unsigned int[], const iUpdateFuncPtr))
_Mkl_Api(int,vsldNewAbstractStream,(VSLStreamStatePtr* , const MKL_INT  , const double[], const double  , const double  , const dUpdateFuncPtr))
_Mkl_Api(int,vslsNewAbstractStream,(VSLStreamStatePtr* , const MKL_INT  , const float[], const float  , const float  , const sUpdateFuncPtr))

/* DeleteStream - delete stream */
_Mkl_Api(int,vslDeleteStream,(VSLStreamStatePtr*))

/* CopyStream - copy all stream information */
_Mkl_Api(int,vslCopyStream,(VSLStreamStatePtr*, const VSLStreamStatePtr))

/* CopyStreamState - copy stream state only */
_Mkl_Api(int,vslCopyStreamState,(VSLStreamStatePtr  , const VSLStreamStatePtr  ))

/* LeapfrogStream - leapfrog method */
_Mkl_Api(int,vslLeapfrogStream,(VSLStreamStatePtr  , const MKL_INT  , const MKL_INT  ))

/* SkipAheadStream - skip-ahead method */
#if defined(_MSC_VER)
_Mkl_Api(int,vslSkipAheadStream,(VSLStreamStatePtr  , const __int64  ))
#else
_Mkl_Api(int,vslSkipAheadStream,(VSLStreamStatePtr  , const long long int  ))
#endif

/* GetStreamStateBrng - get BRNG associated with given stream */
_Mkl_Api(int,vslGetStreamStateBrng,(const VSLStreamStatePtr  ))

/* GetNumRegBrngs - get number of registered BRNGs */
_Mkl_Api(int,vslGetNumRegBrngs,(void))

/* RegisterBrng - register new BRNG */
_Mkl_Api(int,vslRegisterBrng,(const VSLBRngProperties* ))

/* GetBrngProperties - get BRNG properties */
_Mkl_Api(int,vslGetBrngProperties,(const int  , VSLBRngProperties* ))

/* SaveStreamF - save random stream descriptive data to file */
_Mkl_Api(int,vslSaveStreamF,(const VSLStreamStatePtr  , const char*             ))

/* LoadStreamF - load random stream descriptive data from file */
_Mkl_Api(int,vslLoadStreamF,(VSLStreamStatePtr *, const char*             ))

/* SaveStreamM - save random stream descriptive data to memory */
_Mkl_Api(int,vslSaveStreamM,(const VSLStreamStatePtr  , char* ))

/* LoadStreamM - load random stream descriptive data from memory */
_Mkl_Api(int,vslLoadStreamM,(VSLStreamStatePtr *, const char* ))

/* GetStreamSize - get size of random stream descriptive data */
_Mkl_Api(int,vslGetStreamSize,(const VSLStreamStatePtr))

/*
//++
//  VSL CONVOLUTION AND CORRELATION FUNCTION DECLARATIONS.
//--
*/

_Mkl_Api(int,vsldConvNewTask,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslsConvNewTask,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslzConvNewTask,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslcConvNewTask,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))

_Mkl_Api(int,vsldCorrNewTask,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslsCorrNewTask,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslzCorrNewTask,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))
_Mkl_Api(int,vslcCorrNewTask,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT []))

_Mkl_Api(int,vsldConvNewTask1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslsConvNewTask1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslzConvNewTask1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslcConvNewTask1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))

_Mkl_Api(int,vsldCorrNewTask1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslsCorrNewTask1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslzCorrNewTask1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))
_Mkl_Api(int,vslcCorrNewTask1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT ,  const MKL_INT  ))

_Mkl_Api(int,vsldConvNewTaskX,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const double [], const MKL_INT []))
_Mkl_Api(int,vslsConvNewTaskX,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const float [],  const MKL_INT []))
_Mkl_Api(int,vslzConvNewTaskX,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcConvNewTaskX,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldCorrNewTaskX,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const double [], const MKL_INT []))
_Mkl_Api(int,vslsCorrNewTaskX,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const float [],  const MKL_INT []))
_Mkl_Api(int,vslzCorrNewTaskX,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcCorrNewTaskX,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT [], const MKL_INT [], const MKL_INT [], const MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldConvNewTaskX1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const double [], const MKL_INT  ))
_Mkl_Api(int,vslsConvNewTaskX1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const float [],  const MKL_INT  ))
_Mkl_Api(int,vslzConvNewTaskX1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcConvNewTaskX1D,(VSLConvTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_Complex8 [],  const MKL_INT  ))

_Mkl_Api(int,vsldCorrNewTaskX1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const double [], const MKL_INT  ))
_Mkl_Api(int,vslsCorrNewTaskX1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const float [],  const MKL_INT  ))
_Mkl_Api(int,vslzCorrNewTaskX1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcCorrNewTaskX1D,(VSLCorrTaskPtr* , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_INT  , const MKL_Complex8 [],  const MKL_INT  ))

_Mkl_Api(int,vslConvDeleteTask,(VSLConvTaskPtr* ))
_Mkl_Api(int,vslCorrDeleteTask,(VSLCorrTaskPtr* ))

_Mkl_Api(int,vslConvCopyTask,(VSLConvTaskPtr* , const VSLConvTaskPtr  ))
_Mkl_Api(int,vslCorrCopyTask,(VSLCorrTaskPtr* , const VSLCorrTaskPtr  ))

_Mkl_Api(int,vslConvSetMode,(VSLConvTaskPtr  , const MKL_INT  ))
_Mkl_Api(int,vslCorrSetMode,(VSLCorrTaskPtr  , const MKL_INT  ))

_Mkl_Api(int,vslConvSetInternalPrecision,(VSLConvTaskPtr  , const MKL_INT  ))
_Mkl_Api(int,vslCorrSetInternalPrecision,(VSLCorrTaskPtr  , const MKL_INT  ))

_Mkl_Api(int,vslConvSetStart,(VSLConvTaskPtr  , const MKL_INT []))
_Mkl_Api(int,vslCorrSetStart,(VSLCorrTaskPtr  , const MKL_INT []))

_Mkl_Api(int,vslConvSetDecimation,(VSLConvTaskPtr  , const MKL_INT []))
_Mkl_Api(int,vslCorrSetDecimation,(VSLCorrTaskPtr  , const MKL_INT []))

_Mkl_Api(int,vsldConvExec,(VSLConvTaskPtr  , const double [], const MKL_INT [], const double [], const MKL_INT [], double [], const MKL_INT []))
_Mkl_Api(int,vslsConvExec,(VSLConvTaskPtr  , const float [],  const MKL_INT [], const float [],  const MKL_INT [], float [],  const MKL_INT []))
_Mkl_Api(int,vslzConvExec,(VSLConvTaskPtr  , const MKL_Complex16 [], const MKL_INT [], const MKL_Complex16 [], const MKL_INT [], MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcConvExec,(VSLConvTaskPtr  , const MKL_Complex8 [],  const MKL_INT [], const MKL_Complex8 [],  const MKL_INT [], MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldCorrExec,(VSLCorrTaskPtr  , const double [], const MKL_INT [], const double [], const MKL_INT [], double [], const MKL_INT []))
_Mkl_Api(int,vslsCorrExec,(VSLCorrTaskPtr  , const float [],  const MKL_INT [], const float [],  const MKL_INT [], float [],  const MKL_INT []))
_Mkl_Api(int,vslzCorrExec,(VSLCorrTaskPtr  , const MKL_Complex16 [], const MKL_INT [], const MKL_Complex16 [], const MKL_INT [], MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcCorrExec,(VSLCorrTaskPtr  , const MKL_Complex8 [],  const MKL_INT [], const MKL_Complex8 [],  const MKL_INT [], MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldConvExec1D,(VSLConvTaskPtr  , const double [], const MKL_INT  , const double [], const MKL_INT  , double [], const MKL_INT  ))
_Mkl_Api(int,vslsConvExec1D,(VSLConvTaskPtr  , const float [],  const MKL_INT  , const float [],  const MKL_INT  , float [],  const MKL_INT  ))
_Mkl_Api(int,vslzConvExec1D,(VSLConvTaskPtr  , const MKL_Complex16 [], const MKL_INT  , const MKL_Complex16 [], const MKL_INT  , MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcConvExec1D,(VSLConvTaskPtr  , const MKL_Complex8 [],  const MKL_INT  , const MKL_Complex8 [],  const MKL_INT  , MKL_Complex8 [],  const MKL_INT  ))

_Mkl_Api(int,vsldCorrExec1D,(VSLCorrTaskPtr  , const double [], const MKL_INT  , const double [], const MKL_INT  , double [], const MKL_INT  ))
_Mkl_Api(int,vslsCorrExec1D,(VSLCorrTaskPtr  , const float [],  const MKL_INT  , const float [],  const MKL_INT  , float [],  const MKL_INT  ))
_Mkl_Api(int,vslzCorrExec1D,(VSLCorrTaskPtr  , const MKL_Complex16 [], const MKL_INT  , const MKL_Complex16 [], const MKL_INT  , MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcCorrExec1D,(VSLCorrTaskPtr  , const MKL_Complex8 [],  const MKL_INT  , const MKL_Complex8 [],  const MKL_INT  , MKL_Complex8 [],  const MKL_INT  ))

_Mkl_Api(int,vsldConvExecX,(VSLConvTaskPtr  , const double [], const MKL_INT [], double [], const MKL_INT []))
_Mkl_Api(int,vslsConvExecX,(VSLConvTaskPtr  , const float [],  const MKL_INT [], float [],  const MKL_INT []))
_Mkl_Api(int,vslzConvExecX,(VSLConvTaskPtr  , const MKL_Complex16 [], const MKL_INT [], MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcConvExecX,(VSLConvTaskPtr  , const MKL_Complex8 [],  const MKL_INT [], MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldCorrExecX,(VSLCorrTaskPtr  , const double [], const MKL_INT [], double [], const MKL_INT []))
_Mkl_Api(int,vslsCorrExecX,(VSLCorrTaskPtr  , const float [],  const MKL_INT [], float [],  const MKL_INT []))
_Mkl_Api(int,vslzCorrExecX,(VSLCorrTaskPtr  , const MKL_Complex16 [], const MKL_INT [], MKL_Complex16 [], const MKL_INT []))
_Mkl_Api(int,vslcCorrExecX,(VSLCorrTaskPtr  , const MKL_Complex8 [],  const MKL_INT [], MKL_Complex8 [],  const MKL_INT []))

_Mkl_Api(int,vsldConvExecX1D,(VSLConvTaskPtr  , const double [], const MKL_INT  , double [], const MKL_INT  ))
_Mkl_Api(int,vslsConvExecX1D,(VSLConvTaskPtr  , const float [],  const MKL_INT  , float [],  const MKL_INT  ))
_Mkl_Api(int,vslzConvExecX1D,(VSLConvTaskPtr  , const MKL_Complex16 [], const MKL_INT  , MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcConvExecX1D,(VSLConvTaskPtr  , const MKL_Complex8 [],  const MKL_INT  , MKL_Complex8 [],  const MKL_INT  ))

_Mkl_Api(int,vsldCorrExecX1D,(VSLCorrTaskPtr  , const double [], const MKL_INT  , double [], const MKL_INT  ))
_Mkl_Api(int,vslsCorrExecX1D,(VSLCorrTaskPtr  , const float [],  const MKL_INT  , float [],  const MKL_INT  ))
_Mkl_Api(int,vslzCorrExecX1D,(VSLCorrTaskPtr  , const MKL_Complex16 [], const MKL_INT  , MKL_Complex16 [], const MKL_INT  ))
_Mkl_Api(int,vslcCorrExecX1D,(VSLCorrTaskPtr  , const MKL_Complex8 [],  const MKL_INT  , MKL_Complex8 [],  const MKL_INT  ))


/*
//++
//  SUMMARARY STATTISTICS LIBRARY ROUTINES
//--
*/

/*
//  Task constructors
*/
_Mkl_Api(int,vsldSSNewTask,(VSLSSTaskPtr* , const MKL_INT* , const MKL_INT* , const MKL_INT* , const double [], const double [], const MKL_INT []))
_Mkl_Api(int,vslsSSNewTask,(VSLSSTaskPtr* , const MKL_INT* , const MKL_INT* , const MKL_INT* , const float  [], const float  [], const MKL_INT []))


/*
// Task editors
*/

/*
// Editor to modify a task parameter
*/
_Mkl_Api(int,vsldSSEditTask,(VSLSSTaskPtr  , const MKL_INT  , const double* ))
_Mkl_Api(int,vslsSSEditTask,(VSLSSTaskPtr  , const MKL_INT  , const float* ))
_Mkl_Api(int,vsliSSEditTask,(VSLSSTaskPtr  , const MKL_INT  , const MKL_INT* ))

/*
// Task specific editors
*/

/*
// Editors to modify moments related parameters
*/
_Mkl_Api(int,vsldSSEditMoments,(VSLSSTaskPtr  , double* , double* , double* , double* , double* , double* , double* ))
_Mkl_Api(int,vslsSSEditMoments,(VSLSSTaskPtr  , float* , float* , float* , float* , float* , float* , float* ))

/*
// Editors to modify sums related parameters
*/
_Mkl_Api(int,vsldSSEditSums,(VSLSSTaskPtr  , double* , double* , double* , double* , double* , double* , double* ))
_Mkl_Api(int,vslsSSEditSums,(VSLSSTaskPtr  , float* , float* , float* , float* , float* , float* , float* ))

/*
// Editors to modify variance-covariance/correlation matrix related parameters
*/
_Mkl_Api(int,vsldSSEditCovCor,(VSLSSTaskPtr  , double* , double* ,  const MKL_INT* , double* , const MKL_INT* ))
_Mkl_Api(int,vslsSSEditCovCor,(VSLSSTaskPtr  , float* , float* , const MKL_INT* , float* , const MKL_INT* ))

/*
// Editors to modify cross-product matrix related parameters
*/
_Mkl_Api(int,vsldSSEditCP,(VSLSSTaskPtr  , double* , double* ,  double* , const MKL_INT* ))
_Mkl_Api(int,vslsSSEditCP,(VSLSSTaskPtr  , float* , float* , float* , const MKL_INT* ))

/*
// Editors to modify partial variance-covariance matrix related parameters
*/
_Mkl_Api(int,vsldSSEditPartialCovCor,(VSLSSTaskPtr  , const MKL_INT [], const double* , const MKL_INT* , const double* , const MKL_INT* , double* , const MKL_INT* , double* , const MKL_INT* ))
_Mkl_Api(int,vslsSSEditPartialCovCor,(VSLSSTaskPtr  , const MKL_INT [], const float* , const MKL_INT* , const float* , const MKL_INT* , float* ,  const MKL_INT* , float* ,  const MKL_INT* ))

/*
// Editors to modify quantiles related parameters
*/
_Mkl_Api(int,vsldSSEditQuantiles,(VSLSSTaskPtr  , const MKL_INT* , const double* , double* , double* , const MKL_INT* ))
_Mkl_Api(int,vslsSSEditQuantiles,(VSLSSTaskPtr  , const MKL_INT* , const float* , float* , float* , const MKL_INT* ))

/*
// Editors to modify stream data quantiles related parameters
*/
_Mkl_Api(int,vsldSSEditStreamQuantiles,(VSLSSTaskPtr  , const MKL_INT* , const double* , double* , const MKL_INT* , const double* ))
_Mkl_Api(int,vslsSSEditStreamQuantiles,(VSLSSTaskPtr  , const MKL_INT* , const float* , float* , const MKL_INT* , const float* ))

/*
// Editors to modify pooled/group variance-covariance matrix related parameters
*/
_Mkl_Api(int,vsldSSEditPooledCovariance,(VSLSSTaskPtr  , const MKL_INT* , double* , double* , const MKL_INT* , double* , double* ))
_Mkl_Api(int,vslsSSEditPooledCovariance,(VSLSSTaskPtr  , const MKL_INT* , float* , float* , const MKL_INT* , float* , float* ))

/*
// Editors to modify robust variance-covariance matrix related parameters
*/
_Mkl_Api(int,vsldSSEditRobustCovariance,(VSLSSTaskPtr  , const MKL_INT* , const MKL_INT* ,  const double* , double* , double* ))
_Mkl_Api(int,vslsSSEditRobustCovariance,(VSLSSTaskPtr  , const MKL_INT* , const MKL_INT* ,  const float* , float* , float* ))


/*
// Editors to modify outliers detection parameters
*/
_Mkl_Api(int,vsldSSEditOutliersDetection,(VSLSSTaskPtr  , const MKL_INT* , const double* , double* ))
_Mkl_Api(int,vslsSSEditOutliersDetection,(VSLSSTaskPtr  , const MKL_INT* , const float* , float* ))

/*
// Editors to modify missing values support parameters
*/
_Mkl_Api(int,vsldSSEditMissingValues,(VSLSSTaskPtr  , const MKL_INT* , const double* , const MKL_INT* , const double* , const MKL_INT* , const double* , const MKL_INT* , double* , const MKL_INT* , double* ))
_Mkl_Api(int,vslsSSEditMissingValues,(VSLSSTaskPtr  , const MKL_INT* , const float* , const MKL_INT* , const float* , const MKL_INT* , const float* , const MKL_INT* , float* , const MKL_INT* , float* ))

/*
// Editors to modify matrixparametrization parameters
*/
_Mkl_Api(int,vsldSSEditCorParameterization,(VSLSSTaskPtr  , const double* , const MKL_INT* , double* , const MKL_INT* ))
_Mkl_Api(int,vslsSSEditCorParameterization,(VSLSSTaskPtr  , const float* , const MKL_INT* , float* , const MKL_INT* ))


/*
// Compute routines
*/
_Mkl_Api(int,vsldSSCompute,(VSLSSTaskPtr  , const unsigned MKL_INT64  , const MKL_INT  ))
_Mkl_Api(int,vslsSSCompute,(VSLSSTaskPtr  , const unsigned MKL_INT64  , const MKL_INT  ))


/*
// Task destructor
*/
_Mkl_Api(int,vslSSDeleteTask,(VSLSSTaskPtr* ))


#ifdef __cplusplus
}
#endif /* __cplusplus */

#endif /* __MKL_VML_H__ */
