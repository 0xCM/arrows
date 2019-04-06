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
    using System.ComponentModel;

    using static Nats;
    using static zcore;
    using static ztest;

    [DisplayName("natural")]
    public class NaturalTest
    {

        public static void equality()
        {
            tell(Prove.eq<N16>(16));
            tell(Prove.eq<N512>(512));
            tell(Prove.eq<NatSeq<N8,N2,N1>>(821));
        }
        public static void smaller()
        {
            tell(Prove.smaller(N11, N12));
            tell(Prove.smaller(N512, N1024));
        }

        public static void larger()
        {
            tell(Prove.larger(N12,N11));
            tell(Prove.larger(N1024,N512));

        }

        public static void nonzero()
        {
            tell(Prove.nonzero(N12));
            tell(Prove.nonzero(N4));
            tell(Prove.nonzero(N1));

        }

        public static void sum()
        {
            tell(Prove.sum(N5,N5, N10.value));
            tell(Prove.sum(N13,N0, N13.value));
            tell(Prove.sum(N512,N10, 522));
        }

        public static void reflect()
        {
            
            var reflected = Nat.reflect(500, 600);
            var sumActual = fold(map(reflected, x => x.value), (x,y) => x+ y).ToIntG();
            var sumExpect = range<uint>(500, 600).Sum();
            demand(sumActual == sumExpect, $"{sumActual} != {sumExpect}");
            demand(range<uint>(1, 50).Sup() == 50, $"{range<uint>(1, 50).Sup()} != 50");
        }

        public static void product()
        {
            tell(Prove.product(N5,N5, 25));
            tell(Prove.product(N13,N10, 130));
            tell(Prove.product(N512,N10, 5120));
        }

        public static void next()
        {
            tell(Prove.next(N0,N1));            
            tell(Prove.next(N5,N6));            
            tell(Prove.next(N15,N16));
            
            var n11 = Nat.next(N10);
            var n12 = Nat.next(n11);
            var n13 = Nat.next(n12);
            tell(Prove.next(N10,n11));
            tell(Prove.next(n11,n12));
            tell(Prove.next(n12,n13));

        }

        public static void iterate()
        {
           var n11 = Nat.next(N10);
           var n12 = Nat.next(n11);
           var n13 = Nat.next(n12);
           var n14 = Nat.next(n13);
           var n15 = Nat.next(n14);
           var n16 = Nat.next(n15);
           var n17 = Nat.next(n16);
           var n18 = Nat.next(n17);
           var n19 = Nat.next(n17);
           tell($"n18: {n19}");
        }

    }


}