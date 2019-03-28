//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;

    partial class Traits
    {


        public interface Concatenable<T>
        {
            T concat(T lhs, T rhs);

        }

        public interface Concatenable<S,T> : Concatenable<S>, Structure<S,T>
            where S : Concatenable<S,T>,new()
        {
            S concat(S rhs);

        }

    }


}