namespace Z0
{
    using System;

    using static zfunc;

    public static class MM
    {

        /// <summary>
        /// Applies the extended Euclidean algorithm
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="pu"></param>
        /// <param name="pv"></param>
        /// <remarks>Adapted from http://www.hackersdelight.org/MontgomeryMultiplication.pdf</remarks>
        public static void xgcd(ulong a, ulong b, out ulong u, out ulong v)     
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

        /// <summary>
        /// Divides (x || y) by z, for 64-bit integers x, y, and z, giving the remainder (modulus) as the result.
        /// Must have x < z (to get a 64-bit result). This is checked for.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <remarks>Adapted from http://www.hackersdelight.org/MontgomeryMultiplication.pdf</remarks>
        public static ulong modul64(ulong x, ulong y, ulong z) 
        {
            ulong i, t;
            if (x >= z) 
                throw new Exception("Bad call to modul64, must have x < z.");
            for (i = 1; i <= 64; i++) 
            { 
                // All 1's if x(63) = 1.
                t = x >> 63; 

                // Shift x || y left one bit.
                x = (x << 1) | (y >> 63); 

                y = y << 1;  
                if ((x | t) >= z) 
                {
                    x = x - z;
                    y = y + 1;
                }
            }
            
            return x; // Quotient is y.
        }

    }

}