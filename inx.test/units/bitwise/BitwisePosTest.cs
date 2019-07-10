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

    public class BitwisePosTest : UnitTest<BitwisePosTest>
    {
        
        public void FindLeastOnBit()
        {
            Claim.eq((byte)3, gbits.lopos((byte)0b111000));
            Claim.eq(2u, gbits.lopos(0b0001011000100u));
            Claim.eq(5u, gbits.lopos(0b000101100000u));

        }

        void HiBit<T>()
            where T : struct
        {
            TypeCaseStart<T>();
            var values = Random.Stream<T>().Take(Pow2.T08);
            iter(values, v =>{
                if(gmath.negative(v))
                    Claim.eq(gbits.hibit(v), Bit.On);
                else
                    Claim.eq(gbits.hibit(v), Bit.Off);
            });            
            TypeCaseEnd<T>();
        }

        public void HiBits()
        {
            HiBit<sbyte>();
            HiBit<short>();
            HiBit<int>();
            HiBit<long>();
        }
    }

}