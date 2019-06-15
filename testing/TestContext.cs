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

        void Configure(ITestConfig config);
        
    }


    public abstract class TestContext<T> : Context<T>, ITestContext
        where T : TestContext<T>
    {
        public TestContext(ITestConfig config = null, IRandomSource random = null)
            : base(RNG.XOrShift1024(Seed1024.TestSeed))
        {
            this.Config = Config ?? TestConfigDefaults.Default();
        }

        public ITestConfig Config {get; private set;}

        protected override bool TraceEnabled
            => Config.TraceEnabled;

        public void Configure(ITestConfig config)
            => Config = config;    
    }
}