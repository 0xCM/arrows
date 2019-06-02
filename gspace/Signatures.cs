//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;
    using static As;

    /// <summary>
    /// Defines the signature of a function that measures execution time for
    /// cycles * reps invocations
    /// </summary>
    /// <param name="cycles">The number of cycles</param>
    /// <param name="reps">The number of reps</param>
    public delegate Duration Repeat(int cycles, int reps);

}