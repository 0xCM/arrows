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
    
        public void TestM512Parts()
        {
            var point = Randomizer.Next<int>();
            var src = m512.define(point);
            Claim.eq(M512.PartCount<int>(), 16);
            for(var i=0; i< M512.PartCount<int>(); i++)
                Claim.eq(point, src.part<int>(i));
            
        }

        public void TestM512Pop()
        {
            var point = Randomizer.M512<long>();
            var popX = m512.pop(point);
            m512.toggle<long>(ref point, 2, 3);
            var popY = m512.pop(point);
            var condition = (popY == popX + 1) || (popY == popX - 1);
            Claim.@true(condition);

        }

    }

}