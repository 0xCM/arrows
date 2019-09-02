//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_perm : UnitTest<ts_perm>
    {

        public void perm_create()
        {
            perm_create(5,20);
            perm_create((byte)5,(byte)100);
        }

        public void perm_swap()
        {
            var id = PermG.Identity((byte)32);
            var p = id.Replicate();
            p.Swap(3,4).Swap(4,5).Swap(5,6);
            Claim.eq(p[6], id[3]);
        }

        void perm_create<T>(T m, T n)
            where T : unmanaged
        {
            
            var perm = PermG<T>.Identity(n);
            var lengths = range(m,n);
            iter(lengths, i => {
                var p = PermG<T>.Identity(i);
                var cycle = p.Cycle(default(T));
                Claim.eq(cycle.Length, 1);                            
            });

        }
    }

}
