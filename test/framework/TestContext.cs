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

    public interface ITestContext : IContext
    {
        ITestConfig Config {get;}
        
    }


    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig Config = null)
            : base(Z0.XOrStarStar256.define(Seed256.TestSeed))
        {
            this.Config = Config ?? TestConfigDefaults.Default();
        }

        public ITestConfig Config {get;}
    
    }


}