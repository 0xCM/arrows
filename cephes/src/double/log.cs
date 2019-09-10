//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
// Derived from: Cephes Math Library Release 2.8:  June, 2000
// Copyright 1984, 1995, 2000 by Stephen L. Moshier
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static cephes.Erf;
    
    partial class cephes
    {
        
        public static double log(double x)
        {
            const double SQRTH = 0.70710678118654752440;
            const string fname = "log";

            int e = 0;
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

            x = frexp( x, ref e);

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
    }

}


/*


/*
 * Natural logarithm
 * Returns the base e (2.718...) logarithm of x.
 * The argument is separated into its exponent and fractional
 * parts.  If the exponent is between -1 and +1, the logarithm
 * of the fraction is approximated by
 *     log(1+x) = x - 0.5 x**2 + x**3 P(x)/Q(x).
 * Otherwise, setting  z = 2(x-1)/x+1),
 *     log(x) = z + z**3 P(z)/Q(z).

 */


 