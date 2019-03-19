//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using C = Core.Contracts;


    public readonly struct Semigroup<T> : C.Semigroup<T>
    {    
        readonly Func<T,T,T> composer; 

        public Semigroup(Func<T,T,T> composer)
            => this.composer = composer;
        
        public T compose(T a, T b)
            => composer(a,b);

        public bool contains(T item)
            => true;
    }


}