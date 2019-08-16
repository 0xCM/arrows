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

    public class BitMatMulTest : UnitTest<BitMatMulTest>
    {
        void VerifyMul8(int cycles = DefaltCycleCount)
        {
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix8();
                var m4 = m2 * m3;
                var m5 = BitRef.MatMul(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        void VerifyMul32(int cycles = DefaltCycleCount)
        {
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix32();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix32();
                var m4 = m2 * m3;
                var m5 = BitRef.MatMul(m1,m3);
                Claim.yea(m4 == m5);
            }            
        }

        OpTime Mul4Bench(int cycles)
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
            return (cycles, snapshot(sw), "bmm4");
        }

        OpTime Mul8Bench(int cycles)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix8();
                var m3 = Random.BitMatrix8();
                sw.Start();
                var m4 = m1 * m3;
                sw.Stop();
            }
            return (cycles, snapshot(sw), "bmm8");
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
            return (cycles, snapshot(sw), "bmm16");
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

        OpTime Mul64Bench(int cycles)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix64();
                var m3 = Random.BitMatrix64();
                sw.Start();
                var m4 = m1 * m3;
                sw.Stop();
            }
            return (cycles, snapshot(sw), "bmm64");
        }

        OpTime VerifyMul64(int cycles = DefaltCycleCount)
        {
            var sw = stopwatch(false);
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix64();
                sw.Start();
                var m4 = m2 * m3;
                sw.Stop();
                var m5 = BitRef.MatMul(m1,m3);
                Claim.yea(m4 == m5);
            }
            return (cycles, snapshot(sw), "bmm64");
        }


        void VerifyMulRVec8(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)            
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

        void VerifyMulRVec16(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)            
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

        void VerifyMulRVec32(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)            
            {
                var m = Random.BitMatrix32();
                var c = Random.BitVector32();
                var z1 = m * c;            
                var z2 = BitVector32.Alloc();
                for(var i = 0; i<m.RowCount; i++)           
                {
                    var r = m.RowVec(i);
                    z2[i] = r % c;
                }
                
                Claim.yea(z1 == z2);
            }
        }

        void VerifyMulRVec64(int cycles = DefaltCycleCount)
        {
            for(var cycle = 0; cycle < cycles; cycle++)            
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


        public void Mul8()
        {
            VerifyMul8();

        }

        public void Mul32()
        {
            VerifyMul32();
        }

        public void Mul64()
        {
            VerifyMul64();
        }


        public void MulRVec8()
        {
            VerifyMulRVec8();            
        }

        public void MulRVec16()
        {
            VerifyMulRVec16();            
        }

        public void MulRVec32()
        {
            VerifyMulRVec32();            
        }

        public void MulRVec64()
        {
            VerifyMulRVec64();            
        }

        public void RunMul4Bench()
        {
            Collect(Mul4Bench(Pow2.T12));
        }

        public void RunMul8Bench()
        {
            Collect(Mul8Bench(Pow2.T12));
        }

        public void RunMul16Bench()
        {
            Collect(Mul16Bench(Pow2.T12));
        }

        public void RunMul32Bench()
        {
            Collect(Mul32Bench(Pow2.T12));
        }

        public void RunMul64Bench()
        {
            Collect(Mul64Bench(Pow2.T12));
        }

    }

}