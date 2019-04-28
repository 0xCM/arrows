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
    
    using static zcore;
    using static inxfunc;
    using static Vec128OpCache;

    static class Vec128Delegates
    {

        static readonly PrimalIndex Eq = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinPred<sbyte>(InX.eq),
                @byte : new Vec128BinPred<byte>(InX.eq),
                @short : new Vec128BinPred<short>(InX.eq),
                @ushort : new Vec128BinPred<ushort>(InX.eq),
                @int : new Vec128BinPred<int>(InX.eq),
                @uint : new Vec128BinPred<uint>(InX.eq),
                @long : new Vec128BinPred<long>(InX.eq),
                @ulong : new Vec128BinPred<ulong>(InX.eq),
                @float : new Vec128BinPred<float>(InX.eq),
                @double : new Vec128BinPred<double>(InX.eq)
            );

        [MethodImpl(Inline)]
        public static Vec128BinPred<T> eq<T>()
            where T : struct, IEquatable<T>
                => Eq.lookup<T,Vec128BinPred<T>>();


        //! Arithmetic
        //! -------------------------------------------------------------------

        //! add

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

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Add.lookup<T,Vec128BinOp<T>>();

        //! add + store to pointer
        static unsafe readonly PrimalIndex AddPOut = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinPOut<sbyte>(InX.add),
                @byte : new Vec128BinPOut<byte>(InX.add),
                @short : new Vec128BinPOut<short>(InX.add),
                @ushort : new Vec128BinPOut<ushort>(InX.add),
                @int : new Vec128BinPOut<int>(InX.add),
                @uint : new Vec128BinPOut<uint>(InX.add),
                @long : new Vec128BinPOut<long>(InX.add),
                @ulong : new Vec128BinPOut<ulong>(InX.add),
                @float : new Vec128BinPOut<float>(InX.add),
                @double : new Vec128BinPOut<double>(InX.add)
            );

        [MethodImpl(Inline)]
        public static Vec128BinPOut<T> addPOut<T>()
            where T : struct, IEquatable<T>
                => AddPOut.lookup<T,Vec128BinPOut<T>>();

        //! sub

        static readonly PrimalIndex Sub = PrimKinds.index<object>
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.sub),
                @byte : new Vec128BinOp<byte>(InX.sub),
                @short : new Vec128BinOp<short>(InX.sub),
                @ushort : new Vec128BinOp<ushort>(InX.sub),
                @int : new Vec128BinOp<int>(InX.sub),
                @uint : new Vec128BinOp<uint>(InX.sub),
                @long : new Vec128BinOp<long>(InX.sub),
                @ulong : new Vec128BinOp<ulong>(InX.sub),
                @float : new Vec128BinOp<float>(InX.sub),
                @double : new Vec128BinOp<double>(InX.sub)
            );

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Sub.lookup<T,Vec128BinOp<T>>();


        //! avg
        static readonly PrimalIndex Avg = PrimKinds.index<object>
            (
                @byte : new Vec128BinOp<byte>(InX.avg),
                @ushort : new Vec128BinOp<ushort>(InX.avg)
            );

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> avg<T>()
            where T : struct, IEquatable<T>
                => Avg.lookup<T,Vec128BinOp<T>>();


        //! div
        static readonly PrimalIndex CmpF = PrimKinds.index<object>
            (
                @float : new Vec128CmpFloat<float>(InX.cmpf),
                @double : new Vec128CmpFloat<double>(InX.cmpf)
            );

        [MethodImpl(Inline)]
        public static Vec128CmpFloat<T> cmpf<T>()
            where T : struct, IEquatable<T>
                => CmpF.lookup<T,Vec128CmpFloat<T>>();

        //! div
        static readonly PrimalIndex Div = PrimKinds.index<object>
            (
                @float : new Vec128BinOp<float>(InX.div),
                @double : new Vec128BinOp<double>(InX.div)
            );

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Div.lookup<T,Vec128BinOp<T>>();

        //! load

        [MethodImpl(Inline)]
        static unsafe Vec128<sbyte> loadI8(void* src)
            => Avx2.LoadVector128((sbyte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<byte> loadU8(void* src)
            => Avx2.LoadVector128((byte*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<short> loadI16(void* src)
            => Avx2.LoadVector128((short*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<ushort> loadU16(void* src)
            => Avx2.LoadVector128((ushort*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<int> loadI32(void* src)
            => Avx2.LoadVector128((int*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<uint> loadU32(void* src)
            => Avx2.LoadVector128((uint*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<long> loadI64(void* src)
            => Avx2.LoadVector128((long*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<ulong> loadU64(void* src)
            => Avx2.LoadVector128((ulong*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<float> loadF32(void* src)
            => Avx2.LoadVector128((float*)src);

        [MethodImpl(Inline)]
        static unsafe Vec128<double> loadF64(void* src)
            => Avx2.LoadVector128((double*)src);


        static readonly unsafe PrimalIndex Load = PrimKinds.index<object>
            (
                @sbyte : new Vec128LoadOp<sbyte>(loadI8),
                @byte : new Vec128LoadOp<byte>(loadU8),
                @short : new Vec128LoadOp<short>(loadI16),
                @ushort : new Vec128LoadOp<ushort>(loadU16),
                @int : new Vec128LoadOp<int>(loadI32),
                @uint : new Vec128LoadOp<uint>(loadU32),
                @long : new Vec128LoadOp<long>(loadI64),
                @ulong : new Vec128LoadOp<ulong>(loadU64),
                @float : new Vec128LoadOp<float>(loadF32),
                @double : new Vec128LoadOp<double>(loadF64)
            );


        [MethodImpl(Inline)]
        public static Vec128LoadOp<T> load<T>()
            where T : struct, IEquatable<T>
                => Load.lookup<T,Vec128LoadOp<T>>();


        //! min
        static readonly unsafe PrimalIndex Min = PrimalIndex.define
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.min),
                @byte : new Vec128BinOp<byte>(InX.min),
                @short : new Vec128BinOp<short>(InX.min),
                @ushort : new Vec128BinOp<ushort>(InX.min),
                @int : new Vec128BinOp<int>(InX.min),
                @uint : new Vec128BinOp<uint>(InX.min),
                @float : new Vec128BinOp<float>(InX.min),
                @double : new Vec128BinOp<double>(InX.min)
            );


        [MethodImpl(Inline)]
        public static Vec128BinOp<T> min<T>()
            where T : struct, IEquatable<T>
                => Min.lookup<T,Vec128BinOp<T>>();

        //! min
        static readonly unsafe PrimalIndex Max = PrimalIndex.define
            (
                @sbyte : new Vec128BinOp<sbyte>(InX.max),
                @byte : new Vec128BinOp<byte>(InX.max),
                @short : new Vec128BinOp<short>(InX.max),
                @ushort : new Vec128BinOp<ushort>(InX.max),
                @int : new Vec128BinOp<int>(InX.max),
                @uint : new Vec128BinOp<uint>(InX.max),
                @float : new Vec128BinOp<float>(InX.max),
                @double : new Vec128BinOp<double>(InX.max)
            );


        [MethodImpl(Inline)]
        public static Vec128BinOp<T> max<T>()
            where T : struct, IEquatable<T>
                => Max.lookup<T,Vec128BinOp<T>>();

        //! mul
        
        static readonly PrimalIndex Mul = PrimalIndex.define
            (
                @int : new Vec128BinOp<int,long>(InX.mul),
                @uint : new Vec128BinOp<uint, ulong>(InX.mul),
                @float : new Vec128BinOp<float,float>(InX.mul),
                @double : new Vec128BinOp<double,double>(InX.mul)
            );

        [MethodImpl(Inline)]
        public static Vec128BinOp<S,T> mul<S,T>()
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
                => Mul.lookup<S,Vec128BinOp<S,T>>();


        //! Memory
        //! -------------------------------------------------------------------

        //! store (to pointer)

        static unsafe readonly PrimalIndex StoreP = PrimalIndex.define
            (
                @sbyte : new Vec128StorePOp<sbyte>(InX.store),
                @byte : new Vec128StorePOp<byte>(InX.store),
                @short : new Vec128StorePOp<short>(InX.store),
                @ushort : new Vec128StorePOp<ushort>(InX.store),
                @int : new Vec128StorePOp<int>(InX.store),
                @uint : new Vec128StorePOp<uint>(InX.store),
                @long : new Vec128StorePOp<long>(InX.store),
                @ulong : new Vec128StorePOp<ulong>(InX.store),
                @float : new Vec128StorePOp<float>(InX.store),
                @double : new Vec128StorePOp<double>(InX.store)
            );

        [MethodImpl(Inline)]
        public static Vec128StorePOp<T> storeP<T>()
            where T : struct, IEquatable<T>
                => StoreP.lookup<T,Vec128StorePOp<T>>();

        //! store (to array)
        
        static unsafe readonly PrimalIndex StoreA = PrimalIndex.define
            (
                @sbyte : new Vec128StoreAOp<sbyte>(InX.store),
                @byte : new Vec128StoreAOp<byte>(InX.store),
                @short : new Vec128StoreAOp<short>(InX.store),
                @ushort : new Vec128StoreAOp<ushort>(InX.store),
                @int : new Vec128StoreAOp<int>(InX.store),
                @uint : new Vec128StoreAOp<uint>(InX.store),
                @long : new Vec128StoreAOp<long>(InX.store),
                @ulong : new Vec128StoreAOp<ulong>(InX.store),
                @float : new Vec128StoreAOp<float>(InX.store),
                @double : new Vec128StoreAOp<double>(InX.store)
            );

        [MethodImpl(Inline)]
        public static Vec128StoreAOp<T> storeA<T>()
            where T : struct, IEquatable<T>
                => StoreA.lookup<T,Vec128StoreAOp<T>>();

        //! stream
        
        static unsafe readonly PrimalIndex Stream = PrimalIndex.define
            (
                @sbyte : new Vec128StreamOp<sbyte>(Vec128.stream),
                @byte : new Vec128StreamOp<byte>(Vec128.stream),
                @short : new Vec128StreamOp<short>(Vec128.stream),
                @ushort : new Vec128StreamOp<ushort>(Vec128.stream),
                @int : new Vec128StreamOp<int>(Vec128.stream),
                @uint : new Vec128StreamOp<uint>(Vec128.stream),
                @long : new Vec128StreamOp<long>(Vec128.stream),
                @ulong : new Vec128StreamOp<ulong>(Vec128.stream),
                @float : new Vec128StreamOp<float>(Vec128.stream),
                @double : new Vec128StreamOp<double>(Vec128.stream)
            );

        [MethodImpl(Inline)]
        public static Vec128StreamOp<T> stream<T>()
            where T : struct, IEquatable<T>
                => Stream.lookup<T,Vec128StreamOp<T>>();


        //! Bitwise
        //! -------------------------------------------------------------------

        //! and

        static readonly PrimalIndex And = PrimalIndex.define
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

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => And.lookup<T,Vec128BinOp<T>>();

        //! and + store to pointer
        static unsafe readonly PrimalIndex AndPOut = PrimalIndex.define
            (
                @sbyte : new Vec128BinPOut<sbyte>(InX.and),
                @byte : new Vec128BinPOut<byte>(InX.and),
                @short : new Vec128BinPOut<short>(InX.and),
                @ushort : new Vec128BinPOut<ushort>(InX.and),
                @int : new Vec128BinPOut<int>(InX.and),
                @uint : new Vec128BinPOut<uint>(InX.and),
                @long : new Vec128BinPOut<long>(InX.and),
                @ulong : new Vec128BinPOut<ulong>(InX.and),
                @float : new Vec128BinPOut<float>(InX.and),
                @double : new Vec128BinPOut<double>(InX.and)
            );

        [MethodImpl(Inline)]
        public static Vec128BinPOut<T> andPOut<T>()
            where T : struct, IEquatable<T>
                => AndPOut.lookup<T,Vec128BinPOut<T>>();

        //! or
        
        static readonly PrimalIndex Or = PrimalIndex.define
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

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Or.lookup<T,Vec128BinOp<T>>();

        //! xor

        static readonly PrimalIndex XOr = PrimalIndex.define
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
        public static Vec128BinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => XOr.lookup<T,Vec128BinOp<T>>();



        static readonly PrimalIndex AllOn = PrimalIndex.define
            (
                @sbyte : new Vec128UnaryPred<sbyte>(InX.allOn),
                @byte : new Vec128UnaryPred<byte>(InX.allOn),
                @short : new Vec128UnaryPred<short>(InX.allOn),
                @ushort : new Vec128UnaryPred<ushort>(InX.allOn),
                @int : new Vec128UnaryPred<int>(InX.allOn),
                @uint : new Vec128UnaryPred<uint>(InX.allOn),
                @long : new Vec128UnaryPred<long>(InX.allOn),
                @ulong : new Vec128UnaryPred<ulong>(InX.allOn)
            );

        [MethodImpl(Inline)]
        public static Vec128UnaryPred<T> allOn<T>()
            where T : struct, IEquatable<T>
                => AllOn.lookup<T,Vec128UnaryPred<T>>();


        static readonly PrimalIndex Off = PrimalIndex.define
            (
                @sbyte : new Vec128BinPred<sbyte>(InX.off),
                @byte : new Vec128BinPred<byte>(InX.off),
                @short : new Vec128BinPred<short>(InX.off),
                @ushort : new Vec128BinPred<ushort>(InX.off),
                @int : new Vec128BinPred<int>(InX.off),
                @uint : new Vec128BinPred<uint>(InX.off),
                @long : new Vec128BinPred<long>(InX.off),
                @ulong : new Vec128BinPred<ulong>(InX.off)
            );

        [MethodImpl(Inline)]
        public static Vec128BinPred<T> off<T>()
            where T : struct, IEquatable<T>
                => Off.lookup<T,Vec128BinPred<T>>();

    }

    public static class Vec128OpCache
    {
        public readonly struct Eq<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinPred<T> Op = Vec128Delegates.eq<T>();
        }

        public readonly struct Add<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.add<T>();

        }

        public readonly struct AddPOut<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinPOut<T> Op = Vec128Delegates.addPOut<T>();

        }

        public readonly struct Avg<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.avg<T>();
        }

        public readonly struct CmpF<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128CmpFloat<T> Op = Vec128Delegates.cmpf<T>();

        }

        public readonly struct Div<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.div<T>();

        }

        public readonly struct Load<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128LoadOp<T> Op = Vec128Delegates.load<T>();

        }

        public readonly struct Min<T>
            where T : struct, IEquatable<T>
        {

            public static readonly Vec128BinOp<T> Op = Vec128Delegates.min<T>();

        }

        public readonly struct Max<T>
            where T : struct, IEquatable<T>
        {

            public static readonly Vec128BinOp<T> Op = Vec128Delegates.max<T>();

        }

        public readonly struct Mul<S,T>
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
        {

            public static readonly Vec128BinOp<S,T> Op = Vec128Delegates.mul<S,T>();

        }


        public readonly struct StoreA<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128StoreAOp<T> Op = Vec128Delegates.storeA<T>();
        }

        public readonly struct StoreP<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128StorePOp<T> Op = Vec128Delegates.storeP<T>();
        }

        public readonly struct Stream<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128StreamOp<T> Op = Vec128Delegates.stream<T>();
        }

        public readonly struct Sub<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.sub<T>();
        }

        public readonly struct And<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.and<T>();

        }

        public readonly struct AndPOut<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinPOut<T> Op = Vec128Delegates.andPOut<T>();

        }

        public readonly struct Or<T>
            where T : struct, IEquatable<T>
        {

            public static readonly Vec128BinOp<T> Op = Vec128Delegates.or<T>();
        }

        public readonly struct XOr<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinOp<T> Op = Vec128Delegates.xor<T>();
        }

        public readonly struct AllOn<T>
            where T : struct, IEquatable<T>
        {

            public static readonly Vec128UnaryPred<T> Op = Vec128Delegates.allOn<T>();
        }

        public readonly struct Off<T>
            where T : struct, IEquatable<T>
        {
            public static readonly Vec128BinPred<T> Op = Vec128Delegates.off<T>();
        }

    }

    public static class InXVec128Ops
    {
        [MethodImpl(Inline)]
        public static Vec128BinPred<T> eq<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Eq<T>.Op;

        [MethodImpl(Inline)]
        public static bool eq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Eq<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> add<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Add<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Add<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
                => Vec128OpCache.AddPOut<T>.Op(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> avg<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Avg<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> avg<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Avg<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128CmpFloat<T> cmpf<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.CmpF<T>.Op;

        [MethodImpl(Inline)]
        public static bool[] cmpf<T>(in Vec128<T> lhs, in Vec128<T> rhs, FloatCompareKind mode)
            where T : struct, IEquatable<T>
                => Vec128OpCache.CmpF<T>.Op(lhs,rhs,mode);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> div<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Div<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> div<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Div<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128LoadOp<T> load<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Load<T>.Op;

        [MethodImpl(Inline)]
        public static unsafe Vec128<T> load<T>(void* src, out Vec128<T> dst)
            where T : struct, IEquatable<T>
                => dst = Vec128OpCache.Load<T>.Op(src);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> min<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Min<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> min<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Min<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> max<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Max<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> max<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Max<T>.Op(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static Vec128BinOp<S,T> mul<S,T>()
            where T : struct, IEquatable<T>
            where S : struct, IEquatable<S>
                => Vec128OpCache.Mul<S,T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> mul<S,T>(in Vec128<S> lhs, in Vec128<S> rhs)
            where S : struct, IEquatable<S>
            where T : struct, IEquatable<T>
                => Vec128OpCache.Mul<S,T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128StorePOp<T> storeP<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.StoreP<T>.Op;


        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec128<T> src, void* dst)
            where T : struct, IEquatable<T>
                => Vec128OpCache.StoreP<T>.Op(src, dst);

        [MethodImpl(Inline)]
        public static Vec128StoreAOp<T> storeA<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.StoreA<T>.Op;

        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec128<T> src, T[] dst, int offset = 0)
            where T : struct, IEquatable<T>
                => Vec128OpCache.StoreA<T>.Op(src, dst, offset);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> sub<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Sub<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> sub<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Sub<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> and<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.And<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> and<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.And<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static unsafe void and<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
                => Vec128OpCache.AndPOut<T>.Op(lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> or<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.Or<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Or<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128BinOp<T> xor<T>()
            where T : struct, IEquatable<T>
                => Vec128OpCache.XOr<T>.Op;

        [MethodImpl(Inline)]
        public static Vec128<T> xor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
                => Vec128OpCache.XOr<T>.Op(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool allOn<T>(in Vec128<T> src)
            where T : struct, IEquatable<T>
                => Vec128OpCache.AllOn<T>.Op(src);

        [MethodImpl(Inline)]
        public static bool off<T>(in Vec128<T> src, Vec128<T> mask)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Off<T>.Op(src,mask);

        [MethodImpl(Inline)]
        public static IEnumerable<Vec128<T>> stream<T>(T[] src)
            where T : struct, IEquatable<T>
                => Vec128OpCache.Stream<T>.Op(src);

    }
}