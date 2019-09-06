//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_ldexp : UnitTest<t_ldexp>
    {

        [MethodImpl(Inline)]
        static double ldexp(double x, int i)
            => x * Math.Pow(2.0, i);

        public void ldexp()
        {
            var src = Random.Stream<double>();
            var powers =  Random.Stream(-50,50);
            var tolerance = .001;
            for(var i=0; i< SampleSize; i++)
            {
                var x = src.First();
                var e = powers.First();
                
                var a = cephes.ldexp(x,e);
                var b = ldexp(x,e);

                Claim.lt(fmath.relerr(a,b), tolerance);
            }
        }

        
    }

}