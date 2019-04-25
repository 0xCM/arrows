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


    public static partial class Vec128Ops
    {

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Add;

        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.And;

        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.And(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128LoadOp<T> load<T>()
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Load;

        [MethodImpl(Inline)]
        public static unsafe Vec128<T> load<T>(void* src, out Vec128<T> dst)
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Load(src,out dst);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Or;

        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.Or(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.XOr;

        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128Ops<T>.XOr(lhs,rhs);
    }

    public static class Vec128Ops<T>
            where T : struct, IEquatable<T>
    {
        public static Vec128BinOp<T> Add = Vec128Delegates.add<T>();

        public static Vec128BinOp<T> And = Vec128Delegates.and<T>();

        public static Vec128LoadOp<T> Load = Vec128Delegates.load<T>();

        public static Vec128BinOp<T> Or = Vec128Delegates.or<T>();

        public static Vec128BinOp<T> XOr = Vec128Delegates.xor<T>();

    }

}