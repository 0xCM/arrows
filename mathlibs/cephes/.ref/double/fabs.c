/*							fabs.c
 *
 *		Absolute value
 *
 *
 *
 * SYNOPSIS:
 *
 * double x, y;
 *
 * y = fabs( x );
 *
 *
 *
 * DESCRIPTION:
 * 
 * Returns the absolute value of the argument.
 *
 */

#include "mconf.h"
 
double fabs(double x)
{
	union
	  {
		double d;
		short i[4];
	  } u;

	u.d = x;
	u.i[3] &= 0x7fff;
	return( u.d );
}
