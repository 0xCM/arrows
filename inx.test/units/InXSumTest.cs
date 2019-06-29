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


    public class InXSumTest : UnitTest<InXSumTest>
    {
        void Sum<T>(int samples)
            where T : struct
        {
            // var zero = gmath.zero<T>();
            // var lMin = gmath.sub(zero, literal<T>(250));
            // var rMax = gmath.add(zero, literal<T>(250));
            // var src = Randomizer.Span<T>(Pow2.T05, closed(lMin,rMax));
            // Claim.eq(x,y);            

        }

        public void Sum1()
        {
            var src = Random.Span<short>(Pow2.T05, closed<short>(-250,250));
            var x = src.Sum();
            var y = src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum2()
        {
            var src = Random.Span<int>(Pow2.T08, closed<int>(-250,250));
            var x = src.Sum();
            var y = src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum3()
        {
            var src = Random.Span<float>(Pow2.T09, closed<float>(-250,250));
            var x = (int)src.Sum();
            var y = (int)src.Sum(NumericSystem.Intrinsic);
            Claim.eq(x,y);            
        }

        public void Sum4()
        {
            var src = Random.Span<double>(Pow2.T09, closed<double>(-250,250));
            var x = src.Sum().Round(2);
            var y = src.Sum(NumericSystem.Intrinsic).Round(2);
            Claim.eq(x,y);            
        }

    }

}