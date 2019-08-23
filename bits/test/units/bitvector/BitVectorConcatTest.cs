//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static Nats;
    using static BitRef;


    public class BitVectorConcatTest : UnitTest<BitVectorConcatTest>
    {

        public void Concat88()
        {
            var head = BitVector8.FromScalar(0b10100);
            var tail = BitVector8.FromScalar(0b111);
            var whole = head.Concat(tail);
            Claim.eq(head, whole.Hi);
            Claim.eq(tail, whole.Lo);
            var bsWhole = whole.ToBitString();
            var bsHead = head.ToBitString();
            var bsTail = tail.ToBitString();
            Trace(() => bsWhole);
            Trace(() => bsHead);
            Trace(() => bsTail);
            Claim.eq(bsWhole, bsHead + bsTail);

            

        }


    }
}