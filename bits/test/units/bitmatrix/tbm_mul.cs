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

    public class tbm_mul : UnitTest<tbm_mul>
    {

        protected override int RoundCount => Pow2.T01;

        protected override int CycleCount => Pow2.T12;

        public void bmm8x8()
        {
            bmm8x8_check();
        }

        public void bmm32x32()
        {
            bmm32x32_check();
        }

        public void bmm64x64()
        {
            bmm64x64_check();
        }

        public void bmv8x8()
        {
            bmv8x8_check();            
        }

        public void bmv16x16()
        {
            bmv16x16_check();            
        }

        public void bmv32x32()
        {
            bmv32x32_check();            
        }


        public void bmm4x4_bench()
        {
            Mul4Bench(Pow2.T12);
        }

        public void bmm8x8_bench( )
        {
            var sw = stopwatch(false);
            var last = BitMatrix8.Zero;
            for(var round = 0; round < RoundCount; round++)
            {
                for(var cycle=0; cycle < CycleCount; cycle++)
                {
                    var m1 = Random.BitMatrix8();
                    var m3 = Random.BitMatrix8();
                    sw.Start();
                    last = m1 * m3;
                    sw.Stop();
                }
            }

            Collect((RoundCount*CycleCount, snapshot(sw), "bmm8"));
        }

        public void bmm16_bench()
        {
            Collect(Mul16Bench(Pow2.T12));
        }

        public void bmm64x64_prealloc_bench()
        {
            var reps = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var last = BitMatrix64.Zero;  
            var dst = BitMatrix64.Alloc();          
            for(var rep=0; rep < reps; rep++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = Random.BitMatrix64();
                sw.Start();
                last = BitMatrixOps.Mul(m1, m2, ref dst);
                sw.Stop();                
            }

            Collect((reps, snapshot(sw), "bmm64x64_prealloc"));
        }

        public void bmm64x64_bench()
        {
            var reps = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var last = BitMatrix64.Zero;  
            for(var rep=0; rep < reps; rep++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = Random.BitMatrix64();
                sw.Start();
                last = BitMatrixOps.Mul(m1, m2);
                sw.Stop();                
            }

            Collect((reps, snapshot(sw), "bmm64x64"));
        }


        public void bmm32x32_bench()
        {
            var last = BitMatrix32.Zero;            
            var sw = stopwatch(false);
            var dst = BitMatrix32.Alloc();
            for(var round = 0; round < RoundCount; round++)
            {
                for(var i=0; i< CycleCount; i++)
                {
                    var m1 = Random.BitMatrix32();
                    var m3 = Random.BitMatrix32();
                    sw.Start();
                    last = BitMatrixOps.Mul(in m1, in m3, ref dst);
                    sw.Stop();
                    
                }
            }

            Collect((RoundCount*CycleCount, snapshot(sw), "bmm32x32"));
        }

        void bmm8x8_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix8();
                var m4 = m2 * m3;
                var m5 = BitRef.bmm(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        void bmm32x32_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var m1 = Random.BitMatrix32();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix32();
                var m4 = m2 * m3;
                var m5 = BitRef.bmm(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        void Mul4Bench(int cycles)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix4();
                var m3 = Random.BitMatrix4();
                sw.Start();
                var m4 = m1 * m3;
                sw.Stop();
            }
            Collect((cycles, snapshot(sw), "bmm4x4"));
        }

        OpTime Mul16Bench(int cycles)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix16();
                var m3 = Random.BitMatrix16();
                sw.Start();
                var m4 = m1 * m3;
                sw.Stop();
            }
            return (cycles, snapshot(sw), "bmm16x16");
        }


        OpTime Mul32Bench(int cycles)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix32();
                var m3 = Random.BitMatrix32();
                sw.Start();
                var m4 = m1 * m3;
                sw.Stop();
            }
            return (cycles, snapshot(sw), "bmm32");
        }


        void bmv8x8_check()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix8();
                var c = Random.BitVector8();
                var z1 = m * c;            
                var z2 = BitVector8.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m.RowVector(i);
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }

        void bmv16x16_check()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix16();
                var c = Random.BitVector16();
                var z1 = m * c;            
                var z2 = BitVector16.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m.RowVector(i);
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }

        void bmv32x32_check()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix32();
                var c = Random.BitVector(n32);
                var z1 = m * c;            
                var z2 = BitVector32.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m.RowVector(i);
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }

        void bmm64x64_check()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var m = Random.BitMatrix64();
                var c = Random.BitVector64();
                var z1 = m * c;            
                var z2 = BitVector64.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m.RowVector(i);
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }


}

}