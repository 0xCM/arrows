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



    public static class InXBinOp
    {
        public static void Verify<T>(IRandomSource random, int blocks, Vec128BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : struct
        {
            var blocklen = Span128<T>.BlockLength;                     
            var lhs = random.ReadOnlySpan128<T>(blocks);
            var rhs = random.ReadOnlySpan128<T>(blocks);
            var expect = Span128.alloc<T>(blocks);
            var actual = Span128.alloc<T>(blocks);
            var tmp = new T[blocklen];
            
            for(var block = 0; block<blocks; block++)
            {
                var offset = block*blocklen;

                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                var vExpect = Vec128.load<T>(ref tmp[0]);
             
                var vX = lhs.LoadVec128(block);
                var vY = rhs.LoadVec128(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }
    }

}