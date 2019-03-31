//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;

    partial class Operative
    {


        public interface Concatenable<T> : Operational<T>
        {
            T concat(T lhs, T rhs);

        }


    }

    partial class Structure
    {
        public interface Concatenable<S> 
        {
            S concat(S rhs);

        }

        public interface Concatenable<S,T> : Concatenable<S>, Structural<S,T>
            where S : Concatenable<S,T>,new()
        {

        }

    }


}