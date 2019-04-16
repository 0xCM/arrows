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


    public abstract class BinOpTest<C,T> : NumericTest<C,T>
        where C : BinOpTest<C,T>
        where T : struct, IEquatable<T>            
    {

        protected IReadOnlyList<T> LeftPrimSrc {get;}
        
        protected IReadOnlyList<T> RightPrimSrc {get;}


        protected BinOpTest(Interval<T> bounds, Func<T,bool> filter = null,  int? streamLen = null)
            : base(bounds, filter, streamLen)
        {
            this.LeftPrimSrc = sample();
            this.RightPrimSrc = sample();
        }

    }


}