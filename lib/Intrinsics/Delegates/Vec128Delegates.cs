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



    static class Vec128Delegates
    {
        static readonly PrimalIndex Add = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.add),
                @byte : new Vec128BinOp<byte>(InX.add),
                @short : new Vec128BinOp<short>(InX.add),
                @ushort : new Vec128BinOp<ushort>(InX.add),
                @int : new Vec128BinOp<int>(InX.add),
                @uint : new Vec128BinOp<uint>(InX.add),
                @long : new Vec128BinOp<long>(InX.add),
                @ulong : new Vec128BinOp<ulong>(InX.add),
                @float : new Vec128BinOp<float>(InX.add),
                @double : new Vec128BinOp<double>(InX.add)
            );

        static readonly PrimalIndex And = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.and),
                @byte : new Vec128BinOp<byte>(InX.and),
                @short : new Vec128BinOp<short>(InX.and),
                @ushort : new Vec128BinOp<ushort>(InX.and),
                @int : new Vec128BinOp<int>(InX.and),
                @uint : new Vec128BinOp<uint>(InX.and),
                @long : new Vec128BinOp<long>(InX.and),
                @ulong : new Vec128BinOp<ulong>(InX.and),
                @float : new Vec128BinOp<float>(InX.and),
                @double : new Vec128BinOp<double>(InX.and)
            );

        static readonly unsafe PrimalIndex Load = PrimKinds.index<object>
            (
                @sbyte : new Vec128LoadOp<sbyte>(InX.load),
                @byte : new Vec128LoadOp<byte>(InX.load),
                @short : new Vec128LoadOp<short>(InX.load),
                @ushort : new Vec128LoadOp<ushort>(InX.load),
                @int : new Vec128LoadOp<int>(InX.load),
                @uint : new Vec128LoadOp<uint>(InX.load),
                @long : new Vec128LoadOp<long>(InX.load),
                @ulong : new Vec128LoadOp<ulong>(InX.load),
                @float : new Vec128LoadOp<float>(InX.load),
                @double : new Vec128LoadOp<double>(InX.load)
            );

        static readonly PrimalIndex Or = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.or),
                @byte : new Vec128BinOp<byte>(InX.or),
                @short : new Vec128BinOp<short>(InX.or),
                @ushort : new Vec128BinOp<ushort>(InX.or),
                @int : new Vec128BinOp<int>(InX.or),
                @uint : new Vec128BinOp<uint>(InX.or),
                @long : new Vec128BinOp<long>(InX.or),
                @ulong : new Vec128BinOp<ulong>(InX.or),
                @float : new Vec128BinOp<float>(InX.or),
                @double : new Vec128BinOp<double>(InX.or)
            );

        static readonly PrimalIndex XOr = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.xor),
                @byte : new Vec128BinOp<byte>(InX.xor),
                @short : new Vec128BinOp<short>(InX.xor),
                @ushort : new Vec128BinOp<ushort>(InX.xor),
                @int : new Vec128BinOp<int>(InX.xor),
                @uint : new Vec128BinOp<uint>(InX.xor),
                @long : new Vec128BinOp<long>(InX.xor),
                @ulong : new Vec128BinOp<ulong>(InX.xor),
                @float : new Vec128BinOp<float>(InX.xor),
                @double : new Vec128BinOp<double>(InX.xor)
            );



        [MethodImpl(Inline)]
        public static Vec128BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,Vec128BinOp<T>>();


        [MethodImpl(Inline)]
        public static Vec128BinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And.lookup<T,Vec128BinOp<T>>();

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr.lookup<T,Vec128BinOp<T>>();

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or.lookup<T,Vec128BinOp<T>>();


        [MethodImpl(Inline)]
        public static Vec128LoadOp<T> load<T>()
            where T : struct, IEquatable<T>
                => Load.lookup<T,Vec128LoadOp<T>>();



    }


}