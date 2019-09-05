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
        public void invert()
        {
            invert(n12);
            invert(n17);
            invert(n64);
            invert(n31);
            invert(n128);
            invert(n257);
        }

        public void identity()
        {
            identity(n32);         
            identity(n20);
            identity(n17);
            identity(n64);
            identity(n128);
            identity(n21);
            identity(n257);
        }
        

        public void decompose()
        {
            var p = Random.Perm(n12);
            var cycle = p.Cycle(3);
        }

        public void compose()
        {
            compose(n32);         
            compose(n20);
            compose(n17);
            compose(n64);
            compose(n128);
            compose(n21);
            compose(n257);
        }

        public void cycle16()
        {
            var cycle = (Perm16.X3 | Perm16.X5 | Perm16.XA).Cycle();
            Trace( () => cycle);
        }
        
        public void swaps()
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

        void compose<N>(N n = default)
            where N : ITypeNat, new()
        {
            var p1 = Random.Perm<N>();
            var p2 = p1 * Perm<N>.Identity;
            Claim.yea(p1 == p2);

        }

        void identity<N>(N rep = default)
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

        void invert<N>(N n = default, int cycles = DefaltCycleCount)
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