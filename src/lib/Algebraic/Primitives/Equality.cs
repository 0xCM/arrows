//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface Equality<T> 
    {
        bool eq(T lhs, T rhs);

        bool neq(T lhs, T rhs);
    }

    public interface Equatable<S> : Equality<S>, IEquatable<S>
    {
        bool eq(S rhs);

        bool neq(S rhs);
    }

    public interface Hashable
    {
        int hash();
    }

    public interface Equatable<S,T> : Equatable<S>
        where S : Equatable<S,T>, new()
    {

    }


    partial class Reify
    {

        public readonly struct Equality<T> : Z0.Equality<T>
            where T : Z0.Equality<T>
        {        
            readonly Z0.Equality<T> ops;

            public Equality(Z0.Equality<T> ops)    
                => this.ops = ops;

            public bool eq(T lhs, T rhs)
                => ops.eq(lhs,rhs);

            public bool neq(T lhs, T rhs)
                => ops.neq(lhs,rhs);
        }

    }
}