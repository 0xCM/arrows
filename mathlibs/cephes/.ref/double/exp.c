/*							exp.c
 *
 *	Exponential function
 *
 *
 *
 * SYNOPSIS:
 *
 * double x, y, exp();
 *
 * y = exp( x );
 *
 *
 *
 * DESCRIPTION:
 *
 * Returns e (2.71828...) raised to the x power.
 *
 * Range reduction is accomplished by separating the argument
 * into an integer k and fraction f such that
 *
 *     x    k  f
 *    e  = 2  e.
 *
 * A Pade' form  1 + 2x P(x**2)/( Q(x**2) - P(x**2) )
 * of degree 2/3 is used to approximate exp(f) in the basic
 * interval [-0.5, 0.5].
 *
 *
 * ACCURACY:
 *
 *                      Relative error:
 * arithmetic   domain     # trials      peak         rms
 *    DEC       +- 88       50000       2.8e-17     7.0e-18
 *    IEEE      +- 708      40000       2.0e-16     5.6e-17
 *
 *
 * Error amplification in the exponential function can be
 * a serious matter.  The error propagation involves
 * exp( X(1+delta) ) = exp(X) ( 1 + X*delta + ... ),
 * which shows that a 1 lsb error in representing X produces
 * a relative error of X times 1 lsb in the function.
 * While the routine gives an accurate result for arguments
 * that are exactly represented by a double precision
 * computer number, the result contains amplified roundoff
 * error for large arguments not exactly represented.
 *
 *
 * ERROR MESSAGES:
 *
 *   message         condition      value returned
 * exp underflow    x < MINLOG         0.0
 * exp overflow     x > MAXLOG         INFINITY
 *
 */

/*
Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1995, 2000 by Stephen L. Moshier
*/


/*	Exponential function	*/

#include "mconf.h"
#include "../cephes.h"


static double P[] =
{
	1.26177193074810590878E-4,
	3.02994407707441961300E-2,
	9.99999999999999999910E-1,
};

static double Q[] = 
{
	3.00198505138664455042E-6,
	2.52448340349684104192E-3,
	2.27265548208155028766E-1,
	2.00000000000000000009E0,
};

static double C1 = 6.93145751953125E-1;

static double C2 = 1.42860682030941723212E-6;

extern double LOGE2, LOG2E, MAXLOG, MINLOG, MAXNUM;
#ifdef INFINITIES
extern double INFINITY;
#endif

double exp(double x)
{
	double px, xx;
	int n;

	if(isnan(x))
		return(x);

	if(x > MAXLOG)
		return(INFINITY);

	if(x < MINLOG )
		return(0.0);

	// Express e**x = e**g 2**n = e**g e**( n loge(2) ) = e**( g + n loge(2) )
	px = floor( LOG2E * x + 0.5 ); /* floor() truncates toward -infinity. */
	n = px;
	x -= px * C1;
	x -= px * C2;

	// rational approximation for exponential of the fractional part:
	// e**x = 1 + 2x P(x**2)/( Q(x**2) - P(x**2) )
	//
	xx = x * x;
	px = x * polevl( xx, P, 2 );
	x =  px/( polevl( xx, Q, 3 ) - px );
	x = 1.0 + 2.0 * x;

	/* multiply by power of 2 */
	x = ldexp( x, n );
	return(x);
}
