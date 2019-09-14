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
        public static double erfc(double a)
        {
            double p,q,x,y,z;

            if(a < 0.0)
                x = -a;
            else
                x = a;

            if(x < 1.0)
                return(1.0 - erf(a));

            z = -a * a;

            if(z < -MAXLOG)
            {
                mtherr("erfc", UNDERFLOW);
                if(a < 0)
                    return(2.0);
                else
                    return(0.0);
            }

            /* Compute z = exp(z).  */
            z = expx2(a, -1);

            if(x < 8.0)
            {
                p = polevl(x, P, 8);
                q = p1evl(x, Q, 8);
            }
            else
            {
                p = polevl(x, R, 5);
                q = p1evl(x, S, 6);
            }
            y = (z * p)/q;

            if(a < 0)
                y = 2.0 - y;

            if(y == 0.0)
            {
                if(a < 0)
                    return  2.0;
                else
                    return 0.0;

            }

            return(y);
        }

        public static double erf(double x)
        {
            double y, z;

            if(fabs(x) > 1.0)
                return(1.0 - erfc(x));
                
            z = x * x;
            y = x * polevl(z, T, 4) / p1evl(z, U, 5);

            return(y);
        }

        /// <summary>
        /// Exponentially scaled erfc function exp(x^2) erfc(x) valid for x > 1.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double erfce(double x)
        {
            double p,q;

            if( x < 8.0 )
            {
                p = polevl( x, P, 8 );
                q = p1evl( x, Q, 8 );
            }
            else
            {
                p = polevl( x, R, 5 );
                q = p1evl( x, S, 6 );
            }
            return (p/q);
        }

        internal static class Erf
        {
            public static readonly double[] P = 
            {
                2.46196981473530512524E-10,
                5.64189564831068821977E-1,
                7.46321056442269912687E0,
                4.86371970985681366614E1,
                1.96520832956077098242E2,
                5.26445194995477358631E2,
                9.34528527171957607540E2,
                1.02755188689515710272E3,
                5.57535335369399327526E2
            };
            public static readonly double[] Q = 
            {
                1.32281951154744992508E1,
                8.67072140885989742329E1,
                3.54937778887819891062E2,
                9.75708501743205489753E2,
                1.82390916687909736289E3,
                2.24633760818710981792E3,
                1.65666309194161350182E3,
                5.57535340817727675546E2
            };
            public static readonly double[] R = 
            {
                5.64189583547755073984E-1,
                1.27536670759978104416E0,
                5.01905042251180477414E0,
                6.16021097993053585195E0,
                7.40974269950448939160E0,
                2.97886665372100240670E0
            };

            public static readonly double[] S = 
            {        
                2.26052863220117276590E0,
                9.39603524938001434673E0,
                1.20489539808096656605E1,
                1.70814450747565897222E1,
                9.60896809063285878198E0,
                3.36907645100081516050E0
            };
            
            public static readonly double[] T = 
            {
                9.60497373987051638749E0,
                9.00260197203842689217E1,
                2.23200534594684319226E3,
                7.00332514112805075473E3,
                5.55923013010394962768E4
            };
            
            public static double[] U = 
            {
                3.35617141647503099647E1,
                5.21357949780152679795E2,
                4.59432382970980127987E3,
                2.26290000613890934246E4,
                4.92673942608635921086E4
            };            
        
        }
    }

}