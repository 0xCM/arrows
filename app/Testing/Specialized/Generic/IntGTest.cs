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

    public abstract class IntGTest<C,T> : NumericTest<C,T>
        where C : IntGTest<C,T>
        where T : struct, IEquatable<T>            
    {


        protected IntGTest(Interval<T> bounds, Func<T,bool> filter = null, int? sampleSize = null)
            : base(bounds,filter,sampleSize)
        {

        }


    }



}