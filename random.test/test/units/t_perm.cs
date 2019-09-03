//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    
    public class t_perm : UnitTest<t_perm>
    {
        OpTime Shuffle(int n, int count, out int duplicates)
        {
            duplicates = 0;

            var sw = stopwatch();
            var p0 = Perm.Identity(n);
            var p1 = Polyrand.Shuffle(in p0);
            var p2 = Polyrand.Shuffle(in p0);
            for(var i=0; i<count; i++)
            {
                p1 = Polyrand.Shuffle(in p1);
                p2 = Polyrand.Shuffle(in p2);
                if(p1 == p2)
                    duplicates++;
            }
            
            return (count,snapshot(sw));
        }

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