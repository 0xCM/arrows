//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zcore;
    using static x86;
    using static Operative;

    public static class InX128G
    {
        [MethodImpl(Inline)]
        public static InX128Add<T> Add<T>()
            where T : struct, IEquatable<T>
                => cast<InX128Add<T>>(InX128Add.Inhabitant);
    }


}