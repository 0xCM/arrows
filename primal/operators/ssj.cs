//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    /// <summary>
    /// SSJ algorithms
    /// </summary>
    /// <remarks>
    /// Algorithms taken from SSJ in accordance with the project license; 
    /// see LICENSE file in this project root
    /// </remarks>
    public static partial class SSJ
    {
        /// <summary>
        /// Computes the number of different combinations of s objects out
        /// of a total number of objects n
        /// </summary>
        /// <param name="n">The total number of objects</param>
        /// <param name="s">The selection size</param>
        public static double comb(int n, int s) 
        {
            const int NLIM = 100;            
            int i;

            if (s == 0 || s == n)
                return 1;
            if (s < 0) 
            {
                error ("combination: s < 0");
                return 0;
            }
            if (s > n) 
            {
                error("combination: s > n");
                return 0;
            }
            if (s > (n/2))
                s = n - s;

            if (n <= NLIM) 
            {
                var Res = 1.0;
                int Diff = n - s;
                for (i = 1; i <= s; i++) {
                Res *= (double)(Diff + i)/(double)i;
                }
                return Res;
            }
            else 
                return fmath.exp(lnfac (n) - lnfac(s) - lnfac(n - s));
        }


        /// <summary>
        /// Computes the natural log of n!
        /// </summary>
        /// <param name="n">A number n such that x = n! for some x</param>
        public static double lnfac (long n) 
        {
            const int NLIM = 14;

            if (n < 0)
                throw new ArgumentException ("lnFactorial: n < 0");

            if (n == 0 || n == 1)
                return 0.0;

            if (n <= NLIM) 
            {
                long z = 1;
                long x = 1;
                for (int i = 2; i <= n; i++) 
                {
                    ++x;
                    z *= x;
                }
                
                return fmath.ln (z);
            }
            else 
            {
                var x = (double)(n + 1);
                var y = 1.0/(x*x);
                var z = ((-(5.95238095238E-4*y) + 7.936500793651E-4)*y - 2.7777777777778E-3)*y + 8.3333333333333E-2;
                z = ((x - 0.5)*fmath.ln (x) - x) + 9.1893853320467E-1 + z/x;
                return z;
            }
        }
    }
}