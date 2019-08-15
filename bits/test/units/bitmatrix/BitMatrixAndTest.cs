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

    using static zfunc;
    

    public class BitMatrixAndTest : UnitTest<BitMatrixAndTest>
    {
        public void BitLookup4()
        {
            var lhs = BitMatrix4.Identity;
            var rhs = BitMatrix4.Identity;
            var result = lhs * rhs;
            for(var row=0; row<result.RowDim; row++)
            for(var col=0; col<result.ColDim; col++)    
                Claim.eq(result[row,col], rhs[row,col]);

        }
        
        public void And4()
        {
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix4();
                var y = Random.BitMatrix4();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = xBytes.XOr(yBytes);
                var expect = BitMatrix4.Define(zBytes);

                var actual = x + y;
                Claim.yea(expect == actual);                
            }

        }

        public void BitLookup64()
        {
            var lhs = BitMatrix64.Identity;
            var rhs = BitMatrix64.Identity;
            var result = lhs & rhs;
            for(var row=0; row<result.RowCount; row++)
            for(var col=0; col<result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);

        }

        public void And64()
        {
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix64();
                var y = Random.BitMatrix64();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = gbits.and(xBytes,yBytes);
                var expect = BitMatrix64.Load(zBytes);

                var actual = x & y;
                Claim.yea(expect == actual);                
            }
        }

        public void And8()
        {
            var lhs = BitMatrix8.Identity;
            var rhs = BitMatrix8.Identity;
            var result = lhs & rhs;
            for(var row=0; row< result.RowCount; row++)
            for(var col=0; col< result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);
        }

    }

}