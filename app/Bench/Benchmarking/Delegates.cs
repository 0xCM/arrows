//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zcore;
    




    public unsafe delegate long TimedIndexBinOp<T>(Index<T> lhs, Index<T> rhs, out Index<T> dst)
        where T : struct, IEquatable<T>;


}