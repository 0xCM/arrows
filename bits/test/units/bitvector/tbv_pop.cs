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

    public class tbv_pop : BitVectorTest<tbv_pop>
    {

        public void pop_generic()
        {
            BitSize bitlen = 128 + 8;
            ByteSize bytelen = (ByteSize)bitlen;
            Claim.eq((int)bytelen, (int)bitlen/8);
            for(var i=0; i<CycleCount; i++)
            {
                var bv = Random.BitVector<ulong>(bitlen);
                var actual = bv.Pop();
                var expect = 0ul;
                var bytes = bv.Bytes;
                for(var j=0; j< bytes.Length; j++)
                    expect += Bits.pop(bytes[j]);
                Claim.eq(expect, actual);
                
            }

        }

        public void pop128()
        {
            var bv = Random.BitVector128();
            var p1 = bv.Pop();

        }


    }

}