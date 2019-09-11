//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class fmath
    {

        public static float gcd(float lhs, float rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = (x % y);
                x = y;
                y = rem;
            }

            return x;
        }

        public static double gcd(double lhs, double rhs)
        {
            var x = math.abs(lhs);
            var y = math.abs(rhs);
            while (y != 0)
            {
                var rem = x % y;
                x = y;
                y = rem;
            }

            return x;
        } 


    }

}