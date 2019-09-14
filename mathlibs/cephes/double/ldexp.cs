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

    partial class cephes
    {
        const ushort EXPMSK = 0x800f;
        
        const ushort MEXP = 0x7ff;
        
        const int NBITS  = 53;

        /// <summary>
        /// Computes y = x*2^i
        /// </summary>
        /// <param name="x"></param>
        /// <param name="pw2"></param>
        public static double ldexp(double x, int pw2)
        {
            Float64 u = x;
            ref var q = ref u.x11;
            int e = 0;

            while((e = (q & 0x7ff0) >> 4) == 0 )
            {
                if( u.data == 0.0 )
                    return( 0.0 );
                
                /* Input is denormal. */
                if(pw2 > 0)
                {
                    u.data *= 2.0;
                    pw2 -= 1;
                }
                
                if(pw2 < 0 )
                {
                    if(pw2 < -53)
                        return(0.0);
                    
                    u.data /= 2.0;
                    pw2 += 1;
                }
                
                if( pw2 == 0 )
                    return u.data;
            }

            e += pw2;

            if(e >= MEXP)
                return( 2.0*MAXNUM );

            /* Handle denormalized results */
            if( e < 1 )
	        {
	            if( e < -53 )
		        return(0.0);
	            q &= 0x800f;
	            q |= 0x10;

                /* For denormals, significant bits may be lost even
                when dividing by 2.  Construct 2^-(1-e) so the result
                is obtained with only one multiplication.  */
                u.data *= ldexp(1.0, e-1);
                return(u.data);
	        }
            else
	        {
                q &= 0x800f;
                q |= (ushort)((e & 0x7ff) << 4);            	
                return(u.data);         
            }
        }
    }
}
