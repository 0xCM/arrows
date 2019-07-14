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


    public class InX512Test : UnitTest<InX512Test>
    {    
        public void TestM512PartsA()
        {
            var point = Random.Next<int>();
            var src = __m512i.Define(point);
            Claim.eq(__m512i.PartCount<int>(), 16);
            for(var i=0; i< __m512i.PartCount<int>(); i++)
                Claim.eq(point, src.Part<int>(i));            
        }

        public void TestPow2()
        {
            var f1 = Pow2.floor((byte) 78);
            Claim.eq((byte)Pow2.T06, f1);
            Claim.eq(Pow2.T05, f1 >> 1);

            var f2 = Pow2.floor((byte) 1);
            Claim.eq((byte)Pow2.T00, f2);

            var f3 = Pow2.floor((byte) 201);
            Claim.eq((byte)Pow2.T07, f3);
            Claim.eq((byte)Pow2.T06, f3 >> 1);

            var f4 = Pow2.floor(Byte.MaxValue);
            Claim.eq((byte)Pow2.T07, f4);

        }

        public void TestM512PartsB()
        {            
            var point = Random.m512i<sbyte>();
            Claim.eq(point.Part<sbyte>(22), point.Part<sbyte>(179));
            Claim.eq(point.Part<int>(2), point.Part<int>(68));
        }

        public void TestM512PartsC()
        {
            for(var j = 0; j < Pow2.T08; j++)
            {
                var point = Random.m512i<long>();
                var bs1 = point.ToBitString();
                var bs2 = new char[512];
                for(var i=0; i< bs2.Length; i++)
                    bs2[i] = point[i];

                for(var i=0; i< bs2.Length; i++)
                    Claim.eq(bs1[i], bs2[i]);
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