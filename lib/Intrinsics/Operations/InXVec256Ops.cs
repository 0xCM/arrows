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

        [MethodImpl(Inline)]
        static unsafe Vec256<sbyte> loadI8(void* src, out Vec256<sbyte> dst)
            => dst = Avx2.LoadVector256((sbyte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<byte> loadU8(void* src, out Vec256<byte> dst)
            => dst = Avx2.LoadVector256((byte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<short> loadI16(void* src, out Vec256<short> dst)
            => dst = Avx2.LoadVector256((short*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<ushort> loadU16(void* src, out Vec256<ushort> dst)
            => dst = Avx2.LoadVector256((ushort*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<int> loadI32(void* src, out Vec256<int> dst)
            => dst = Avx2.LoadVector256((int*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> loadU32(void* src, out Vec256<uint> dst)
            => dst = Avx2.LoadVector256((uint*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<long> loadI64(void* src, out Vec256<long> dst)
            => dst = Avx2.LoadVector256((long*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> loadU64(void* src, out Vec256<ulong> dst)
            => dst = Avx2.LoadVector256((ulong*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<float> loadF32(void* src, out Vec256<float> dst)
            => dst = Avx2.LoadVector256((float*)src);

        [MethodImpl(Inline)]
        static unsafe Vec256<double> loadF64(void* src, out Vec256<double> dst)
            => dst = Avx2.LoadVector256((double*)src);

        static readonly unsafe PrimalIndex Load = PrimKinds.index<object>
            (
                @sbyte : new Vec256LoadOp<sbyte>(loadI8),
                @byte : new Vec256LoadOp<byte>(loadU8),
                @short : new Vec256LoadOp<short>(loadI16),
                @ushort : new Vec256LoadOp<ushort>(loadU16),
                @int : new Vec256LoadOp<int>(loadI32),
                @uint : new Vec256LoadOp<uint>(loadU32),
                @long : new Vec256LoadOp<long>(loadI64),
                @ulong : new Vec256LoadOp<ulong>(loadU64),
                @float : new Vec256LoadOp<float>(loadF32),
                @double : new Vec256LoadOp<double>(loadF64)
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