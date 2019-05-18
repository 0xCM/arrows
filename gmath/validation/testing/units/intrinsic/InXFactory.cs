//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public class InXFactoryTest : UnitTest<InXFactoryTest>
    {        

        public void DefineFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.single(src);
            var v2 = Vec128.load(src,0);
            Claim.eq(v1,v2);
        }
    }
}