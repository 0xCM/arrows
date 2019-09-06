/*							pow.c
 *
 *	Power function
 *
 *
 *
 * SYNOPSIS:
 *
 * double x, y, z, pow();
 *
 * z = pow( x, y );
 *
 *
 *
 * DESCRIPTION:
 *
 * Computes x raised to the yth power.  Analytically,
 *
 *      x**y  =  exp( y log(x) ).
 *
 * Following Cody and Waite, this program uses a lookup table
 * of 2**-i/16 and pseudo extended precision arithmetic to
 * obtain an extra three bits of accuracy in both the logarithm
 * and the exponential.
 *
 *
 *
 * ACCURACY:
 *
 *                      Relative error:
 * arithmetic   domain     # trials      peak         rms
 *    IEEE     -26,26       30000      4.2e-16      7.7e-17
 *    DEC      -26,26       60000      4.8e-17      9.1e-18
 * 1/26 < x < 26, with log(x) uniformly distributed.
 * -26 < y < 26, y uniformly distributed.
 *    IEEE     0,8700       30000      1.5e-14      2.1e-15
 * 0.99 < x < 1.01, 0 < y < 8700, uniformly distributed.
 *
 *
 * ERROR MESSAGES:
 *
 *   message         condition      value returned
 * pow overflow     x**y > MAXNUM      INFINITY
 * pow underflow   x**y < 1/MAXNUM       0.0
 * pow domain      x<0 and y noninteger  0.0
 *
 */

/*
Cephes Math Library Release 2.8:  June, 2000
Copyright 1984, 1995, 2000 by Stephen L. Moshier
*/


#include "mconf.h"
static char fname[] = {"pow"};

#define SQRTH 0.70710678118654752440

static double P[] = {
  4.97778295871696322025E-1,
  3.73336776063286838734E0,
  7.69994162726912503298E0,
  4.66651806774358464979E0
};
static double Q[] = {
/* 1.00000000000000000000E0, */
  9.33340916416696166113E0,
  2.79999886606328401649E1,
  3.35994905342304405431E1,
  1.39995542032307539578E1
};
/* 2^(-i/16), IEEE precision */
static double A[] = {
  1.00000000000000000000E0,
  9.57603280698573700036E-1,
  9.17004043204671215328E-1,
  8.78126080186649726755E-1,
  8.40896415253714502036E-1,
  8.05245165974627141736E-1,
  7.71105412703970372057E-1,
  7.38413072969749673113E-1,
  7.07106781186547572737E-1,
  6.77127773468446325644E-1,
  6.48419777325504820276E-1,
  6.20928906036742001007E-1,
  5.94603557501360513449E-1,
  5.69394317378345782288E-1,
  5.45253866332628844837E-1,
  5.22136891213706877402E-1,
  5.00000000000000000000E-1
};
static double B[] = {
 0.00000000000000000000E0,
 1.64155361212281360176E-17,
 4.09950501029074826006E-17,
 3.97491740484881042808E-17,
-4.83364665672645672553E-17,
 1.26912513974441574796E-17,
 1.99100761573282305549E-17,
-1.52339103990623557348E-17,
 0.00000000000000000000E0
};
static double R[] = {
 1.49664108433729301083E-5,
 1.54010762792771901396E-4,
 1.33335476964097721140E-3,
 9.61812908476554225149E-3,
 5.55041086645832347466E-2,
 2.40226506959099779976E-1,
 6.93147180559945308821E-1
};

#define douba(k) A[k]
#define doubb(k) B[k]
#define MEXP 16383.0
#define MNEXP -17183.0




/* log2(e) - 1 */
#define LOG2EA 0.44269504088896340736

#define F W
#define Fa Wa
#define Fb Wb
#define G W
#define Ga Wa
#define Gb u
#define H W
#define Ha Wb
#define Hb Wb

#ifdef ANSIPROT
extern double floor ( double );
extern double fabs ( double );
extern double frexp ( double, int * );
extern double ldexp ( double, int );
extern double polevl ( double, void *, int );
extern double p1evl ( double, void *, int );
extern double powi ( double, int );
extern int signbit ( double );
extern int isnan ( double );
extern int isfinite ( double );
static double reduc ( double );
#else
double floor(), fabs(), frexp(), ldexp();
double polevl(), p1evl(), powi();
int signbit(), isnan(), isfinite();
static double reduc();
#endif
extern double MAXNUM;
#ifdef INFINITIES
extern double INFINITY;
#endif
#ifdef NANS
extern double NAN;
#endif
#ifdef MINUSZERO
extern double NEGZERO;
#endif

