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
    using static Nats;
    
    public class PermutationTest : UnitTest<PermutationTest>
    {
        OpTime Shuffle(int n, int count, out int duplicates)
        {
            duplicates = 0;

            var sw = stopwatch();
            var p0 = Perm.Identity(n);
            var p1 = Random.Shuffle(in p0);
            var p2 = Random.Shuffle(in p0);
            for(var i=0; i<count; i++)
            {
                p1 = Random.Shuffle(in p1);
                p2 = Random.Shuffle(in p2);
                if(p1 == p2)
                    duplicates++;
            }
            
            return (count,snapshot(sw));
        }

        // public void Shuffle1()
        // {
        //     var p1 = Perm.Define(N4, 'A', 'B', 'C', 'D');            
        //     var p2x = Perm.Define(N4, 'A', 'D', 'C', 'B');
        //     var p2y = p1.Replicate();
        //     Claim.yea(p2x == p2y);                        
        //     var p3 = Random.Shuffle(p1.Replicate());
        //     var p3Set = p3.Terms.ToSet();            
        //     Claim.eq(p3.Length, p3Set.Count);            
        // }

        // public void Shuffle2()
        // {
        //     var p1 = Perm.Define(N26, AsciUpper.All);            
            
        //     for(var i=0; i< Pow2.T08; i++)
        //     {
        //         var p2 = Random.Shuffle(p1.Replicate());
        //         var p3 = Random.Shuffle(p1.Replicate());
        //         var a = p1 == p2;
        //         var b = p1 == p3;
        //         Claim.nea(a && b);
        //     }            
        // }
        
        public void Shuffle3()
        {
            var time = Shuffle(Pow2.T08, Pow2.T11, out int duplicates);
            Claim.eq(0,duplicates);
        }

        public void Shuffle4()
        {
            var time = Shuffle(Pow2.T02, Pow2.T13, out int duplicates);
            Claim.neq(0,duplicates);
        }
            
    }

}