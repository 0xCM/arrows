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
    using static Nats;
    
    public class PermutationTest : UnitTest<PermutationTest>
    {

        public void Test1()
        {
            var p1 = Permutation.Define(N4, 'A', 'B', 'C', 'D');            
            var p2x = Permutation.Define(N4, 'A', 'D', 'C', 'B');
            var p2y = p1.Replicate(2,4);
            Claim.yea(p2x == p2y);
                        
            var p3 = Random.Shuffle(p1.Replicate());
            var p3Set = p3.Terms.ToSet();            
            Claim.eq(p3.Length, p3Set.Count);
            
        }

        public void Test2()
        {
            var p1 = Permutation.Define(N26, AsciUpper.All);            
            
            for(var i=0; i< Pow2.T08; i++)
            {
                var p2 = Random.Shuffle(p1.Replicate());
                var p3 = Random.Shuffle(p1.Replicate());
                var a = p1 == p2;
                var b = p1 == p3;
                Claim.nea(a && b);
            }            
        }
    }

}