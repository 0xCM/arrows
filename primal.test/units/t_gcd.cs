//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    using D = PrimalDelegates;

    public class t_gcd : UnitTest<t_add>
    {
        /// <summary>
        /// Implements the extended Euclidean algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="pu"></param>
        /// <param name="pv"></param>
        /// <remarks>Adapted from http://www.hackersdelight.org/MontgomeryMultiplication.pdf</remarks>
        static void xgcd(ulong a, ulong b, out ulong u, out ulong v)     
        {
            u = 1ul;
            v = 0ul;
            
            // Note that alpha is even and beta is odd.
            var alpha = a; 
            var beta = b; 
            
            // The invariant maintained from here on is: 2a = u*2*alpha - v*beta.
            while (a > 0) 
            {
                a = a >> 1;
                if ((u & 1) == 0) 
                {
                    // Delete a common factor of 2 in u and v
                    u = u >> 1; 
                    v = v >> 1; 
                }
                else 
                {
                    // We want to set u = (u + beta) >> 1, but that can overflow, so we use Dietz's method.
                    u = ((u ^ beta) >> 1) + (u & beta);
                    v = (v >> 1) + alpha;
                }
            }
        }


    }

}