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


    public abstract class VectorAdd<C,N,T> : RealVectorBinOpTest<C,N,T,T>
        where C : VectorAdd<C,N,T>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>
    {

        protected VectorAdd(Interval<T> bounds, Func<T,bool> filter = null, uint? sampleSize = null)
            : base(bounds, filter, sampleSize)
        {

            
        }

    }


}