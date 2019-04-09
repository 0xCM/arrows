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

    public abstract class RealGTest<T> : NumericTest<T>
        where T : struct, IEquatable<T>            
    {
        protected IReadOnlyList<real<T>> reals(real<T> min, real<T> max)
            => Rand.reals(min,max).Freeze(SampleSize);

        protected RealGTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {

        }

    }



}