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

    
    public class t_shuffle : UnitTest<t_shuffle>
    {

        public void InBounds()
        {
            var max = 30;
            for(var i=0; i<SampleSize; i++)
            {
                var next = Random.Next(max);
                Claim.lt(next,max);
            }
        }

        public void Shuffle1()
        {
            var src = Perm.Identity(24);
            Perm dst0 = src;
            Perm dst1 = Random.Shuffle(src.Replicate());
            Perm dst2 = Random.Shuffle(src.Replicate());
            Perm dst3 = Random.Shuffle(src.Replicate());

            Claim.eq(dst1.Length, src.Length);
            Claim.eq(dst2.Length, src.Length);
            Claim.eq(dst3.Length, src.Length);

        }

    }

}
