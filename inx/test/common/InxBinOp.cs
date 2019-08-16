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



    public static class InXOpVerify
    {
        public static void VerifyUnaryOp<T>(IRandomSource random, int blocks, Vec128UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : struct
        {
            var blocklen = Span128<T>.BlockLength;                     
            
            var src = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,src.Length);
                        
            var expect = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = Vec128.Load<T>(ref tmp[0]);
             
                var vX = src.LoadVec128(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyUnaryOp<T>(IRandomSource random, int blocks, Vec256UnaryOp<T> inXOp, Func<T,T> primalOp)
            where T : struct
        {
            var blocklen = Span256<T>.BlockLength;                     
            
            var src = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,src.Length);
                        
            var expect = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(src[offset + i]);

                var vExpect = Vec256.Load<T>(ref tmp[0]);
             
                var vX = src.LoadVec256(block);
                var vActual = inXOp(vX);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyBinOp<T>(IRandomSource random, int blocks, Vec128BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : struct
        {
            var blocklen = Span128<T>.BlockLength;                     
            
            var lhs = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,lhs.Length);
            
            var rhs = random.ReadOnlySpan128<T>(blocks);
            Claim.eq(blocks*blocklen,rhs.Length);
            
            var expect = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span128.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                var vExpect = Vec128.Load<T>(ref tmp[0]);
             
                var vX = lhs.LoadVec128(block);
                var vY = rhs.LoadVec128(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

        public static void VerifyBinOp<T>(IRandomSource random, int blocks, Vec256BinOp<T> inXOp, Func<T,T,T> primalOp)
            where T : struct
        {
            var blocklen = Span256<T>.BlockLength;                     
            
            var lhs = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,lhs.Length);
            
            var rhs = random.ReadOnlySpan256<T>(blocks);
            Claim.eq(blocks*blocklen,rhs.Length);
            
            var expect = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, expect.BlockCount);

            var actual = Span256.AllocBlocks<T>(blocks);
            Claim.eq(blocks, actual.BlockCount);

            var tmp = new T[blocklen];
            
            for(var block = 0; block < blocks; block++)
            {
                var offset = block*blocklen;
                for(var i =0; i<blocklen; i++)
                    tmp[i] = primalOp(lhs[offset + i], rhs[offset + i]);

                var vExpect = Vec256.Load<T>(ref tmp[0]);
             
                var vX = lhs.LoadVec256(block);
                var vY = rhs.LoadVec256(block);
                var vActual = inXOp(vX,vY);

                Claim.eq(vExpect, vActual);
            
                ginx.store(vExpect, ref expect.Block(block));
                ginx.store(vActual, ref actual.Block(block));
            }
            Claim.eq(expect, actual);
        }

    }

}