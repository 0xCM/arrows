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

    

    public interface IUnitTest : ITestContext
    {
        
    }

    public abstract class UnitTest<T> : TestContext<T>, IUnitTest
        where T : UnitTest<T>
    {

        protected UnitTest(ITestConfig config = null)
            : base(config)
            {

            }
    }


}