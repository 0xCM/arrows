//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class tbv_rank : BitVectorTest<tbv_rank>
    {
        public void bvrank_8()
        {
            
            void Test()
            {
                var x = Random.BitVector8();
                var pos = Random.Next(1,6);
                
                var actual = x.Rank(pos);
                var expect = 0u;
                for(var i=0; i<= pos; i++)
                    expect += (x[i] ? 1u : 0u);
                Claim.eq(expect, actual);
            }

            Verify(Test);            
        }

        public void bvrank_64()
        {
            
            void Test()
            {
                var x = Random.BitVector64();
                var pos = Random.Next(1,50);
                
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