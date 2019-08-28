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
    using static Nats;

    public class t_perm : UnitTest<t_perm>
    {

        public void invert()
        {
            invert(N12);
            invert(N17);
            invert(N64);
            invert(N31);
            invert(N128);
            invert(N257);
        }

        public void identity()
        {
            identity(N32);         
            identity(N20);
            identity(N17);
            identity(N64);
            identity(N128);
            identity(N21);
            identity(N257);
        }
        

        public void decompose()
        {
            var p = Random.Perm(N12);
            var cycle = p.Cycle(3);
        }

        public void compose()
        {
            compose(N32);         
            compose(N20);
            compose(N17);
            compose(N64);
            compose(N128);
            compose(N21);
            compose(N257);
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