//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static nfunc;
    using static Nats;
    public class VectorDotTest : UnitTest<VectorDotTest>
    {
        static float relerr(float a, float b)        
            => a == 0 ? 0 : MathF.Abs(b - a)/a;

        static double relerr(double a, double b)        
            => a == 0 ? 0 : Math.Abs(b - a)/a;
        
        static bool close<T>(T lhs, T rhs, T? epsilon = null)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return relerr(As.float32(lhs), As.float32(rhs)) < (epsilon.HasValue ? As.float32(epsilon.Value) :  .1f);
            else if(typeof(T) == typeof(double))
                return relerr(As.float64(lhs), As.float64(rhs)) < (epsilon.HasValue ? As.float64(epsilon.Value) :  .01d);
            else
                return gmath.eq(lhs,rhs);
        }

        OpTime Dot<N,T>(int count, Interval<T> domain,  N n = default, T t0 = default)
            where N : ITypeNat, new()
            where T : struct
        {
            var v1 = Vector.Alloc<N,T>();
            var v2 = Vector.Alloc<N,T>();            
            var sw = stopwatch(false);            
            for(var i=0; i<count; i++)
            {
                Random.Fill(domain, ref v1);
                Random.Fill(domain, ref v2);
                sw.Start();
                var x1 = VectorOps.Dot(v1,v2);
                sw.Stop();                
                
                var x2 = gmath.dot<T>(v1.Unsized, v2.Unsized);
                var areClose = close(x1,x2);
                if(!areClose)
                {
                    Trace($"x1 = {x1}, x2 = {x2}");
                }
                Claim.yea(areClose);
            }
            
            return (count, snapshot(sw), $"dot<N{nati<N>()},{PrimalKinds.kind<T>()}>");
        }


        public void Dot()
        {
            
            TracePerf(Dot(Pow2.T08, closed(-102489d, 102489d),  N30, 0d));
        }

        void DotAvx()
        {
            var domain = closed(-2500, 2500);
            var v1Src = Random.Span256<int>(1,domain);
            var v1 = Vec256.Load(v1Src);
            var v2Src = Random.Span256<int>(1,domain);
            var v2 = Vec256.Load(v2Src);
            var a0 = dinx.dot(v1,v2);
            var a1 = (long)math.dot(v1Src, v2Src);
            Claim.eq(a0,a1);
        }
 
        public void DotTest()
        {
            


            
        }

    }

}