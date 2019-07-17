#ifndef _VML_H_
#define _VML_H_

#ifdef __cplusplus
extern "C" {
#endif /* __cplusplus */

#include "mkl_vml_defines.h"
#include "mkl_vml_types.h"

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


/*  VML ELEMENTARY FUNCTION DECLARATIONS */
/* ------------------------------------------------------------------------- */

/* Absolute value: r[i] = |a[i]| */
_Mkl_Api(void,vsAbs,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAbs,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAbs,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAbs,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex absolute value: r[i] = |a[i]| */
_Mkl_Api(void,vcAbs,(const MKL_INT n,  const MKL_Complex8  a[], float  r[]))
_Mkl_Api(void,vzAbs,(const MKL_INT n,  const MKL_Complex16 a[], double r[]))

_Mkl_Api(void,vmcAbs,(const MKL_INT n,  const MKL_Complex8  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAbs,(const MKL_INT n,  const MKL_Complex16 a[], double r[], MKL_INT64 mode))

/* Argument of complex value: r[i] = carg(a[i]) */
_Mkl_Api(void,vcArg,(const MKL_INT n,  const MKL_Complex8  a[], float  r[]))
_Mkl_Api(void,vzArg,(const MKL_INT n,  const MKL_Complex16 a[], double r[]))

_Mkl_Api(void,vmcArg,(const MKL_INT n,  const MKL_Complex8  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzArg,(const MKL_INT n,  const MKL_Complex16 a[], double r[], MKL_INT64 mode))

/* Addition: r[i] = a[i] + b[i] */
_Mkl_Api(void,vsAdd,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdAdd,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsAdd,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAdd,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complex addition: r[i] = a[i] + b[i] */
_Mkl_Api(void,vcAdd,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAdd,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAdd,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAdd,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Subtraction: r[i] = a[i] - b[i] */
_Mkl_Api(void,vsSub,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdSub,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsSub,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdSub,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complex subtraction: r[i] = a[i] - b[i] */
_Mkl_Api(void,vcSub,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzSub,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcSub,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzSub,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Reciprocal: r[i] = 1.0 / a[i] */
_Mkl_Api(void,vsInv,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdInv,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsInv,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdInv,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Square root: r[i] = a[i]^0.5 */
_Mkl_Api(void,vsSqrt,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdSqrt,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsSqrt,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdSqrt,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex square root: r[i] = a[i]^0.5 */
_Mkl_Api(void,vcSqrt,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzSqrt,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcSqrt,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzSqrt,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Reciprocal square root: r[i] = 1/a[i]^0.5 */
_Mkl_Api(void,vsInvSqrt,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdInvSqrt,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsInvSqrt,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdInvSqrt,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Cube root: r[i] = a[i]^(1/3) */
_Mkl_Api(void,vsCbrt,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCbrt,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCbrt,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCbrt,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Reciprocal cube root: r[i] = 1/a[i]^(1/3) */
_Mkl_Api(void,vsInvCbrt,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdInvCbrt,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsInvCbrt,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdInvCbrt,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Squaring: r[i] = a[i]^2 */
_Mkl_Api(void,vsSqr,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdSqr,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsSqr,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdSqr,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Exponential function: r[i] = e^a[i] */
_Mkl_Api(void,vsExp,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdExp,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsExp,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdExp,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex exponential function: r[i] = e^a[i] */
_Mkl_Api(void, vcExp, (const MKL_INT n, const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void, vzExp, (const MKL_INT n, const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void, vmcExp, (const MKL_INT n, const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void, vmzExp, (const MKL_INT n, const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Exponential function (base 2): r[i] = 2^a[i] */
_Mkl_Api(void, vsExp2, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdExp2, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsExp2, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdExp2, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Exponential function (base 10): r[i] = 10^a[i] */
_Mkl_Api(void, vsExp10, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdExp10, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsExp10, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdExp10, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Exponential of arguments decreased by 1: r[i] = e^(a[i]-1) */
_Mkl_Api(void,vsExpm1,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdExpm1,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsExpm1,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdExpm1,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Logarithm (base e): r[i] = ln(a[i]) */
_Mkl_Api(void,vsLn,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdLn,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsLn,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdLn,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex logarithm (base e): r[i] = ln(a[i]) */
_Mkl_Api(void,vcLn,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzLn,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcLn,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzLn,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Logarithm (base 2): r[i] = lb(a[i]) */
_Mkl_Api(void, vsLog2, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdLog2, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsLog2, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdLog2, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Logarithm (base 10): r[i] = lg(a[i]) */
_Mkl_Api(void,vsLog10,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdLog10,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsLog10,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdLog10,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex logarithm (base 10): r[i] = lg(a[i]) */
_Mkl_Api(void,vcLog10,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzLog10,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcLog10,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzLog10,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Logarithm (base e) of arguments increased by 1: r[i] = log(1+a[i]) */
_Mkl_Api(void,vsLog1p,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdLog1p,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsLog1p,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdLog1p,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Computes the exponent: r[i] = logb(a[i]) */
_Mkl_Api(void, vsLogb, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdLogb, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsLogb, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdLogb, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Cosine: r[i] = cos(a[i]) */
_Mkl_Api(void,vsCos,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCos,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCos,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCos,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex cosine: r[i] = ccos(a[i]) */
_Mkl_Api(void,vcCos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzCos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcCos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzCos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Sine: r[i] = sin(a[i]) */
_Mkl_Api(void,vsSin,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdSin,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsSin,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdSin,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex sine: r[i] = sin(a[i]) */
_Mkl_Api(void,vcSin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzSin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcSin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzSin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Tangent: r[i] = tan(a[i]) */
_Mkl_Api(void,vsTan,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdTan,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsTan,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdTan,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex tangent: r[i] = tan(a[i]) */
_Mkl_Api(void,vcTan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzTan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcTan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzTan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Cosine PI: r[i] = cos(a[i]*PI) */
_Mkl_Api(void, vsCospi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdCospi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsCospi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdCospi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Sine PI: r[i] = sin(a[i]*PI) */
_Mkl_Api(void, vsSinpi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdSinpi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsSinpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdSinpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Tangent PI: r[i] = tan(a[i]*PI) */
_Mkl_Api(void, vsTanpi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdTanpi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsTanpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdTanpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Cosine degree: r[i] = cos(a[i]*PI/180) */
_Mkl_Api(void, vsCosd, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdCosd, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsCosd, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdCosd, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Sine degree: r[i] = sin(a[i]*PI/180) */
_Mkl_Api(void, vsSind, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdSind, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsSind, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdSind, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Tangent degree: r[i] = tan(a[i]*PI/180) */
_Mkl_Api(void, vsTand, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdTand, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsTand, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdTand, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Hyperbolic cosine: r[i] = ch(a[i]) */
_Mkl_Api(void,vsCosh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCosh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCosh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCosh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic cosine: r[i] = ch(a[i]) */
_Mkl_Api(void,vcCosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzCosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcCosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzCosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Hyperbolic sine: r[i] = sh(a[i]) */
_Mkl_Api(void,vsSinh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdSinh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsSinh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdSinh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic sine: r[i] = sh(a[i]) */
_Mkl_Api(void,vcSinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzSinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcSinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzSinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Hyperbolic tangent: r[i] = th(a[i]) */
_Mkl_Api(void,vsTanh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdTanh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsTanh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdTanh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic tangent: r[i] = th(a[i]) */
_Mkl_Api(void,vcTanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzTanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcTanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzTanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Arc cosine: r[i] = arccos(a[i]) */
_Mkl_Api(void,vsAcos,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAcos,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAcos,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAcos,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex arc cosine: r[i] = arccos(a[i]) */
_Mkl_Api(void,vcAcos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAcos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAcos,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAcos,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Arc sine: r[i] = arcsin(a[i]) */
_Mkl_Api(void,vsAsin,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAsin,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAsin,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAsin,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex arc sine: r[i] = arcsin(a[i]) */
_Mkl_Api(void,vcAsin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAsin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAsin,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAsin,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Arc tangent: r[i] = arctan(a[i]) */
_Mkl_Api(void,vsAtan,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAtan,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAtan,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAtan,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex arc tangent: r[i] = arctan(a[i]) */
_Mkl_Api(void,vcAtan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAtan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAtan,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAtan,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Arc cosine PI: r[i] = arccos(a[i])/PI */
_Mkl_Api(void, vsAcospi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdAcospi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsAcospi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdAcospi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Arc sine PI: r[i] = arcsin(a[i])/PI */
_Mkl_Api(void, vsAsinpi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdAsinpi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsAsinpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdAsinpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Arc tangent PI: r[i] = arctan(a[i])/PI */
_Mkl_Api(void, vsAtanpi, (const MKL_INT n, const float  a[], float  r[]))
_Mkl_Api(void, vdAtanpi, (const MKL_INT n, const double a[], double r[]))

_Mkl_Api(void, vmsAtanpi, (const MKL_INT n, const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdAtanpi, (const MKL_INT n, const double a[], double r[], MKL_INT64 mode))

/* Hyperbolic arc cosine: r[i] = arcch(a[i]) */
_Mkl_Api(void,vsAcosh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAcosh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAcosh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAcosh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic arc cosine: r[i] = arcch(a[i]) */
_Mkl_Api(void,vcAcosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAcosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAcosh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAcosh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Hyperbolic arc sine: r[i] = arcsh(a[i]) */
_Mkl_Api(void,vsAsinh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAsinh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAsinh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAsinh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic arc sine: r[i] = arcsh(a[i]) */
_Mkl_Api(void,vcAsinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAsinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAsinh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAsinh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Hyperbolic arc tangent: r[i] = arcth(a[i]) */
_Mkl_Api(void,vsAtanh,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdAtanh,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsAtanh,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAtanh,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Complex hyperbolic arc tangent: r[i] = arcth(a[i]) */
_Mkl_Api(void,vcAtanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzAtanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcAtanh,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzAtanh,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Error function: r[i] = erf(a[i]) */
_Mkl_Api(void,vsErf,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdErf,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsErf,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdErf,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Inverse error function: r[i] = erfinv(a[i]) */
_Mkl_Api(void,vsErfInv,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdErfInv,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsErfInv,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdErfInv,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Square root of the sum of the squares: r[i] = hypot(a[i],b[i]) */
_Mkl_Api(void,vsHypot,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdHypot,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsHypot,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdHypot,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complementary error function: r[i] = 1 - erf(a[i]) */
_Mkl_Api(void,vsErfc,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdErfc,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsErfc,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdErfc,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Inverse complementary error function: r[i] = erfcinv(a[i]) */
_Mkl_Api(void,vsErfcInv,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdErfcInv,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsErfcInv,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdErfcInv,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Cumulative normal distribution function: r[i] = cdfnorm(a[i]) */
_Mkl_Api(void,vsCdfNorm,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCdfNorm,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCdfNorm,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCdfNorm,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Inverse cumulative normal distribution function: r[i] = cdfnorminv(a[i]) */
_Mkl_Api(void,vsCdfNormInv,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCdfNormInv,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCdfNormInv,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCdfNormInv,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Logarithm (base e) of the absolute value of gamma function: r[i] = lgamma(a[i]) */
_Mkl_Api(void,vsLGamma,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdLGamma,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsLGamma,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdLGamma,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Gamma function: r[i] = tgamma(a[i]) */
_Mkl_Api(void,vsTGamma,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdTGamma,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsTGamma,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdTGamma,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Arc tangent of a/b: r[i] = arctan(a[i]/b[i]) */
_Mkl_Api(void,vsAtan2,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdAtan2,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsAtan2,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdAtan2,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Arc tangent of a/b divided by PI: r[i] = arctan(a[i]/b[i])/PI */
_Mkl_Api(void, vsAtan2pi, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdAtan2pi, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsAtan2pi, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdAtan2pi, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Multiplicaton: r[i] = a[i] * b[i] */
_Mkl_Api(void,vsMul,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdMul,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsMul,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdMul,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complex multiplication: r[i] = a[i] * b[i] */
_Mkl_Api(void,vcMul,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzMul,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcMul,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzMul,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Division: r[i] = a[i] / b[i] */
_Mkl_Api(void,vsDiv,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdDiv,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsDiv,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdDiv,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complex division: r[i] = a[i] / b[i] */
_Mkl_Api(void,vcDiv,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzDiv,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcDiv,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzDiv,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Power function: r[i] = a[i]^b[i] */
_Mkl_Api(void,vsPow,(const MKL_INT n,  const float  a[], const float  b[], float  r[]))
_Mkl_Api(void,vdPow,(const MKL_INT n,  const double a[], const double b[], double r[]))

_Mkl_Api(void,vmsPow,(const MKL_INT n,  const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdPow,(const MKL_INT n,  const double a[], const double b[], double r[], MKL_INT64 mode))

/* Complex power function: r[i] = a[i]^b[i] */
_Mkl_Api(void,vcPow,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzPow,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcPow,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzPow,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Power function: r[i] = a[i]^(3/2) */
_Mkl_Api(void,vsPow3o2,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdPow3o2,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsPow3o2,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdPow3o2,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Power function: r[i] = a[i]^(2/3) */
_Mkl_Api(void,vsPow2o3,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdPow2o3,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsPow2o3,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdPow2o3,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Power function with fixed degree: r[i] = a[i]^b */
_Mkl_Api(void,vsPowx,(const MKL_INT n,  const float  a[], const float   b, float  r[]))
_Mkl_Api(void,vdPowx,(const MKL_INT n,  const double a[], const double  b, double r[]))

_Mkl_Api(void,vmsPowx,(const MKL_INT n,  const float  a[], const float   b, float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdPowx,(const MKL_INT n,  const double a[], const double  b, double r[], MKL_INT64 mode))

/* Complex power function with fixed degree: r[i] = a[i]^b */
_Mkl_Api(void,vcPowx,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8   b, MKL_Complex8  r[]))
_Mkl_Api(void,vzPowx,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16  b, MKL_Complex16 r[]))

_Mkl_Api(void,vmcPowx,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8   b, MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzPowx,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16  b, MKL_Complex16 r[], MKL_INT64 mode))

/* Power function with a[i]>=0: r[i] = a[i]^b[i] */
_Mkl_Api(void, vsPowr, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdPowr, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsPowr, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdPowr, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Sine & cosine: r1[i] = sin(a[i]), r2[i]=cos(a[i]) */
_Mkl_Api(void,vsSinCos,(const MKL_INT n,  const float  a[], float  r1[], float  r2[]))
_Mkl_Api(void,vdSinCos,(const MKL_INT n,  const double a[], double r1[], double r2[]))

_Mkl_Api(void,vmsSinCos,(const MKL_INT n,  const float  a[], float  r1[], float  r2[], MKL_INT64 mode))
_Mkl_Api(void,vmdSinCos,(const MKL_INT n,  const double a[], double r1[], double r2[], MKL_INT64 mode))

/* Linear fraction: r[i] = (a[i]*scalea + shifta)/(b[i]*scaleb + shiftb) */
_Mkl_Api(void,vsLinearFrac,(const MKL_INT n,  const float  a[], const float  b[], const float  scalea, const float  shifta, const float  scaleb, const float  shiftb, float  r[]))
_Mkl_Api(void,vdLinearFrac,(const MKL_INT n,  const double a[], const double b[], const double scalea, const double shifta, const double scaleb, const double shiftb, double r[]))

_Mkl_Api(void,vmsLinearFrac,(const MKL_INT n,  const float  a[], const float  b[], const float  scalea, const float  shifta, const float  scaleb, const float  shiftb, float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdLinearFrac,(const MKL_INT n,  const double a[], const double b[], const double scalea, const double shifta, const double scaleb, const double shiftb, double r[], MKL_INT64 mode))

/* Integer value rounded towards plus infinity: r[i] = ceil(a[i]) */
_MKL_API(void,VSCEIL,(const MKL_INT *n, const float  a[], float  r[]))
_MKL_API(void,VDCEIL,(const MKL_INT *n, const double a[], double r[]))
_mkl_api(void,vsceil,(const MKL_INT *n, const float  a[], float  r[]))
_mkl_api(void,vdceil,(const MKL_INT *n, const double a[], double r[]))
_Mkl_Api(void,vsCeil,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdCeil,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsCeil,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdCeil,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Integer value rounded towards minus infinity: r[i] = floor(a[i]) */
_Mkl_Api(void,vsFloor,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdFloor,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsFloor,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdFloor,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Signed fraction part: r[i] = a[i] - |a[i]| */
_Mkl_Api(void,vsFrac,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdFrac,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsFrac,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdFrac,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Truncated integer value and the remaining fraction part: r1[i] = |a[i]|, r2[i] = a[i] - |a[i]| */
_Mkl_Api(void,vsModf,(const MKL_INT n,  const float  a[], float  r1[], float  r2[]))
_Mkl_Api(void,vdModf,(const MKL_INT n,  const double a[], double r1[], double r2[]))

_Mkl_Api(void,vmsModf,(const MKL_INT n,  const float  a[], float  r1[], float  r2[], MKL_INT64 mode))
_Mkl_Api(void,vmdModf,(const MKL_INT n,  const double a[], double r1[], double r2[], MKL_INT64 mode))

/* Modulus function: r[i] = fmod(a[i], b[i]) */
_Mkl_Api(void, vsFmod, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdFmod, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsFmod, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdFmod, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Remainder function: r[i] = remainder(a[i], b[i]) */
_Mkl_Api(void, vsRemainder, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdRemainder, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsRemainder, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdRemainder, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Next after function: r[i] = nextafter(a[i], b[i]) */
_Mkl_Api(void, vsNextAfter, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdNextAfter, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsNextAfter, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdNextAfter, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Copy sign function: r[i] = copysign(a[i], b[i]) */
_Mkl_Api(void, vsCopySign, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdCopySign, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsCopySign, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdCopySign, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Positive difference function: r[i] = fdim(a[i], b[i]) */
_Mkl_Api(void, vsFdim, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdFdim, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsFdim, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdFdim, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Maximum function: r[i] = fmax(a[i], b[i]) */
_Mkl_Api(void, vsFmax, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdFmax, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsFmax, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdFmax, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Minimum function: r[i] = fmin(a[i], b[i]) */
_Mkl_Api(void, vsFmin, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdFmin, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsFmin, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdFmin, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Maximum magnitude function: r[i] = maxmag(a[i], b[i]) */
_Mkl_Api(void, vsMaxMag, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdMaxMag, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsMaxMag, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdMaxMag, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Minimum magnitude function: r[i] = minmag(a[i], b[i]) */
_Mkl_Api(void, vsMinMag, (const MKL_INT n, const float  a[], const float  b[], float  r[]))
_Mkl_Api(void, vdMinMag, (const MKL_INT n, const double a[], const double b[], double r[]))

_Mkl_Api(void, vmsMinMag, (const MKL_INT n, const float  a[], const float  b[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdMinMag, (const MKL_INT n, const double a[], const double b[], double r[], MKL_INT64 mode))

/* Rounded integer value in the current rounding mode: r[i] = nearbyint(a[i]) */
_Mkl_Api(void,vsNearbyInt,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdNearbyInt,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsNearbyInt,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdNearbyInt,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Rounded integer value in the current rounding mode with inexact result exception raised for rach changed value: r[i] = rint(a[i]) */
_Mkl_Api(void,vsRint,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdRint,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsRint,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdRint,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Value rounded to the nearest integer: r[i] = round(a[i]) */
_Mkl_Api(void,vsRound,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdRound,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsRound,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdRound,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Integer value rounded towards zero: r[i] = trunc(a[i]) */
_Mkl_Api(void,vsTrunc,(const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void,vdTrunc,(const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void,vmsTrunc,(const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void,vmdTrunc,(const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/* Element by element conjugation: r[i] = conj(a[i]) */
_Mkl_Api(void,vcConj,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzConj,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcConj,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzConj,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Element by element multiplication of vector A element and conjugated vector B element: r[i] = mulbyconj(a[i],b[i]) */
_Mkl_Api(void,vcMulByConj,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[]))
_Mkl_Api(void,vzMulByConj,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcMulByConj,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_Complex8  b[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzMulByConj,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_Complex16 b[], MKL_Complex16 r[], MKL_INT64 mode))

/* Complex exponent of real vector elements: r[i] = CIS(a[i]) */
_Mkl_Api(void,vcCIS,(const MKL_INT n,  const float  a[], MKL_Complex8  r[]))
_Mkl_Api(void,vzCIS,(const MKL_INT n,  const double a[], MKL_Complex16 r[]))

_Mkl_Api(void,vmcCIS,(const MKL_INT n,  const float  a[], MKL_Complex8  r[], MKL_INT64 mode))
_Mkl_Api(void,vmzCIS,(const MKL_INT n,  const double a[], MKL_Complex16 r[], MKL_INT64 mode))

/* Exponential integral of real vector elements: r[i] = E1(a[i]) */
_Mkl_Api(void, vsExpInt1, (const MKL_INT n,  const float  a[], float  r[]))
_Mkl_Api(void, vdExpInt1, (const MKL_INT n,  const double a[], double r[]))

_Mkl_Api(void, vmsExpInt1, (const MKL_INT n,  const float  a[], float  r[], MKL_INT64 mode))
_Mkl_Api(void, vmdExpInt1, (const MKL_INT n,  const double a[], double r[], MKL_INT64 mode))

/*  VML PACK FUNCTION DECLARATIONS. */
/* ------------------------------------------------------------------------- */

/* Positive Increment Indexing */
_Mkl_Api(void,vsPackI,(const MKL_INT n,  const float  a[], const MKL_INT   incra, float  y[]))
_Mkl_Api(void,vdPackI,(const MKL_INT n,  const double a[], const MKL_INT   incra, double y[]))

_Mkl_Api(void,vcPackI,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_INT   incra, MKL_Complex8  y[]))
_Mkl_Api(void,vzPackI,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_INT   incra, MKL_Complex16 y[]))

/* Index Vector Indexing */
_Mkl_Api(void,vsPackV,(const MKL_INT n,  const float  a[], const MKL_INT ia[], float  y[]))
_Mkl_Api(void,vdPackV,(const MKL_INT n,  const double a[], const MKL_INT ia[], double y[]))

_Mkl_Api(void,vcPackV,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_INT ia[], MKL_Complex8  y[]))
_Mkl_Api(void,vzPackV,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_INT ia[], MKL_Complex16 y[]))

/* Mask Vector Indexing */
_Mkl_Api(void,vsPackM,(const MKL_INT n,  const float  a[], const MKL_INT ma[], float  y[]))
_Mkl_Api(void,vdPackM,(const MKL_INT n,  const double a[], const MKL_INT ma[], double y[]))

_Mkl_Api(void,vcPackM,(const MKL_INT n,  const MKL_Complex8  a[], const MKL_INT ma[], MKL_Complex8  y[]))
_Mkl_Api(void,vzPackM,(const MKL_INT n,  const MKL_Complex16 a[], const MKL_INT ma[], MKL_Complex16 y[]))

/*  VML UNPACK FUNCTION DECLARATIONS. */

/* Positive Increment Indexing */

_Mkl_Api(void,vsUnpackI,(const MKL_INT n,  const float  a[], float  y[], const MKL_INT incry  ))
_Mkl_Api(void,vdUnpackI,(const MKL_INT n,  const double a[], double y[], const MKL_INT incry  ))

_Mkl_Api(void,vcUnpackI,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  y[], const MKL_INT incry  ))
_Mkl_Api(void,vzUnpackI,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 y[], const MKL_INT incry  ))

/* Index Vector Indexing */

_Mkl_Api(void,vsUnpackV,(const MKL_INT n,  const float  a[], float  y[], const MKL_INT iy[]   ))
_Mkl_Api(void,vdUnpackV,(const MKL_INT n,  const double a[], double y[], const MKL_INT iy[]   ))

_Mkl_Api(void,vcUnpackV,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  y[], const MKL_INT iy[]))
_Mkl_Api(void,vzUnpackV,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 y[], const MKL_INT iy[]))

/* Mask Vector Indexing */

_Mkl_Api(void,vsUnpackM,(const MKL_INT n,  const float  a[], float  y[], const MKL_INT my[]   ))
_Mkl_Api(void,vdUnpackM,(const MKL_INT n,  const double a[], double y[], const MKL_INT my[]   ))

_Mkl_Api(void,vcUnpackM,(const MKL_INT n,  const MKL_Complex8  a[], MKL_Complex8  y[], const MKL_INT my[]))
_Mkl_Api(void,vzUnpackM,(const MKL_INT n,  const MKL_Complex16 a[], MKL_Complex16 y[], const MKL_INT my[]))


/* VML ERROR HANDLING FUNCTION DECLARATIONS. */
/* ------------------------------------------------------------------------- */

/* Set VML Error Status */
_Mkl_Api(int,vmlSetErrStatus,(const MKL_INT   status))

/* Get VML Error Status */
_Mkl_Api(int,vmlGetErrStatus,(void))

/* Clear VML Error Status */
_Mkl_Api(int,vmlClearErrStatus,(void))

/* Set VML Error Callback Function */
_Mkl_Api(VMLErrorCallBack,vmlSetErrorCallBack,(const VMLErrorCallBack func))

/* Get VML Error Callback Function */
_Mkl_Api(VMLErrorCallBack,vmlGetErrorCallBack,(void))

/* Reset VML Error Callback Function */
_Mkl_Api(VMLErrorCallBack,vmlClearErrorCallBack,(void))


/*  VML MODE FUNCTION DECLARATIONS. */

/* Set VML Mode */
_Mkl_Api(unsigned int,vmlSetMode,(const MKL_UINT  newmode))

/* Get VML Mode */
_Mkl_Api(unsigned int,vmlGetMode,(void))

_Mkl_Api(void,MKLFreeTls,(const MKL_UINT  fdwReason))

#ifdef __cplusplus
}
#endif /* __cplusplus */

#endif /* __MKL_VML_H__ */
