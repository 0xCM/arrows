//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbv_rank : UnitTest<tbv_rank>
    {
        public void rank8u()
        {
            
            void Test()
            {
                var x = Polyrand.BitVector8();
                var pos = Polyrand.Next(1,6);
                
                var actual = x.Rank(pos);
                var expect = 0u;
                for(var i=0; i<= pos; i++)
                    expect += (x[i] ? 1u : 0u);
                Claim.eq(expect, actual);
            }

            Verify(Test);            
        }

        public void rank64u()
        {
            
            void Test()
            {
                var x = Polyrand.BitVector64();
                var pos = Polyrand.Next(1,50);
                
                var actual = x.Rank(pos);
                var expect = 0u;
                for(var i=0; i<= pos; i++)
                    expect += (x[i] ? 1u : 0u);
                Claim.eq(expect, actual);
            }

            Verify(Test);            
        }

    }
}