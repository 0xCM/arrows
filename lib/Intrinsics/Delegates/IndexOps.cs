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

        static readonly PrimalIndex Sum
            = PrimKinds.index<object>
                (
                    @short: new IndexAggregateOp<short>(InX.sum),
                    @int: new IndexAggregateOp<int>(InX.sum),
                    @float: new IndexAggregateOp<float>(InX.sum),
                    @double:new IndexAggregateOp<double>(InX.sum)
                );

        [MethodImpl(Inline)]
        public static IndexBinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,IndexBinOp<T>>();


        [MethodImpl(Inline)]
        public static IndexAggregateOp<T> sum<T>()
            where T : struct, IEquatable<T>
                => Sum.lookup<T,IndexAggregateOp<T>>();
    }

    /// <summary>
    /// Prvides singleton static immutable storage for index operations
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public static class IndexOps<T>
        where T : struct, IEquatable<T>
    {
        public static IndexBinOp<T> Add = IndexDelegates.add<T>();

        public static IndexAggregateOp<T> Sum = IndexDelegates.sum<T>();

    }

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
   
        [MethodImpl(Inline)]
        public static IndexAggregateOp<T> sum<T>()
            where T : struct, IEquatable<T>
                => IndexOps<T>.Sum;

        [MethodImpl(Inline)]
        public static T sum<T>(Index<T> src)
            where T : struct, IEquatable<T>
                => IndexOps<T>.Sum(src);
    } 
}