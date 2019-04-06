//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Operative;

    partial class Operative
    {
        public interface Divisive<T>
        {
            T div(T lhs, T rhs);        

            T gcd(T lhs, T rhs);

            Quorem<T> divrem(T lhs, T rhs);        

            T mod(T lhs, T rhs);
        }
    }

    partial class Structures
    {
        public interface Divisive<S>
            where S : Divisive<S>, new()
        {
            S div(S rhs);        

            S gcd(S rhs);

            Quorem<S> divrem(S rhs);        

            S mod(S rhs);
        }

        public interface Divisive<S,T> : Divisive<S>
            where S : Divisive<S,T>, new()
        {

        }
    }
}