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

    public abstract class IntGTest<T> : NumericTest<T>
        where T : struct, IEquatable<T>            
    {
        protected IReadOnlyList<intg<T>> reals(intg<T> min, intg<T> max)
            => Rand.integers(min,max).Freeze(SampleSize);

        protected IntGTest(T MinPrimVal, T MaxPrimVal)
            : base(MinPrimVal, MaxPrimVal)
        {

        }

    }



}