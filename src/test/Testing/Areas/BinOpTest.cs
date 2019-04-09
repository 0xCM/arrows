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


    public abstract class BinOpTest<T> : NumericTest<T>
        where T : struct, IEquatable<T>            
    {

        protected IReadOnlyList<T> LeftPrimSrc {get;}
        
        protected IReadOnlyList<T> RightPrimSrc {get;}

        protected BinOpTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal, MaxPrimVal, SampleSize)
        {
            this.LeftPrimSrc = sample();
            this.RightPrimSrc = sample();
        }

    }


}