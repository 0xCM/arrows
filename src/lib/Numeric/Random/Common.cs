//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zcore;

    public interface PrimalRand<T>
        where T : struct, IEquatable<T>
    {
        IEnumerable<T> stream(T min, T max);        

        T one(T min, T max);

    }

    public interface Rand<T>
        where T : struct, IEquatable<T>
    {
        
        IEnumerable<real<T>> stream(real<T> min, real<T> max);

    }

}