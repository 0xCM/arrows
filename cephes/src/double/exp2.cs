//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static cephes.Exp2;
    
    partial class cephes
    {

        /// <summary>
        /// Computes 2^x
        /// </summary>
        /// <param name="x">The exponent</param>
        public static double exp2(double x)
        {
            double px = 0, xx = 0;
            short n = 0;

            if(isnan(x))	
                return x;

            if(x > MAXL2)
                return INFINITY;

            if(x < MINL2)
                return 0.0;

            xx = x;	/* save x */
            
            /* separate into integer and fractional parts */
            px = floor(x+0.5);
            n = (short)px;
            x = x - px;

            // rational approximation exp2(x) = 1 +  2xP(xx)/(Q(xx) - P(xx)) where xx = x**2
            xx = x * x;
            px = x * polevl(xx, P, 2);
            x =  px / (p1evl(xx, Q, 2) - px );
            x = 1.0 + ldexp( x, 1 );

            // scale by power of 2 
            x = ldexp( x, n );
            return x;
        }

        internal static class Exp2
        {
            public const double MAXL2 = 1024.0;
            
            public const double  MINL2 = -1024.0;

            public static double[] P = 
            {
                2.30933477057345225087E-2,
                2.02020656693165307700E1,
                1.51390680115615096133E3,
            };

            public static double[] Q = 
            {
                2.33184211722314911771E2,
                4.36821166879210612817E3,
            };

        }
    }
}
