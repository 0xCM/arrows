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
    using static Expx2c;
    
    partial class cephes
    {

        /// <summary>
        /// Computes y = exp(x*x) while suppressing error amplification
        /// that would ordinarily arise from the inexactness of the
        /// exponential argument x*x. If sign < 0, the result is inverted; 
        /// i.e., y = exp(-x*x) .
        /// </summary>
        /// <param name="x"></param>
        /// <param name="sign"></param>
        /// <returns></returns>
        public static double expx2 (double x, int sign)
        {
            double u, u1, m, f;

            x = fabs (x);
            if (sign < 0)
                x = -x;

            /* Represent x as an exact multiple of M plus a residual.
                M is a power of 2 chosen so that exp(m * m) does not overflow
                or underflow and so that |x - m| is small.  */
            m = MINV * floor(M * x + 0.5);
            f = x - m;

            /* x^2 = m^2 + 2mf + f^2 */
            u = m * m;
            u1 = 2 * m * f  +  f * f;

            if (sign < 0)
            {
                u = -u;
                u1 = -u1;
            }

            if ((u+u1) > MAXLOG)
                return (INFINITY);

            /* u is exact, u1 is small.  */
            u = exp(u) * exp(u1);
            return(u);
        }
                
    }

    static class Expx2c
    {
        public const double M = 128.0;

        public const double MINV = .0078125;
    }

}

/*


 */