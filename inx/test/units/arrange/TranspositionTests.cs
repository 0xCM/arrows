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

    public class TranspositionTests : UnitTest<TranspositionTests>
    {

        void VerifyComposition<N,T>(N n = default, T rep = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var p1 = Random.Perm<N,T>();
            var p2 = p1 * Perm<N,T>.Identity;
            Claim.yea(p1 == p2);

        }

        void VerifyIdentity<N,T>(N rep = default, T scalar = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var permA = Perm<N,T>.Identity;
            var n = nati<N>();
            Claim.eq(n, permA.Length);
            Claim.eq(n, permA.Terms.Length);

            var terms = range(gmath.zero<T>(), convert<int,T>(n - 1)).ToArray();
            Claim.eq(n, terms.Length);

            var permB = Perm.Define(new N(), terms);
            Claim.yea(permA == permB);

        }

        void VerifyIdentity<N>(N rep = default)
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

        void VerifyInversion<N>(N n = default, int cycles = DefaltCycleCount)
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

        public void VerifyInversion()
        {
            VerifyInversion(N12);
            VerifyInversion(N17);
            VerifyInversion(N64);
        }

        public void VerifyIdentities()
        {
            VerifyIdentity<N32,byte>();   
            VerifyIdentity(N32);         
            VerifyIdentity<N20,int>();            
            VerifyIdentity(N20);
            VerifyIdentity(N17, 0ul);
            VerifyIdentity(N17);
            VerifyIdentity(N64, (sbyte)0);
            VerifyIdentity(N64);
            VerifyIdentity(N128, 0u);
            VerifyIdentity(N128);
            VerifyIdentity(N17, 0L);
            VerifyIdentity(N21);
        }
        

        public void VerifyDecomposition()
        {
            var p = Random.Perm(N12);

            var cycle = p.Cycle(3);
            Trace(p.Format());
            Trace(cycle.Format());
        }

        public void VerifyComposition()
        {
            VerifyComposition(N22, 0);
            VerifyComposition(N25, 0L);
        }
        
        public void Transpose128u8()
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

    }
}