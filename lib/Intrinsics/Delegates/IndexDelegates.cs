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

    static class IndexDelegates
    {

        static readonly PrimalIndex Add
            = PrimKinds.index
                (@sbyte: new IndexBinOp<sbyte>(InX.add),
                @byte: new IndexBinOp<byte>(InX.add),
                @short: new IndexBinOp<short>(InX.add),
                @ushort: new IndexBinOp<ushort>(InX.add),
                @int: new IndexBinOp<int>(InX.add),
                @uint: new IndexBinOp<uint>(InX.add),
                @long: new IndexBinOp<long>(InX.add),
                @ulong: new IndexBinOp<ulong>(InX.add),
                @float: new IndexBinOp<float>(InX.add),
                @double:new IndexBinOp<double>(InX.add)
                );


        [MethodImpl(Inline)]
        public static IndexBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,IndexBinOp<T>>();

    }

}
