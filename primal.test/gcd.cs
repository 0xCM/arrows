namespace Z0
{
    using System;

    using static zfunc;

    public static class MM
    {

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