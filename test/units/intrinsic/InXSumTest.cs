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

        public void Sum1()
        {
            var src = Randomizer.Span<short>(Pow2.T05, closed<short>(-250,250));
            var x = src.Sum();
            var y = dinx.sum(src);
            Claim.eq(x,y);            
        }

        public void Sum2()
        {
            var src = Randomizer.Span<int>(Pow2.T08, closed<int>(-250,250));
            var x = src.Sum();
            var y = dinx.sum(src);
            Claim.eq(x,y);            
        }


        public void Sum3()
        {
            var src = Randomizer.Span<float>(Pow2.T09, closed<float>(-250,250));
            var x = (int)src.Sum();
            var y = (int)dinx.sum(src);
            Claim.eq(x,y);            
        }

        public void Sum4()
        {
            var src = Randomizer.Span<double>(Pow2.T09, closed<double>(-250,250));
            var x = src.Sum().Round(2);
            var y = dinx.sum(src).Round(2);
            Claim.eq(x,y);            
        }

    }

}