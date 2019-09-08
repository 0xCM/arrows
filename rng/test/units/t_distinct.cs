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
    using System.Runtime.InteropServices;
    
    using static zfunc;
    
    public class t_distinct : UnitTest<t_distinct>
    {

        public void allSelected()
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


        public void testMemory()
        {

            
            var src = MemorySpan.From(Random.Memory<uint>(Pow2.T08));
            Claim.eq(src.Length, Pow2.T08);

            var dst = src.As<ulong>();
            Claim.eq(dst.Length << 1, src.Length);



        }
    }

}