double pow( x, y )
double x, y;
{
double w, z, W, Wa, Wb, ya, yb, u;
/* double F, Fa, Fb, G, Ga, Gb, H, Ha, Hb */
double aw, ay, wy;
int e, i, nflg, iyflg, yoddint;

if( y == 0.0 )
	return( 1.0 );
#ifdef NANS
if( isnan(x) )
	return( x );
if( isnan(y) )
	return( y );
#endif
if( y == 1.0 )
	return( x );


#ifdef INFINITIES
if( !isfinite(y) && (x == 1.0 || x == -1.0) )
	{
	mtherr( "pow", DOMAIN );
#ifdef NANS
	return( NAN );
#else
	return( INFINITY );
#endif
	}
#endif

if( x == 1.0 )
	return( 1.0 );

if( y >= MAXNUM )
	{
#ifdef INFINITIES
	if( x > 1.0 )
		return( INFINITY );
#else
	if( x > 1.0 )
		return( MAXNUM );
#endif
	if( x > 0.0 && x < 1.0 )
		return( 0.0);
	if( x < -1.0 )
		{
#ifdef INFINITIES
		return( INFINITY );
#else
		return( MAXNUM );
#endif
		}
	if( x > -1.0 && x < 0.0 )
		return( 0.0 );
	}
if( y <= -MAXNUM )
	{
	if( x > 1.0 )
		return( 0.0 );
#ifdef INFINITIES
	if( x > 0.0 && x < 1.0 )
		return( INFINITY );
#else
	if( x > 0.0 && x < 1.0 )
		return( MAXNUM );
#endif
	if( x < -1.0 )
		return( 0.0 );
#ifdef INFINITIES
	if( x > -1.0 && x < 0.0 )
		return( INFINITY );
#else
	if( x > -1.0 && x < 0.0 )
		return( MAXNUM );
#endif
	}
if( x >= MAXNUM )
	{
#if INFINITIES
	if( y > 0.0 )
		return( INFINITY );
#else
	if( y > 0.0 )
		return( MAXNUM );
#endif
	return(0.0);
	}
/* Set iyflg to 1 if y is an integer.  */
iyflg = 0;
w = floor(y);
if( w == y )
	iyflg = 1;

/* Test for odd integer y.  */
yoddint = 0;
if( iyflg )
	{
	ya = fabs(y);
	ya = floor(0.5 * ya);
	yb = 0.5 * fabs(w);
	if( ya != yb )
		yoddint = 1;
	}

if( x <= -MAXNUM )
	{
	if( y > 0.0 )
		{
#ifdef INFINITIES
		if( yoddint )
			return( -INFINITY );
		return( INFINITY );
#else
		if( yoddint )
			return( -MAXNUM );
		return( MAXNUM );
#endif
		}
	if( y < 0.0 )
		{
#ifdef MINUSZERO
		if( yoddint )
			return( NEGZERO );
#endif
		return( 0.0 );
		}
 	}

nflg = 0;	/* flag = 1 if x<0 raised to integer power */
if( x <= 0.0 )
	{
	if( x == 0.0 )
		{
		if( y < 0.0 )
			{
#ifdef MINUSZERO
			if( signbit(x) && yoddint )
				return( -INFINITY );
#endif
#ifdef INFINITIES
			return( INFINITY );
#else
			return( MAXNUM );
#endif
			}
		if( y > 0.0 )
			{
#ifdef MINUSZERO
			if( signbit(x) && yoddint )
				return( NEGZERO );
#endif
			return( 0.0 );
			}
		return( 1.0 );
		}
	else
		{
		if( iyflg == 0 )
			{ /* noninteger power of negative number */
			mtherr( fname, DOMAIN );
#ifdef NANS
			return(NAN);
#else
			return(0.0L);
#endif
			}
		nflg = 1;
		}
	}

/* Integer power of an integer.  */

if( iyflg )
	{
	i = w;
	w = floor(x);
	if( (w == x) && (fabs(y) < 32768.0) )
		{
		w = powi( x, (int) y );
		return( w );
		}
	}

if( nflg )
	x = fabs(x);

/* For results close to 1, use a series expansion.  */
w = x - 1.0;
aw = fabs(w);
ay = fabs(y);
wy = w * y;
ya = fabs(wy);
if((aw <= 1.0e-3 && ay <= 1.0)
   || (ya <= 1.0e-3 && ay >= 1.0))
	{
	z = (((((w*(y-5.)/720. + 1./120.)*w*(y-4.) + 1./24.)*w*(y-3.)
		+ 1./6.)*w*(y-2.) + 0.5)*w*(y-1.) )*wy + wy + 1.;
	goto done;
	}
/* These are probably too much trouble.  */
#if 0
w = y * log(x);
if (aw > 1.0e-3 && fabs(w) < 1.0e-3)
  {
    z = ((((((
    w/7. + 1.)*w/6. + 1.)*w/5. + 1.)*w/4. + 1.)*w/3. + 1.)*w/2. + 1.)*w + 1.;
    goto done;
  }

if(ya <= 1.0e-3 && aw <= 1.0e-4)
  {
    z = (((((
	     wy*1./720.
	     + (-w*1./48. + 1./120.) )*wy
	    + ((w*17./144. - 1./12.)*w + 1./24.) )*wy
	   + (((-w*5./16. + 7./24.)*w - 1./4.)*w + 1./6.) )*wy
	  + ((((w*137./360. - 5./12.)*w + 11./24.)*w - 1./2.)*w + 1./2.) )*wy
	 + (((((-w*1./6. + 1./5.)*w - 1./4)*w + 1./3.)*w -1./2.)*w ) )*wy
	   + wy + 1.0;
    goto done;
  }
#endif

/* separate significand from exponent */
x = frexp( x, &e );

#if 0
/* For debugging, check for gross overflow. */
if( (e * y)  > (MEXP + 1024) )
	goto overflow;
#endif

/* Find significand of x in antilog table A[]. */
i = 1;
if( x <= douba(9) )
	i = 9;
if( x <= douba(i+4) )
	i += 4;
if( x <= douba(i+2) )
	i += 2;
if( x >= douba(1) )
	i = -1;
i += 1;


/* Find (x - A[i])/A[i]
 * in order to compute log(x/A[i]):
 *
 * log(x) = log( a x/a ) = log(a) + log(x/a)
 *
 * log(x/a) = log(1+v),  v = x/a - 1 = (x-a)/a
 */
x -= douba(i);
x -= doubb(i/2);
x /= douba(i);


/* rational approximation for log(1+v):
 *
 * log(1+v)  =  v  -  v**2/2  +  v**3 P(v) / Q(v)
 */
z = x*x;
w = x * ( z * polevl( x, P, 3 ) / p1evl( x, Q, 4 ) );
w = w - ldexp( z, -1 );   /*  w - 0.5 * z  */

/* Convert to base 2 logarithm:
 * multiply by log2(e)
 */
w = w + LOG2EA * w;
/* Note x was not yet added in
 * to above rational approximation,
 * so do it now, while multiplying
 * by log2(e).
 */
z = w + LOG2EA * x;
z = z + x;

/* Compute exponent term of the base 2 logarithm. */
w = -i;
w = ldexp( w, -4 );	/* divide by 16 */
w += e;
/* Now base 2 log of x is w + z. */

/* Multiply base 2 log by y, in extended precision. */

/* separate y into large part ya
 * and small part yb less than 1/16
 */
ya = reduc(y);
yb = y - ya;


F = z * y  +  w * yb;
Fa = reduc(F);
Fb = F - Fa;

G = Fa + w * ya;
Ga = reduc(G);
Gb = G - Ga;

H = Fb + Gb;
Ha = reduc(H);
w = ldexp( Ga+Ha, 4 );

/* Test the power of 2 for overflow */
if( w > MEXP )
	{
#ifndef INFINITIES
	mtherr( fname, OVERFLOW );
#endif
#ifdef INFINITIES
	if( nflg && yoddint )
	  return( -INFINITY );
	return( INFINITY );
#else
	if( nflg && yoddint )
	  return( -MAXNUM );
	return( MAXNUM );
#endif
	}

if( w < (MNEXP - 1) )
	{
#ifndef DENORMAL
	mtherr( fname, UNDERFLOW );
#endif
#ifdef MINUSZERO
	if( nflg && yoddint )
	  return( NEGZERO );
#endif
	return( 0.0 );
	}

e = w;
Hb = H - Ha;

if( Hb > 0.0 )
	{
	e += 1;
	Hb -= 0.0625;
	}

/* Now the product y * log2(x)  =  Hb + e/16.0.
 *
 * Compute base 2 exponential of Hb,
 * where -0.0625 <= Hb <= 0.
 */
z = Hb * polevl( Hb, R, 6 );  /*    z  =  2**Hb - 1    */

/* Express e/16 as an integer plus a negative number of 16ths.
 * Find lookup table entry for the fractional power of 2.
 */
if( e < 0 )
	i = 0;
else
	i = 1;
i = e/16 + i;
e = 16*i - e;
w = douba( e );
z = w + w * z;      /*    2**-e * ( 1 + (2**Hb-1) )    */
z = ldexp( z, i );  /* multiply by integer power of 2 */

done:

/* Negate if odd integer power of negative number */
if( nflg && yoddint )
	{
#ifdef MINUSZERO
	if( z == 0.0 )
		z = NEGZERO;
	else
#endif
		z = -z;
	}
return( z );
}


/* Find a multiple of 1/16 that is within 1/16 of x. */
static double reduc(x)
double x;
{
double t;

t = ldexp( x, 4 );
t = floor( t );
t = ldexp( t, -4 );
return(t);
}
