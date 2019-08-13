//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;
 
    public class AndNotTest : UnitTest<AndNotTest>
    {


        void Verify<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            var vZero = Vec128<T>.Zero;
            for(var i=0; i<cycles; i++)
            {
                var x1 = Random.CpuVec128<T>();                    
                var y1 = Random.CpuVec128<T>();                    
                var z1 = gbits.andnot(in x1, in y1);
                var z2 = gbits.andnot(in x1, in x1);

                var z = PrimalInfo.Get<T>().Zero;
                for(var j = 0; j<z1.Length(); j++)
                {
                    gbits.or(ref z, z1[j]);
                    Claim.nea(gmath.nonzero(z2[j]));
                }
                
                Claim.yea(gmath.nonzero(z));

                Claim.yea(z2 == vZero);
            }
        }


        public void VerifyU8()
        {
            Verify<byte>();
        }

        public void VerifyU16()
        {
            Verify<ushort>();
        }

        public void VerifyI32()
        {
            Verify<int>();
        }

        public void VerifyU32()
        {
            Verify<uint>();
        }

        public void VerifyI64()
        {
            Verify<long>();
        }

        public void VerifyU64()
        {
            Verify<ulong>();
        }

        public void VerifyF32()
        {
            Verify<float>();
        }

        public void VerifyF64()
        {
            Verify<double>();
        }

    }

}