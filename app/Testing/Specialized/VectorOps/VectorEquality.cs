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

    using Z0.Testing;

    using static zcore;

    public abstract class VectorEquality<C,N,T> : VectorBinOpTest<C,N,T,bool>
        where C : VectorEquality<C,N,T>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
    {

        protected VectorEquality(Interval<T> bounds, Func<T,bool> filter = null, int? sampleSize = null)
            : base(bounds,filter,sampleSize)
        {}

    }


}