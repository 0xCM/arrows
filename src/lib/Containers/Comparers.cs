//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static Structures;
    

    /// <summary>
    /// Reifies an IComparable instance from an ordered value
    /// </summary>
    readonly struct Comparable<T> : IComparable<T>
        where T : Ordered<T>, new()
    {
        readonly T ordered;

        public Comparable(T ordered)
            => this.ordered = ordered;

        [MethodImpl(Inline)]
        public int CompareTo(T rhs)
            => ordered.eq(rhs) ? 0 :
               ordered.gt(rhs) ? 1 :
               -1;
    }
}


