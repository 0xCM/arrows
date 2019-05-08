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

    


    public abstract class UnitTest<T> : TestContext<T>
        where T : UnitTest<T>
    {

        protected UnitTest(TestConfig config = null)
            : base(config)
            {

            }
    }


}