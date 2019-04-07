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
            Prove.eq<N16>(16);
            Prove.eq<N512>(512);
            Prove.eq<NatSeq<N8,N2,N1>>(821);
        }
        public static void smaller()
        {
            Prove.smaller(N11, N12);
            Prove.smaller(N512, N1024);
        }

        public static void larger()
        {
            Prove.larger(N12,N11);
            Prove.larger(N1024,N512);

        }

        public static void nonzero()
        {
            Prove.nonzero(N12);
            Prove.nonzero(N4);
            Prove.nonzero(N1);

        }

        public static void sum()
        {
            Prove.sum(N5,N5, N10.value);
            Prove.sum(N13,N0, N13.value);
            Prove.sum(N512,N10, 522);
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
            Prove.product(N5,N5, 25);
            Prove.product(N13,N10, 130);
            Prove.product(N512,N10, 5120);
        }

        public static void next()
        {
            Prove.next(N0,N1);            
            Prove.next(N5,N6);            
            Prove.next(N15,N16);
            
            var n11 = Nat.next(N10);
            var n12 = Nat.next(n11);
            var n13 = Nat.next(n12);
            Prove.next(N10,n11);
            Prove.next(n11,n12);
            Prove.next(n12,n13);

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
           var n19 = Nat.next(n18);
           demand(n19.value == 19);
        }

    }


}