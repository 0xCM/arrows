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


    public class PermutationTests : UnitTest<PermutationTests>
    {
        public void Swap()
        {
            var subject = Vec256.FromParts(2, 4, 6, 8, 10, 12, 14, 16);
            var swapped = dinx.swap(subject, 2, 3);
            var expect = Vec256.FromParts(2, 4, 8, 6, 10, 12, 14, 16);
            Claim.eq(expect, swapped);
        }

        public void ReverseU32()
        {
            var src = Random.CpuVec256Stream<uint>().Take(Pow2.T14);
            foreach(var v in src)
            {
                var expect = Vec256.FromParts(v[7],v[6],v[5],v[4],v[3],v[2],v[1],v[0]);
                var actual = dinx.reverse(v);
                
                if(actual != expect)
                {
                    Trace(actual.FormatHex());
                    Trace(expect.FormatHex());
                }
                Claim.eq(expect, actual);
            }
        }

        public void ReverseF32()
        {
            var src = Random.CpuVec256Stream<float>().Take(Pow2.T14);
            foreach(var v in src)
            {
                var expect = Vec256.FromParts(v[7],v[6],v[5],v[4],v[3],v[2],v[1],v[0]);
                var actual = dinx.reverse(v);
                
                if(actual != expect)
                {
                    Trace(actual.FormatHex());
                    Trace(expect.FormatHex());
                }
                Claim.eq(expect, actual);
            }
        }
    }
}