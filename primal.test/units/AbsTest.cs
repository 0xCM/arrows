//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    public class AbsTest : UnitTest<AbsTest>
    {

        void VerifyAbs(int cycles = DefaltCycleCount)
        {
            for(var i=0; i<cycles; i++)
            {
                var src = Random.NextInt64();
                var x = math.abs(src);
                var y = Math.Abs(src);
                Claim.eq(x,y);
            }

            for(var i=0; i<cycles; i++)
            {
                var src = Random.NextInt32();
                var x = math.abs(src);
                var y = Math.Abs(src);
                Claim.eq(x,y);
            }

            for(var i=0; i<cycles; i++)
            {
                var src = Random.NextInt16();
                var x = math.abs(src);
                var y = Math.Abs(src);
                Claim.eq(x,y);
            }

            for(var i=0; i<cycles; i++)
            {
                var src = Random.NextInt8();
                var x = math.abs(src);
                var y = Math.Abs(src);
                Claim.eq(x,y);
            }
        }

        public void PrimalAbs()
        {
            VerifyAbs();

            //VerifyAbs64();
        }


    }

}