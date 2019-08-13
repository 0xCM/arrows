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

    public class BitMatrixMulTest : UnitTest<BitMatrixMulTest>
    {

        void VerifyMul64(int cycles = DefaltCycleCount)
        {
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix64();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix64();
                var m4 = m2 * m3;
                var m5 = BitRefOps.MatMul(m1,m3);
                Claim.yea(m4 == m5);
            }
            
        }

        void VerifyMul8(int cycles = DefaltCycleCount)
        {
            for(var i=0; i< cycles; i++)
            {
                var m1 = Random.BitMatrix8();
                var m2 = m1.Replicate();
                var m3 = Random.BitMatrix8();
                var m4 = m2 * m3;
                var m5 = BitRefOps.MatMul(m1,m3);
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
                var m5 = BitRefOps.MatMul(m1,m3);
                Claim.yea(m4 == m5);
            }
            
        }

        public void Mul8()
        {
            VerifyMul8();

        }

        public void Mul64()
        {
            VerifyMul64();
        }

        public void Mul32()
        {
            VerifyMul32();

        }

    }

}