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
    
    readonly struct EqualityComparer<T> : IEqualityComparer<T>
    {

        readonly Equality<T> equatable;


        [MethodImpl(Inline)]
        public EqualityComparer(Equality<T> equatable)
            => this.equatable = equatable;

        [MethodImpl(Inline)]
        public bool Equals(T x, T y)
            => equatable.eq(x,y);

        [MethodImpl(Inline)]
        public int GetHashCode(T x)
            => x.GetHashCode();
    }
}


