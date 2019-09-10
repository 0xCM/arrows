//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
// Derived from: Cephes Math Library Release 2.8:  June, 2000
// Copyright 1984, 1995, 2000 by Stephen L. Moshier
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class cephes
    {

        /*							
        *
        *	Evaluate polynomial
        *
        *
        *
        * SYNOPSIS:
        *
        * int N;
        * double x, y, coef[N+1], polevl[];
        *
        * y = polevl( x, coef, N );
        *
        *
        *
        * DESCRIPTION:
        *
        * Evaluates polynomial of degree N:
        *
        *                     2          N
        * y  =  C  + C x + C x  +...+ C x
        *        0    1     2          N
        *
        * Coefficients are stored in reverse order:
        *
        * coef[0] = C  , ..., coef[N] = C  .
        *            N                   0
        *
        *
        *
        * SPEED:
        *
        * In the interest of speed, there are no checks for out
        * of bounds arithmetic.  This routine is used by most of
        * the functions in the library.  Depending on available
        * equipment features, the user may wish to rewrite the
        * program in microcode or assembly language.
        *
        */
        public static double polevl(double x, double[] coef, int N)
        {
            var ans = coef[0];
            var i = N;

            do ans = ans * x + coef[i]; 
                while( --i != 0 );

            return ans ;
        }    

        /*  The function p1evl() assumes that coef[N] = 1.0 and is omitted from 
        the array. Its calling arguments are otherwise the same as polevl()*/
        public static double p1evl(double x, double[] coef, int N)
        {
            var p = coef;
            var ans = x + p[0];
            var i = N-1;

            do ans = ans * x + coef[i]; 
                while( --i != 0 );

            return ans ;
        }    
    }
}