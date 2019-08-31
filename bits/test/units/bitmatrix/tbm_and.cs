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
        protected override int SampleSize
            => Pow2.T14;

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
                var zBytes = gmath.and(xBytes,yBytes);
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

        public void benchmarks()
        {
            Collect(and16x16_bench());
            Collect(and32x32_bench());
            Collect(and64x64_bench());
        }


        OpTime and16x16_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitMatrix16();
                var y = Random.BitMatrix16();
                sw.Start();
                var result = x & y;                               
                sw.Stop();
            }
            return(SampleSize, sw, "bm_and_16x16");            
        }

        OpTime and64x64_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitMatrix64();
                var y = Random.BitMatrix64();
                sw.Start();
                var result = x & y;                               
                sw.Stop();
            }
            return(SampleSize, sw, "bm_and_64x64");            
        }

        OpTime and32x32_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitMatrix32();
                var y = Random.BitMatrix32();
                sw.Start();
                var result = x & y;                               
                sw.Stop();
            }
            return(SampleSize, sw, "bm_and_32x32");            
        }

    }

}