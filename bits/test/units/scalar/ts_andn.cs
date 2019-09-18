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
 
    public class ts_andn : UnitTest<ts_andn>
    {

        public void scalar_andn_8u()
        {
            scalar_andn_check<byte>();
        }

        public void scalar_andn_16u()
        {
            scalar_andn_check<ushort>();
        }

        public void scalar_and_32i()
        {
            scalar_andn_check<int>();
        }

        public void scalar_andn_32u()
        {
            scalar_andn_check<uint>();
        }

        public void scalar_andn_64i()
        {
            scalar_andn_check<long>();
        }

        public void scalar_andn_64u()
        {
            scalar_andn_check<ulong>();
        }

        public void scalar_andn_32f()
        {
            scalar_andn_check<float>();
        }

        public void scalar_andn_64f()
        {
            scalar_andn_check<double>();
        }

        void scalar_andn_check<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            var vZero = Vec128<T>.Zero;
            for(var i=0; i<cycles; i++)
            {
                var x1 = Random.CpuVec128<T>();                    
                var y1 = Random.CpuVec128<T>();                    
                var z1 = gbits.andn(in x1, in y1);
                var z2 = gbits.andn(in x1, in x1);

                var z = PrimalInfo.Get<T>().Zero;
                for(var j = 0; j<z1.Length(); j++)
                {
                    gbits.or(in z, z1[j], ref z);
                    Claim.nea(gmath.nonzero(z2[j]));
                }
                
                Claim.yea(gmath.nonzero(z));

                Claim.yea(z2 == vZero);
            }
        }


    }

}