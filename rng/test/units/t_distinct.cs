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
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    public class t_distinct : UnitTest<t_distinct>
    {
        public void all_selected()
        {
            var pool = 100;
            var segment = 25;
            var attempts = Pow2.T10;
            var selected = set<int>();
            for(var i=0; i<attempts; i++)
            {
                selected.AddRange(Random.SampleDistinct(pool, segment));
                if(selected.Count == pool)
                    return;
            }
            var missing = pool - segment;
            Claim.fail($"{missing} members of the sample remain unselected");
        }

    }

}