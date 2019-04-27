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

    static class Vec256Delegates
    {

        static readonly PrimalIndex Add = PrimKinds.index<object>
            (
                @sbyte : new Vec256BinOp<sbyte>(InX.add),
                @byte : new Vec256BinOp<byte>(InX.add),
                @short : new Vec256BinOp<short>(InX.add),
                @ushort : new Vec256BinOp<ushort>(InX.add),
                @int : new Vec256BinOp<int>(InX.add),
                @uint : new Vec256BinOp<uint>(InX.add),
                @long : new Vec256BinOp<long>(InX.add),
                @ulong : new Vec256BinOp<ulong>(InX.add),
                @float : new Vec256BinOp<float>(InX.add),
                @double : new Vec256BinOp<double>(InX.add)
            );

        static readonly PrimalIndex Or = PrimKinds.index<object>
            (
                @sbyte : new Vec256BinOp<sbyte>(InX.or),
                @byte : new Vec256BinOp<byte>(InX.or),
                @short : new Vec256BinOp<short>(InX.or),
                @ushort : new Vec256BinOp<ushort>(InX.or),
                @int : new Vec256BinOp<int>(InX.or),
                @uint : new Vec256BinOp<uint>(InX.or),
                @long : new Vec256BinOp<long>(InX.or),
                @ulong : new Vec256BinOp<ulong>(InX.or),
                @float : new Vec256BinOp<float>(InX.or),
                @double : new Vec256BinOp<double>(InX.or)
            );

        static readonly PrimalIndex XOr = PrimKinds.index<object>
            (
                @sbyte : new Vec256BinOp<sbyte>(InX.xor),
                @byte : new Vec256BinOp<byte>(InX.xor),
                @short : new Vec256BinOp<short>(InX.xor),
                @ushort : new Vec256BinOp<ushort>(InX.xor),
                @int : new Vec256BinOp<int>(InX.xor),
                @uint : new Vec256BinOp<uint>(InX.xor),
                @long : new Vec256BinOp<long>(InX.xor),
                @ulong : new Vec256BinOp<ulong>(InX.xor),
                @float : new Vec256BinOp<float>(InX.xor),
                @double : new Vec256BinOp<double>(InX.xor)
            );

        static readonly unsafe PrimalIndex Load = PrimKinds.index<object>
            (
                @sbyte : new Vec256LoadOp<sbyte>(InX.load),
                @byte : new Vec256LoadOp<byte>(InX.load),
                @short : new Vec256LoadOp<short>(InX.load),
                @ushort : new Vec256LoadOp<ushort>(InX.load),
                @int : new Vec256LoadOp<int>(InX.load),
                @uint : new Vec256LoadOp<uint>(InX.load),
                @long : new Vec256LoadOp<long>(InX.load),
                @ulong : new Vec256LoadOp<ulong>(InX.load),
                @float : new Vec256LoadOp<float>(InX.load),
                @double : new Vec256LoadOp<double>(InX.load)
            );

        
        static readonly PrimalIndex Mul = PrimKinds.index<object>
            (
                @int : new Vec256BinOp<int,long>(InX.mul),
                @uint : new Vec256BinOp<uint, ulong>(InX.mul),
                @float : new Vec256BinOp<float,float>(InX.mul),
                @double : new Vec256BinOp<double,double>(InX.mul)
            );

        [MethodImpl(Inline)]
        public static Vec128BinOp<S,T> mul<S,T>()
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
                => Mul.lookup<S,Vec128BinOp<S,T>>();

 
        [MethodImpl(Inline)]
        public static Vec256BinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr.lookup<T,Vec256BinOp<T>>();

        [MethodImpl(Inline)]
        public static Vec256BinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or.lookup<T,Vec256BinOp<T>>();

        [MethodImpl(Inline)]
        public static Vec256BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,Vec256BinOp<T>>();        

        [MethodImpl(Inline)]
        public static Vec256LoadOp<T> load<T>()
            where T : struct, IEquatable<T>
                => Load.lookup<T,Vec256LoadOp<T>>();        
    }

}