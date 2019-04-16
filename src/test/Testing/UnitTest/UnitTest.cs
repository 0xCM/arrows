//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    
    public interface IUnitTest
    {
        
    }
    public abstract class UnitTest : IUnitTest
    {

        protected virtual string OpName 
            => string.Empty;
    }

    public abstract class UnitTest<T> : UnitTest
        where T : UnitTest<T>
    {
        protected static readonly TestContext<T> Context = TestContext.define<T>(RandSeeds.TestSeed);

        protected virtual void trace(string msg, [CallerMemberName] string caller = null)
        {
            var location = GetType().DisplayName() + caller;
            inform(msg, location);
        }

        protected int SampleSize {get;}

        protected UnitTest(int? SampleSize = null)            
        {
            this.SampleSize = SampleSize ?? Defaults.SampleSize;
        }
            
    }

}
