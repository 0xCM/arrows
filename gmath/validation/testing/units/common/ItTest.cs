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

    
    using static mfunc;
    using static zfunc;


    public class ItTest : UnitTest<ItTest>
    {

        public void Case1()
        {
            var finish = 100;
            var start = 0;
            var step = 1;
            var it = It.Define(start, finish, step);

            var expect = 0;
            for(var i=start; i<finish; i++)
                expect += i;

            var actual = 0;
            while(++it)
                actual += it;

            Claim.eq(expect, actual);
        }

        public void Case2()
        {
            var finish = 500;
            var start = 0;
            var step = 5;
            var it = It.Define(start, finish, step);

            var expect = 0;
            for(var i=start; i<finish; i+=step)
                expect += i;

            var actual = 0;
            while(++it)
                actual += it;

            Claim.eq(expect, actual);
        }

    }

}