//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static ztest;
    
    [DisplayName("arithmetic")]
    public class Arithmetic
    {
        public static void avg()
        {
            var src = slice(Rand.values(real(-500000L), real(500000L)).Take(5000000));
            var avg1 = src.Avg();
            var avg2 = real((long)src.Unwrap().Average());
            Claim.eq(avg1, avg2);
                            
        }

        public static void pow()
        {
            var src = Rand.values(5,real(-5000m), real(5000m));
            var p1 = src.Pow(2);
            var p2 = map(src, x => x*x);            
            Claim.eq(p1,p2);
            tell($"{src}^2 = {p1}");
            
        }

        

    }

}