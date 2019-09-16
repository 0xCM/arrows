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

        public void bmm_4x4_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var last = BitMatrix4.Zero;

            for(var i=0; i< opcount; i++)
            {
                var m1 = Random.BitMatrix4();
                var m2 = Random.BitMatrix4();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }
            Collect((opcount, snapshot(sw), "bmm_4x4"));
        }

        public void bmm_8x8()
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

        public void bmm_8x8_bench()
        {
            var opcount = RoundCount*CycleCount;
            var sw = stopwatch(false);
            var last = BitMatrix8.Zero;
            
            for(var i = 0; i < opcount; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = Random.BitMatrix8();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }

            Collect((opcount, snapshot(sw), "bmm_8x8"));
        }

        public void bmm_16x16_bench()
        {
            var opcount = RoundCount*CycleCount;
            var last = BitMatrix16.Zero;

            var sw = stopwatch(false);
            for(var i=0; i< opcount; i++)
            {
                var m1 = Random.BitMatrix16();
                var m2 = Random.BitMatrix16();
                sw.Start();
                last = m1 * m2;
                sw.Stop();
            }

            Collect((opcount, snapshot(sw), "bmm_16x16"));
        }

        public void bmm_32x32()
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

        public void bmm_32x32_bench()
        {
            var last = BitMatrix32.Zero;            
            var sw = stopwatch(false);
            var opcount = RoundCount*CycleCount;

            var dst = BitMatrix32.Alloc();
            for(var i=0; i< opcount; i++)
            {
                var m1 = Random.BitMatrix32();
                var m3 = Random.BitMatrix32();
                sw.Start();
                last = BitMatrixOps.Mul(in m1, in m3, ref dst);
                sw.Stop();                    
            }

            Collect((opcount, snapshot(sw), "bmm_32x32_prealloc"));
        }

        void bmm_64x64x64()
        {
            var Aup = Matrix.Alloc<N64,byte>();
            var Bup = Matrix.Alloc<N64,byte>();
            var Cup = Matrix.Alloc<N64,byte>();
            var A = Random.BitMatrix64();
            var B = Random.BitMatrix64();
            var C = A * B;

            BitMatrix.unpack(A,ref Aup);
            BitMatrix.unpack(B,ref Bup);
            IntMatrix.mul(Aup, Bup, ref Cup);
            Cup.Apply(x => even(x) ? (byte)0 : (byte)1);
            Trace(C.Format());
            Trace(Cup.Format());

        }
        public void bmv_64x64x8()
        {
            for(var sample = 0; sample < SampleSize; sample++)            
            {
                var A = Random.BitMatrix64();
                var x = Random.BitVector64();
                var z = A * x;            
                var y = BitVector64.Alloc();
                for(var i = 0; i<A.RowCount; i++)           
                {
                    var r = A.RowVector(i);
                    y[i] = r % x;
                }


                
                Claim.yea(z == y);
            }
        }

        public void bmm_64x64_bench()
        {
            var opcount = RoundCount*CycleCount;
            var last = BitMatrix64.Zero;  
            
            var sw = stopwatch(false);            
            for(var i=0; i < opcount; i++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = Random.BitMatrix64();
                sw.Start();
                last = BitMatrixOps.Mul(m1, m2);
                sw.Stop();                
            }

            Collect((opcount, snapshot(sw), "bmm_64x64"));
        }

        public void bmm_64x64_prealloc_bench()
        {
            var opcount = RoundCount*CycleCount;
            var last = BitMatrix64.Zero;  
            var dst = BitMatrix64.Alloc();          

            var sw = stopwatch(false);
            for(var i=0; i < opcount; i++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = Random.BitMatrix64();
                sw.Start();
                last = BitMatrixOps.Mul(m1, m2, ref dst);
                sw.Stop();                
            }

            Collect((opcount, snapshot(sw), "bmm_64x64_prealloc"));
        }

        public void bmv_8x8()
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

        public void bmv_16x16()
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

        public void bmv_32x32()
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
    }

}