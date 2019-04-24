//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    public delegate T PrimalBinOp<T>(T lhs, T rhs)
        where T : struct, IEquatable<T>;

    public delegate Index<T> IndexBinOp<T>(Index<T> lhs, Index<T> rhs)
        where T : struct, IEquatable<T>;

}