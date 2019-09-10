/*							log.c
 *
 *	Natural logarithm
 *
 *
 *
 * SYNOPSIS:
 *
 * double x, y, log();
 *
 * y = log( x );
 *
 *
 *
 * DESCRIPTION:
 * Natural logarithm
 * Returns the base e (2.718...) logarithm of x.
 * The argument is separated into its exponent and fractional
 * parts.  If the exponent is between -1 and +1, the logarithm
 * of the fraction is approximated by
 *     log(1+x) = x - 0.5 x**2 + x**3 P(x)/Q(x).
 * Otherwise, setting  z = 2(x-1)/x+1),
 *     log(x) = z + z**3 P(z)/Q(z).
 *
 *
 *
 * ACCURACY:
 *
 *                      Relative error:
 * arithmetic   domain     # trials      peak         rms
 *    IEEE      0.5, 2.0    150000      1.44e-16    5.06e-17
 *    IEEE      +-MAXNUM    30000       1.20e-16    4.78e-17
 *    DEC       0, 10       170000      1.8e-17     6.3e-18
 *
 * In the tests over the interval [+-MAXNUM], the logarithms
 * of the random arguments were uniformly distributed over
 * [0, MAXLOG].
 *
 * ERROR MESSAGES:
 *
 * log singularity:  x = 0; returns -INFINITY
 * log domain:       x < 0; returns NAN
 */

/*
Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1995, 2000 by Stephen L. Moshier
*/

#include "mconf.h"
static char fname[] = {"log"};

/* Coefficients for log(1+x) = x - x**2/2 + x**3 P(x)/Q(x)
 * 1/sqrt(2) <= x < sqrt(2)
 */
static double P[] = 
{
	1.01875663804580931796E-4,
	4.97494994976747001425E-1,
	4.70579119878881725854E0,
	1.44989225341610930846E1,
	1.79368678507819816313E1,
	7.70838733755885391666E0,
};
static double Q[] = 
{
	1.12873587189167450590E1,
	4.52279145837532221105E1,
	8.29875266912776603211E1,
	7.11544750618563894466E1,
	2.31251620126765340583E1,
};




/* Coefficients for log(x) = z + z**3 P(z)/Q(z),
 * where z = 2(x-1)/(x+1)
 * 1/sqrt(2) <= x < sqrt(2)
 */

static double R[3] = {
-7.89580278884799154124E-1,
 1.63866645699558079767E1,
-6.41409952958715622951E1,
};
static double S[3] = {
/* 1.00000000000000000000E0,*/
-3.56722798256324312549E1,
 3.12093766372244180303E2,
-7.69691943550460008604E2,
};


#ifdef ANSIPROT
extern double frexp ( double, int * );
extern double ldexp ( double, int );
extern double polevl ( double, void *, int );
extern double p1evl ( double, void *, int );
extern int isnan ( double );
extern int isfinite ( double );
#else
double frexp(), ldexp(), polevl(), p1evl();
int isnan(), isfinite();
#endif
#define SQRTH 0.70710678118654752440
extern double INFINITY, NAN;

double log(double x)
{
	int e;
	double y, z;

	if( isnan(x) )
		return(x);

	if( x == INFINITY )
		return(x);

	// Test for domain
	if( x <= 0.0 )
	{
		if( x == 0.0 )
		{
			mtherr( fname, SING );
			return( -INFINITY );
		}
		else
		{
			mtherr( fname, DOMAIN );
			return( NAN );
		}
	}

	x = frexp( x, &e );

	// logarithm using log(x) = z + z**3 P(z)/Q(z), where z = 2(x-1)/x+1)
	if( (e > 2) || (e < -2) )
	{
		if(x < SQRTH)
		{ 
			// 2( 2x-1 )/( 2x+1 )
			e -= 1;
			z = x - 0.5;
			y = 0.5 * z + 0.5;
		}	
		else
		{ 
			// 2 (x-1)/(x+1)
			z = x - 0.5;
			z -= 0.5;
			y = 0.5 * x  + 0.5;
		}

		x = z / y;

		// rational form
		z = x*x;
		z = x * ( z * polevl( z, R, 2 ) / p1evl( z, S, 3 ) );
		y = e;
		z = z - y * 2.121944400546905827679e-4;
		z = z + x;
		z = z + e * 0.693359375;
		
		return z;
	}

	// logarithm using log(1+x) = x - .5x**2 + x**3 P(x)/Q(x)
	if( x < SQRTH )
	{
		e -= 1;
		x = ldexp( x, 1 ) - 1.0; //  2x - 1
	}	
	else
	{
		x = x - 1.0;
	}

	// rational form 
	z = x*x;
	y = x * ( z * polevl( x, P, 5 ) / p1evl( x, Q, 5 ) );

	if(e != 0)
		y = y - e * 2.121944400546905827679e-4;

	y = y - ldexp( z, -1 );   //  y - 0.5 * z 
	z = x + y;

	if(e != 0)
		z = z + e * 0.693359375;

	return z ;
}
