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

        public interface RealNumber<T> : OrderedNumber<T>, Trigonmetric<T>
        {

        }

        public interface RealNumber<S,T> : RealNumber<S>, IComparable<S>, Structural<S,T>
            where S : RealNumber<S,T>, new()
        {

        }


    }


}