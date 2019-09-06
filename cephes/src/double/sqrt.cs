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
    using static cephes.Sqrt;
    
    partial class cephes
    {    
        public static double exp(double x)
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
            n = (int)px;
            x -= px * C1;
            x -= px * C2;

            // rational approximation for exponential of the fractional part:
            // e**x = 1 + 2x P(x**2)/( Q(x**2) - P(x**2) )
            xx = x * x;
            px = x * polevl( xx, P, 2 );
            x =  px/( polevl( xx, Q, 3 ) - px );
            x = 1.0 + 2.0 * x;

            /* multiply by power of 2 */
            x = ldexp( x, n );
            return(x);
        }

        internal static class Sqrt
        {
            public static double[] P =
            {
                1.26177193074810590878E-4,
                3.02994407707441961300E-2,
                9.99999999999999999910E-1,
            };

            public static double[] Q = 
            {
                3.00198505138664455042E-6,
                2.52448340349684104192E-3,
                2.27265548208155028766E-1,
                2.00000000000000000009E0,
            };

            public static double C1 = 6.93145751953125E-1;

            public static double C2 = 1.42860682030941723212E-6;
        }
    }
}
