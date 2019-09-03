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

        public void andn8u()
        {
            andn_check<byte>();
        }

        public void andn16u()
        {
            andn_check<ushort>();
        }

        public void andn32i()
        {
            andn_check<int>();
        }

        public void andn32u()
        {
            andn_check<uint>();
        }

        public void andn64i()
        {
            andn_check<long>();
        }

        public void andn64u()
        {
            andn_check<ulong>();
        }

        public void andn32f()
        {
            andn_check<float>();
        }

        public void andn64f()
        {
            andn_check<double>();
        }

        void andn_check<T>(int cycles = DefaltCycleCount)
            where T : struct
        {
            var vZero = Vec128<T>.Zero;
            for(var i=0; i<cycles; i++)
            {
                var x1 = Polyrand.CpuVec128<T>();                    
                var y1 = Polyrand.CpuVec128<T>();                    
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


    }

}