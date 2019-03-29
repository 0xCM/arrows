//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;


    using static Nats;
    using static zcore;


    public class NatProof
    {

        public static void equality()
        {
            inform(Prove.eq<N16>(16));
            inform(Prove.eq<N512>(512));
            inform(Prove.eq<NatSeq<N8,N2,N1>>(821));
        }
        public static void smaller()
        {
            inform(Prove.smaller(N11, N12));
            inform(Prove.smaller(N512, N1024));
        }

        public static void larger()
        {
            inform(Prove.larger(N12,N11));
            inform(Prove.larger(N1024,N512));

        }

        public static void nonzero()
        {
            inform(Prove.nonzero(N12));
            inform(Prove.nonzero(N4));
            inform(Prove.nonzero(N1));

        }

        public static void sum()
        {
            inform(Prove.sum(N5,N5, N10.value));
            inform(Prove.sum(N13,N0, N13.value));
            inform(Prove.sum(N512,N10, 522));
        }

        public static void reflect()
        {
            
            var reflected = Nat.reflect(500, 5000);
            var sumActual = fold(map(reflected, x => x.value), (x,y) => x+ y).ToIntG();
            var sumExpect = range<uint>(500,5000).SumG();
            demand(sumActual == sumExpect, $"{sumActual} != {sumExpect}");       
            demand(range<uint>(1,50).MaxG() == 50);
        }

        public static void product()
        {
            inform(Prove.product(N5,N5, 25));
            inform(Prove.product(N13,N10, 130));
            inform(Prove.product(N512,N10, 5120));
        }

        public static void next()
        {
            inform(Prove.next(N0,N1));            
            inform(Prove.next(N5,N6));            
            inform(Prove.next(N15,N16));
        }

    }


}