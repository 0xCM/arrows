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

    public class TestConfig
    {
        public static readonly TestConfig Default = new TestConfig();
    }

    public delegate void TestRunner();

    public interface ITestHost : IContext
    {
        IReadOnlyDictionary<string,TestRunner> Runners();
    }

    public abstract class TestContext<T> : Context<T>, ITestHost
        where T : TestContext<T>
    {
        public TestContext(TestConfig Config = null)
            : base(Z0.Randomizer.define(RandSeeds.TestSeed))
        {
            this.Config = Config ?? TestConfig.Default;
        }

        public TestConfig Config {get;}
    
        public IReadOnlyDictionary<string,TestRunner> Runners()
        {
            var methods = GetType().GetMethods().Where(
                    m => m.IsPublic && !m.IsStatic && !m.IsAbstract  
                    && m.DeclaringType == this.GetType()
                    && m.GetParameters().Length == 0);
            
            return map(methods, m => (m.Name, (TestRunner) Delegate.CreateDelegate(typeof(TestRunner),this,m))).ToDictionary();
        }
    
    }


}