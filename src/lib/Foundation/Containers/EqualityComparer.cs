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
    using static corefunc;

    public static class EqualityComparer
    {
        public static IEqualityComparer<T> define<T>(Func<T,T,bool> equal, Func<T,int> hasher)
            => new EqualityComparer<T>(equal, hasher);
    }
    
    readonly struct EqualityComparer<T> : IEqualityComparer<T>
    {

    
        readonly Func<T,T,bool> equal;
        readonly Func<T,int> hasher;

        [MethodImpl(Inline)]
        public EqualityComparer(Func<T,T,bool> equal, Func<T,int> hasher)
        {
            this.equal = equal;
            this.hasher = hasher;
        }

        [MethodImpl(Inline)]
        public bool Equals(T x, T y)
            => equal(x,y);

        [MethodImpl(Inline)]
        public int GetHashCode(T x)
            => hasher(x);
    }
}


