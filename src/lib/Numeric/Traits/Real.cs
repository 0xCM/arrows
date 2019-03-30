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



    }

    partial class Structure
    {
        public interface RealNumber<S,T> : OrderedNumber<S,T>, Trigonmetric<S,T>, IComparable<S>
            where S : RealNumber<S,T>, new()
        {

        }

    }


}