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
    

    public class tbm_and : UnitTest<tbm_and>
    {
        
        public void and4x4()
        {
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix4();
                var y = Random.BitMatrix4();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = gbits.xor(xBytes, yBytes);
                var expect = BitMatrix4.Define(zBytes);

                var actual = x + y;
                Claim.yea(expect == actual);                
            }


            var lhs = BitMatrix4.Identity;
            var rhs = BitMatrix4.Identity;
            var result = lhs * rhs;
            for(var row=0; row<result.RowCount; row++)
            for(var col=0; col<result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);

        }


        public void and64x64()
        {
            
            for(var i=0; i<Pow2.T08; i++)
            {
                var x = Random.BitMatrix64();
                var y = Random.BitMatrix64();

                var xBytes = x.Bytes().Replicate();
                var yBytes = y.Bytes().Replicate();
                var zBytes = BitRef.and(xBytes,yBytes);
                var expect = BitMatrix64.Load(zBytes);

                var actual = x & y;
                Claim.yea(expect == actual);                
            }

            var lhs = BitMatrix64.Identity;
            var rhs = BitMatrix64.Identity;
            var result = lhs & rhs;
            for(var row=0; row<result.RowCount; row++)
            for(var col=0; col<result.ColCount; col++)    
                Claim.eq(result[row,col], rhs[row,col]);

        }

        public void and8x8()
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