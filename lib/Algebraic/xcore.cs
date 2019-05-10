//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zcore;

    partial class xcore
    {

        class Komparer<T> : IComparer<T>
        {
            IOrderedOps<T> ordered {get;}                

            public Komparer(IOrderedOps<T> ordered)
                => this.ordered = ordered;
            public int Compare(T x, T y)
            {
                if(ordered.lt(x,y))
                    return - 1;
                else if(ordered.gt(x, y))
                    return 1;
                else
                    return 0;            
            }
        }

        public static IComparer<T> ToComparer<T>(this IOrderedOps<T> order)
            => new Komparer<T>(order);
    }    
}
