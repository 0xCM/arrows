//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Traits
    {
        public interface Equatable<T>
        {
            bool eq(T lhs, T rhs);

            bool neq(T lhs, T rhs);
        }

        public interface Equatable<S,T> : Equatable<T>, Structural<S,T>
            where S : Equatable<S,T>, new()
        {
            bool eq(S rhs);

            bool neq(S rhs);
        }

    }

    public readonly struct Equality<T> : Traits.Equatable<T>
        where T : Traits.Equatable<T>
    {
        
        readonly Traits.Equatable<T> ops;

        public Equality(Traits.Equatable<T> ops)    
            => this.ops = ops;

        public bool eq(T lhs, T rhs)
            => ops.eq(lhs,rhs);

        public bool neq(T lhs, T rhs)
            => ops.neq(lhs,rhs);
    }


}