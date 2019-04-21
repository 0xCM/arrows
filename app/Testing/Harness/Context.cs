//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Collections.Generic;


    public static class TestContext
    {
        /// <summary>
        /// Defines a new test context
        /// </summary>
        /// <param name="seed">The seed to use for random value generation</param>
        /// <typeparam name="T">The type for which the context is created</typeparam>
        public static TestContext<T> define<T>(ulong[] seed)
            => new TestContext<T>(seed);
    }

    public class TestContext<T> : Context<T>
    {
        public TestContext(ulong[] seed)
            : base(seed)
        {

        }
    }
}