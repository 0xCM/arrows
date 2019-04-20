//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;
    using static Operative;

    partial class Operative
    {
        public interface Concatenable<T>
        {
            T concat(T lhs, T rhs);
        }
    }

    partial class Structures
    {
        public interface Concatenable<S> 
            where S : Concatenable<S>, new()
        {
            S concat(S rhs);
        }

        public interface Concatenable<S,T> : Concatenable<S>
            where S : Concatenable<S,T>, new()
        {

        }
    }
}