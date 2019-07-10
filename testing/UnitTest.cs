//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    public interface IUnitTest : ITestContext
    {
        bool Enabled {get;}
    }

    public abstract class UnitTest<T> : TestContext<T>, IUnitTest
        where T : UnitTest<T>
    {

        protected UnitTest(ITestConfig config = null)
            : base(config)
            {

            }
        
        public virtual bool Enabled 
            => true;
    }


}