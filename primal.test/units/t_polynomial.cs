//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_polynomial : UnitTest<t_polynomial>
    {        

        public void eval_simple()
        {
            //1*x^3 + 2*x^2 
            var p1 = Polynomial.Define((1,3),(2,2));
            Claim.eq(3, p1.Degree);

            var e1 = p1.Eval(2);
            Claim.eq(10,e1);

            //4*x^3 + 2x - 1
            var p2 = Polynomial.Define((4,3),(2,1),(-1,0));
            Trace(() => p2);

            

        }

    }

}