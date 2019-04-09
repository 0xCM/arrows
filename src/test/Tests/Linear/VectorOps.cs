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

    using Z0.Testing;

    using static zcore;
    using static ztest;

    public abstract class VectorEquality<N,T> : VectorBinOpTest<N,T,bool>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
    {

        protected VectorEquality(T min, T max)
            : base(min,max)
        {}

    }
    public abstract class VectorAdd<N,T> : RealVectorBinOpTest<N,T,T>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
    {
        protected VectorAdd(T min, T max)
            : base(min,max)
        {}
    }


}