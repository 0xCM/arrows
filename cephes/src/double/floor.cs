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

        public static double floor(double x)
        {
            Float64 u = x;
            ref var p = ref u.x11;

            if(isnan(x) || isinfinite(x) || x == 0.0)
                return x;

            /* find the exponent (power of 2) */	
            var e = (( p >> 4) & 0x7ff) - 0x3ff;
            p -= 3;

            if( e < 0 )
            {
                if( u.data < 0.0 )
                    return( -1.0 );
                else
                    return( 0.0 );
            }

    	    e = (NBITS -1) - e;
	
            /* clean out 16 bits at a time */
            if(e >= 16)
            {
                p = 0;
                p = ref u.x10;
                e -= 16;
            }

            if(e >= 16)
            {
                p = 0;
                p = ref u.x01;
                e -= 16;
            }

            if(e >= 16)
            {
                p = 0;
                p = ref u.x00;
                e -= 16;
            }

            /* clear the remaining bits */
            if( e > 0 )
                p &= bmask[e];

            if( (x < 0) && (u.data != x) )
                u.data -= 1.0;

	        return u;
        }
        
        internal static class Floor
        {
            public static ushort[] bmask = {
                0xffff,
                0xfffe,
                0xfffc,
                0xfff8,
                0xfff0,
                0xffe0,
                0xffc0,
                0xff80,
                0xff00,
                0xfe00,
                0xfc00,
                0xf800,
                0xf000,
                0xe000,
                0xc000,
                0x8000,
                0x0000,
            };

        }



    }




}



