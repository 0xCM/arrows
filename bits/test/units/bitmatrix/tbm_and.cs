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

        public void bm_and_4x4x4()
        {            
            for(var i=0; i<CycleCount; i++)
            {
                var x = Random.BitMatrix4();
                var y = Random.BitMatrix4();

                var xBytes = x.Data.Replicate();
                var yBytes = y.Data.Replicate();
                var zBytes = gbits.xor(xBytes, yBytes);
                var expect = BitMatrix4.Define(zBytes);

                var actual = x + y;
                Claim.yea(expect == actual);                
            }
        }

        public void bm_and_8x8x8()
        {
            for(var i=0; i<CycleCount; i++)
            {
                var A = Random.BitMatrix8();
                var B = Random.BitMatrix8();

                var xBytes = A.Bytes.Replicate();
                var yBytes = B.Bytes.Replicate();
                var zBytes = gbits.and(xBytes,yBytes);
                var expect = BitMatrix8.From(zBytes);

                var C = A & B;
                Claim.yea(expect == C);                
            }
        }

        public void bm_and_8x8x8g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N8,byte>();
                var B = Random.BitMatrix<N8,byte>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bm_and_8x8x8g"));            
        }

        public void bm_and_16x16x16_bench()
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
            Collect((SampleSize, sw, "bm_and_16x16x16"));            
        }

        public void bm_and_16x16x16g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N16,ushort>();
                var B = Random.BitMatrix<N16,ushort>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bm_and_16x16x16g"));            
        }

        public void bm_and_32x32x32()
        {            
            for(var i=0; i<CycleCount; i++)
            {
                var A = Random.BitMatrix32();
                var B = Random.BitMatrix32();

                var xBytes = A.Bytes.Replicate();
                var yBytes = B.Bytes.Replicate();
                var zBytes = gbits.and(xBytes,yBytes);
                var expect = BitMatrix32.From(zBytes);

                var C = A & B;
                Claim.yea(expect == C);                
            }
        }

        public void bm_and_32x32x32_bench()
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
            OpTime time = (SampleSize, sw, "bm_and_32x32x32");            
            Collect(time);
        }

        public void bm_and_32x32x32g()
        {            
            for(var i=0; i<CycleCount; i++)
            {
                var A = Random.BitMatrix<N32,uint>();
                var B = Random.BitMatrix<N32,uint>();
                var C1 = BitMatrix.and(in A, in B);
                var C2 = BitMatrix32.From(C1);
                var C3 = BitMatrix32.From(A) & BitMatrix32.From(B);
                Claim.yea(C2 == C3);                    
            }
        }

        public void bm_and_32x32x32g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N32,uint>();
                var B = Random.BitMatrix<N32,uint>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bm_and_32x32x32g"));            
        }

        public void bm_and_63x63x8g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N63,byte>();
                var B = Random.BitMatrix<N63,byte>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bm_and_63x63x8g"));            
        }

        public void bm_and_64x64x64()
        {            
            for(var i=0; i<CycleCount; i++)
            {
                var A = Random.BitMatrix64();
                var B = Random.BitMatrix64();

                var xBytes = A.Bytes.Replicate();
                var yBytes = B.Bytes.Replicate();
                var zBytes = gbits.and(xBytes,yBytes);
                var expect = BitMatrix64.From(zBytes);

                var C = A & B;
                Claim.yea(expect == C);                
            }
        }

        public void bm_and_64x64x64_bench()
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
            Collect((SampleSize, sw, "bm_and_64x64x64"));            
        }

        public void bm_and_64x64x64g()
        {
            for(var i=0; i<CycleCount; i++)
            {
                var A = Random.BitMatrix<N64,ulong>();
                var B = Random.BitMatrix<N64,ulong>();
                var C1 = BitMatrix.and(in A, in B);
                var C2 = BitMatrix64.From(C1);
                var C3 = BitMatrix64.From(A) & BitMatrix64.From(B);
                Claim.yea(C2 == C3);                    
            }
        }
         

        public void bm_and_64x64x64g_bench()
        {
            var sw = stopwatch(false);
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix<N64,ulong>();
                var B = Random.BitMatrix<N64,ulong>();
                sw.Start();
                var result = A & B;                               
                sw.Stop();
            }
            Collect((SampleSize, sw, "bm_and_64x64x64g"));            
        }


    }

}