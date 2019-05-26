//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using static Nats;
    using static nfunc;

    [DisplayName("natural")]
    public class NatProofTest : UnitTest<NatProofTest>
    {
        

        public static void equality()
        {
            NatProve.eq<N16>(16);
            NatProve.eq<N512>(512);
            NatProve.eq<NatSeq<N8,N2,N1>>(821);
        }
        public static void smaller()
        {
            NatProve.lt(N11, N12);
            NatProve.lt(N512, N1024);
        }

        public static void larger()
        {
            NatProve.gt(N12,N11);
            NatProve.gt(N1024,N512);
        }

        public static void nonzero()
        {
            NatProve.nonzero(N12);
            NatProve.nonzero(N4);
            NatProve.nonzero(N1);

        }

        public static void sum()
        {
            NatProve.add(N5,N5, N10.value);
            NatProve.add(N13,N0, N13.value);
            NatProve.add(N512,N10, 522);
        }

        public static void product()
        {
            NatProve.mul(N5,N5, 25);
            NatProve.mul(N13,N10, 130);
            NatProve.mul(N512,N10, 5120);
        }

        public static void next()
        {
            NatProve.next(N0,N1);            
            NatProve.next(N5,N6);            
            NatProve.next(N15,N16);
            
            var n11 = Nat.next(N10);
            var n12 = Nat.next(n11);
            var n13 = Nat.next(n12);
            NatProve.next(N10,n11);
            NatProve.next(n11,n12);
            NatProve.next(n12,n13);

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
           Claim.eq(n19.value,19);
        }

    }


}