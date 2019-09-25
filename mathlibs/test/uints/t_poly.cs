//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    public class t_poly : MathTest<t_poly>
    {

        static unsafe double polevl(double[] coef)
        {
            var ans = coef[0];
            var x = ans;
            var N = coef.Length - 1;
            
            for(var i = N; i> 0; i--)
            {
                ans = ans * x + coef[i];
            }
            
            return ans;
        }


        public void polyeval_64f()
        {
            const string literal = "4x^3 + 3x^2 + 8x + 1";

            var p1 = Polynomial.Define((4.0,3),(3.0,2),(8.0,1),(1.0,0));
            Claim.eq(literal, p1.Format());
            Claim.eq(p1.Degree, 3);
            Claim.eq(p1.Terms.Length, 4);

            Span<double> p1Ev = stackalloc double[(int)p1.Degree + 1];

            var x = 2;
            var deg = (int)p1.Degree;
            Claim.eq(p1[deg].Exp, 3u);
            Claim.eq(p1[deg].Scalar, 4);
            p1Ev[deg] = p1[deg].Scalar*math.pow(x, p1[deg].Exp);
            Claim.eq(p1[deg].Eval(x), p1Ev[deg]);

            deg--;
            Claim.eq(p1[deg].Exp, 2u);
            Claim.eq(p1[deg].Scalar, 3);
            p1Ev[deg] = p1[deg].Scalar*math.pow(x,p1[deg].Exp);
            Claim.eq(p1[deg].Eval(x), p1Ev[deg]);

            deg--;
            Claim.eq(p1[deg].Exp, 1u);
            Claim.eq(p1[deg].Scalar, 8);
            p1Ev[deg] = p1[deg].Scalar*math.pow(x,p1[deg].Exp);
            Claim.eq(p1[deg].Eval(x), p1Ev[deg]);

            deg--;
            Claim.eq(p1[deg].Exp, 0u);
            Claim.eq(p1[deg].Scalar, 1);
            p1Ev[deg] = p1[deg].Scalar*math.pow(x,p1[deg].Exp);
            Claim.eq(p1[deg].Eval(x), p1Ev[deg]);

            
            var p1EvA = p1Ev.Sum();
            var p1EvB = p1.Eval(x);
            Claim.eq(p1EvA, p1EvB);

        }


    }

}