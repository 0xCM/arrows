//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static ztest;
    
    public abstract class GenericNumericTest
    {
        protected const uint VectorSize = Pow2.T20;
    
        protected const int RepeatCount = 5;
        
        protected static IReadOnlyList<T> primal<T>(T min, T max)
            => Rand.primal(min,max).Freeze(VectorSize);
    }

}