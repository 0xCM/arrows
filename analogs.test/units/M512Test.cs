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
            var src = m512.define(point);
            Claim.eq(M512.PartCount<int>(), 16);
            for(var i=0; i< M512.PartCount<int>(); i++)
                Claim.eq(point, src.part<int>(i));
            
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
            
            var point = Random.NextM512<sbyte>();
            Claim.eq(point.part<sbyte>(22), point.part<sbyte>(bitpos(179)));
            Claim.eq(point.part<int>(2), point.part<int>(bitpos(68)));
        }

        public void TestM512PartsC()
        {
            for(var j = 0; j < Pow2.T08; j++)
            {
                var point = Random.NextM512<long>();
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
            var point = Random.NextM512<long>();
            var popX = m512.pop(point);
            m512.toggle<long>(ref point, 2, 3);
            var popY = m512.pop(point);
            var condition = (popY == popX + 1) || (popY == popX - 1);
            Claim.yea(condition);
        }

    }

}