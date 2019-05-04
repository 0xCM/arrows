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

    public static partial class PrimalFusion
    {


        [MethodImpl(Inline)]
        public static Index<T> and<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => And<T>.Op(lhs,rhs);


    }


}