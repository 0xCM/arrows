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


    public class InXAddTest : UnitTest<InXAddTest>
    {
        public void AddI32()
        {
            var blocks = Pow2.T08;   
            var blocklen = Span128<int>.BlockLength;                     
            var lhs = Randomizer.ReadOnlySpan128<int>(blocks);
            var rhs = Randomizer.ReadOnlySpan128<int>(blocks);
            var expect = Span128.alloc<int>(blocks);
            var actual = Span128.alloc<int>(blocks);
            
            for(var block = 0; block<blocks; block++)
            {
                var offset = block*blocklen;

                Span<int> tmp = stackalloc int[blocklen];
                for(var i =0; i<blocklen; i++)
                    tmp[i] = gmath.add(lhs[offset + i], rhs[offset + i]);
                var vExpect = Vec128.load(ref tmp[0]);
             
                var vX = lhs.Vector(block);
                var vY = rhs.Vector(block);
                var vActual = ginx.add(vX,vY);

                Claim.eq(vExpect, vActual);

                dinx.store(vExpect, ref expect.Block(block));
                dinx.store(vActual, ref actual.Block(block));

            }
            Claim.eq(expect, actual);

        }

    }

}