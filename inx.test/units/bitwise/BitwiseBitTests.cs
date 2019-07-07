//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;


    using static zfunc;


    public class BitwiseBitTests : UnitTest<BitwiseBitTests>
    {
        public void TestSpanBits()
        {
            var src = Random.Span<byte>(Pow2.T03);
            var bvSrc = BitVector64.Define(BitConverter.ToUInt64(src));

            for(var i=0; i< Pow2.T03*8; i++)
                Claim.eq(src.TestBit(i), bvSrc.TestBit(i));
        }

    }

}


