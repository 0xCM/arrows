//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rng
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    
    public class t_wyhash : UnitTest<t_wyhash>
    {

        public void TestSuite()
        {
            var dim = N12.Rep;
            var trials = Pow2.T16;
            var maxVal = (ulong)Pow2.T07;
            var maxVec = Vector.Alloc(dim,maxVal);
            var buckets = new ulong[maxVal];


            var suite = RNG.WyHash64Suite(dim);
            for(var i=0; i<trials; i++)
            {
                var vector = suite.Next<ulong>();
                var contracted = vector.Contract(maxVec);
                for(var j = 0; j<dim; j++)
                {
                    var x = contracted[j];
                    Claim.lteq(x, maxVal);
                    ++buckets[x];
                }
            }

            var indices = Polyrand.Array<int>(10, leftopen(0, buckets.Length));
            var bucketSample = buckets.Values(indices);
            var avg = (double)gmath.avg<ulong>(bucketSample);
            var deltas = bucketSample.Map(c => (math.abs(1 - ((double)c / avg)).Round(4)));
            var tolerance = .1;
            var intolerant = deltas.Where(x => x > tolerance).Count();
            Claim.eq(intolerant, 0);
            
            


        }

    }

}
