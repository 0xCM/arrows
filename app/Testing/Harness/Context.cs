//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Collections.Generic;

    public class TestContext<T> : Context<T>
    {
        public TestContext(ulong[] seed)
            : base(seed)
        {

        }
    }
}