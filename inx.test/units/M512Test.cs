//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class M512Test : UnitTest<M512Test>
    {    
        public void TestM512PartsA()
        {
            var point = Random.Next<int>();
            var src = __m512i.Define(point);
            Claim.eq(__m512i.PartCount<int>(), 16);
            for(var i=0; i< __m512i.PartCount<int>(); i++)
                Claim.eq(point, src.Part<int>(i));            
        }


        // public void TestM512PartsB()
        // {            
        //     var point = Random.m512i<sbyte>();
        //     Claim.eq(point.Part<sbyte>(22), point.Part<sbyte>(179));
        //     Claim.eq(point.Part<int>(2), point.Part<int>(68));
        // }

        public void TestM512PartsC()
        {
            for(var j = 0; j < Pow2.T08; j++)
            {
                var point = Random.m512i<ulong>();
                var blocks = point.ToBitString().Blocks(64);
                Claim.eq(blocks.Length,  512/64);
                
                var bs1 = point.ToBytes().ToBitString();
                var bs2 = point.ToBitString();
                Claim.eq(bs1,bs2);

                
                
                //Claim.eq(point.x0,   blocks[0].ToPrimalValue<ulong>());

                
            }
        }

        public void TestM512Pop()
        {
            var point = Random.m512i<long>();
            var popX = point.PopCount();
            point.ToggleBit<long>(2, 3);
            var popY = point.PopCount();
            var condition = (popY == popX + 1) || (popY == popX - 1);
            Claim.yea(condition);
        }
    }
}