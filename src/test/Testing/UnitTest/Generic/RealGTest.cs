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

    using Z0.Testing;

    public abstract class RealGTest<C,T> : NumericTest<C,T>
        where C : RealGTest<C,T>
        where T : struct, IEquatable<T>            
    {
        protected RealGTest(Interval<T> bounds, Func<T,bool> filter = null)
            : base(bounds,filter)
        {

        }

    }


}