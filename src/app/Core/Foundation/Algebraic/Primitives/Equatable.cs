//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;

    partial class Class
    {
        public interface Equatable<T> : TypeClass
        {
            bool eq(T lhs, T rhs);

            bool neq(T lhs, T rhs);
        }

        public interface Equatable<H,T> : TypeClass<H>, Equatable<T>
            where H : Equatable<H,T>, new()
        {
        
        }

    }

    partial class Struct
    {

        public interface Equatable<S,T> : Structure<S,T>
            where S : Equatable<S,T>, new()
        {
            bool eq(S rhs);

            bool neq(S rhs);
        }
    }
}