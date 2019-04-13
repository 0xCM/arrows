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
    
    public abstract class UnitTest
    {

    }

    public abstract class UnitTest<T> : UnitTest
        where T : UnitTest<T>
    {
        protected static TestContext<T> Context = TestContext.define<T>(RandSeeds.TestSeed);
    }

}