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
    using static inxfunc;


    public static class IndexOps
    {
        [MethodImpl(Inline)]
        public static IndexBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => IndexOps<T>.Add;

        [MethodImpl(Inline)]
        public static Index<T> add<T>(Index<T> lhs, Index<T> rhs)
            where T : struct, IEquatable<T>
                => IndexOps<T>.Add(lhs,rhs);
    }

    public static class IndexOps<T>
            where T : struct, IEquatable<T>
    {

        public static IndexBinOp<T> Add = IndexDelegates.add<T>();

    }

}