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



    public class BinaryPrimOpsTest<S,T> : PrimOpsTest<S,T>
        where S : BinaryPrimOpsTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected Index<T> LeftSrc;
        
        protected Index<T> RightSrc;


        protected BinaryPrimOpsTest(Interval<T>? domain = null, Func<T,bool> filter = null, int? SampleSize = null)
            : base(domain,filter,SampleSize)
        {
            this.LeftSrc = sample();
            this.RightSrc = sample();

        }


    }


}