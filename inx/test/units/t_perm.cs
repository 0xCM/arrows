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
    using static nfunc;

    public class t_perm : UnitTest<t_perm>
    {
        public void perm_invert()
        {
            perm_invert_check(n12);
            perm_invert_check(n17);
            perm_invert_check(n64);
            perm_invert_check(n31);
            perm_invert_check(n128);
            perm_invert_check(n257);
        }

        public void perm_identity()
        {
            perm_identity_check(n32);         
            perm_identity_check(n20);
            perm_identity_check(n17);
            perm_identity_check(n64);
            perm_identity_check(n128);
            perm_identity_check(n21);
            perm_identity_check(n257);
        }    

        public void perm_comp()
        {
            perm_comp_check(n32);         
            perm_comp_check(n20);
            perm_comp_check(n17);
            perm_comp_check(n64);
            perm_comp_check(n128);
            perm_comp_check(n21);
            perm_comp_check(n257);
        }

        public void perm_inc()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Inc();
            Claim.eq(p, Perm.Identity(16));
        }

        public void perm_dec()
        {
            var p = Perm.Identity(16);
            for(var i=0; i<16; i++)
                p.Dec();

            Claim.eq(p, Perm.Identity(16));
        }


        public void cycle16()
        {
            var cycle = (Perm16.X3 | Perm16.X5 | Perm16.XA).Cycle();
        }
        
        public void perm_swaps()
        {            
            
            var src = Vec128.Increments((byte)0);

            Swap s = (0,1);
            var x1 = dinx.swap(src, s);
            var x2 = dinx.swap(x1, s);
            Claim.eq(x2, src);

            //Shuffle the first element all the way through to the last element
            var chain = Swap.Chain((0,1), 15);
            var x3 = dinx.swap(src, chain);
            //Trace($"{chain.Format()} |> {src.FormatHex()} = {x3.FormatHex()}");
            Claim.eq(x3[15],(byte)0);            
        }

        void perm_comp_check<N>(N n = default)
            where N : ITypeNat, new()
        {
            var p1 = Random.Perm<N>();
            var p2 = p1 * Perm<N>.Identity;
            Claim.yea(p1 == p2);

        }

        void perm_identity_check<N>(N rep = default)
            where N : ITypeNat, new()
        {
            var permA = Perm<N>.Identity;
            var n = nati<N>();
            Claim.eq(n, permA.Length);
            Claim.eq(n, permA.Terms.Length);

            var terms = range(0, n-1).ToArray();
            Claim.eq(n, terms.Length);

            var permB = Perm.Define(new N(), terms);
            Claim.yea(permA == permB);
        }

        void perm_invert_check<N>(N n = default, int cycles = DefaltCycleCount)
            where N: ITypeNat, new()
        {
            for(var i=0; i<(int)n.value; i++)
            {
                var p1 = Random.Perm(n);
                var p2 = ~ p1;
                var p3 = p1 * p2;                    
                Claim.yea(p3 == Perm<N>.Identity);
            }
        }
    }
}