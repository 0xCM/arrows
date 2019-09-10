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


    public class tv_max : UnitTest<tv_max>
    {
        
        public void max128_i32()
        {
            var blocklen = Span128<int>.BlockLength;                     
            var lhs = Random.ReadOnlySpan128<int>(SampleSize);
            var rhs = Random.ReadOnlySpan128<int>(SampleSize);
            var expect = Span128.AllocBlocks<int>(SampleSize);
            var actual = Span128.AllocBlocks<int>(SampleSize);
            
            for(var block = 0; block<SampleSize; block++)
            {
                var offset = block*blocklen;

                Span<int> tmp = stackalloc int[blocklen];
                for(var i =0; i<blocklen; i++)
                    tmp[i] = gmath.max(lhs[offset + i], rhs[offset + i]);
                var vExpect = Vec128.Load(ref tmp[0]);
             
                var vX = lhs.LoadVec128(block);
                var vY = rhs.LoadVec128(block);
                var vActual = ginx.max(vX,vY);

                Claim.eq(vExpect, vActual);

                vstore(vExpect, ref expect.Block(block));
                vstore(vActual, ref actual.Block(block));

            }
            Claim.eq(expect, actual);
        }

        public void max256_i32()
        {
            var blocklen = Span256<int>.BlockLength;                     
            var lhs = Random.ReadOnlySpan256<int>(SampleSize);
            var rhs = Random.ReadOnlySpan256<int>(SampleSize);
            var expect = Span256.AllocBlocks<int>(SampleSize);
            var actual = Span256.AllocBlocks<int>(SampleSize);
            
            for(var block = 0; block<SampleSize; block++)
            {
                var offset = block*blocklen;

                Span<int> tmp = stackalloc int[blocklen];
                for(var i =0; i<blocklen; i++)
                    tmp[i] = gmath.max(lhs[offset + i], rhs[offset + i]);
                var vExpect = Vec256.Load(ref tmp[0]);
             
                var vX = lhs.LoadVec256(block);
                var vY = rhs.LoadVec256(block);
                var vActual = ginx.max(vX,vY);

                Claim.eq(vExpect, vActual);

                vstore(vExpect, ref expect.Block(block));
                vstore(vActual, ref actual.Block(block));

            }
            Claim.eq(expect, actual);


        }


    }

}