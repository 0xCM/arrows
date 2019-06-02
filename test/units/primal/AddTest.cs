//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using D = PrimalDelegates;

    public class AddTest : UnitTest<AddTest>
    {
        public void AddI32Fused()
        {
            var lhsSrc = Randomizer.ReadOnlySpan<int>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Randomizer.ReadOnlySpan<int>(lhsSrc.Length);
            lhs.Add(rhs);           

            var expect = span<int>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.@true(lhs.Eq(expect));

        }

        public void AddI64Fused()
        {
            var lhsSrc = Randomizer.ReadOnlySpan<long>(Pow2.T10);  
            var lhs = lhsSrc.Replicate();
            var rhs = Randomizer.ReadOnlySpan<long>(lhsSrc.Length);
            lhs.Add(rhs);           

            var expect = span<long>(lhs.Length);
            for(var i =0; i< lhsSrc.Length; i++)
                expect[i] = lhsSrc[i] + rhs[i];
            
            Claim.@true(lhs.Eq(expect));

        }

    }

}
