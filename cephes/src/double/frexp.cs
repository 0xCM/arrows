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

    using static cephes.Floor;
    partial class cephes
    {

        /// <summary>
        /// Extracts the exponent from x; Returns an integer power of two to 
        /// expnt and the significand between 0.5 and 1 to y. 
        /// Thus x = y * 2**expn.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="pw2"></param>
        /// <returns></returns>
        public static double frexp(double x, ref int pw2 )
        {
            Float64 u = x;
            int k;
                
            ref var q = ref u.x11;
            int i  = (q >> 4) & 0x7ff;
            
            if(i != 0)
            {
                i -= 0x3fe;
                pw2 = i;
                q &= 0x800f;
                q |= 0x3fe0;
                
                return  u ;
            }

            // Number is denormal or zero
            if(u == 0.0 )
            {
                pw2 = 0;
                return 0.0;
            }

            // Handle denormal number.
            do
            {
                u *= 2.0;
                i -= 1;
                k  = ( q >> 4) & 0x7ff;
            }
            while( k == 0 );
            
            i = i + k;
            i -= 0x3fe;
            pw2 = i;
            q &= 0x800f;
            q |= 0x3fe0;
            return  u;
        }

    }
}