//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public class tv_count : UnitTest<tv_count>
    {   
        public void next8i()
        {
            next_check<byte>();
        }

        public void next8u()
        {
            next_check<byte>();
        }

        public void next32i()
        {
            next_check<int>();
        }

        public void next32u()
        {
            next_check<uint>();
        }

        public void next64i()
        {
            next_check<long>();
        }

        public void next64u()
        {
            next_check<ulong>();
        }


        void next_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVec128<T>();
                var xn = x.Next();
                var xp = x.Prior();

                var units128 = Vec128Pattern.Units<T>();
                Claim.eq(xp.Add(units128), x);
                Claim.eq(xn.Sub(units128), x);
                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(xn[j], gmath.inc(x[j]));
                    Claim.eq(xp[j], gmath.dec(x[j]));
                }

            
                var y = Random.CpuVec256<T>();
                var yn = y.Next();
                var yp = y.Prior();

                var units256 = Vec256Pattern.Units<T>();
                Claim.eq(yp.Add(units256), y);
                Claim.eq(yn.Sub(units256), y);

                for(var j=0; j< x.Length(); j++)
                {
                    Claim.eq(yn[j], gmath.inc(y[j]));
                    Claim.eq(yp[j], gmath.dec(y[j]));
                }

            }
        }
    }
}
