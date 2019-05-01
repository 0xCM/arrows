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


    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Num128<T> add<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.float32)
                return Avx2.AddScalar(lhs.As<float>(), rhs.As<float>()).As<float,T>();

            if(kind == PrimalKind.float64)
                return Avx2.AddScalar(lhs.As<double>(), rhs.As<double>()).As<double,T>();

            throw errors.unsupported(kind);
        }



        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return Avx2.Add(lhs.As<sbyte>(), rhs.As<sbyte>()).As<sbyte,T>();

            if(kind == PrimalKind.uint8)
                return Avx2.Add(lhs.As<byte>(), rhs.As<byte>()).As<byte,T>();

            if(kind == PrimalKind.int16)
                return Avx2.Add(lhs.As<short>(), rhs.As<short>()).As<short,T>();

            if(kind == PrimalKind.uint16)
                return Avx2.Add(lhs.As<ushort>(), rhs.As<ushort>()).As<ushort,T>();

            if(kind == PrimalKind.int32)
                return Avx2.Add(lhs.As<int>(), rhs.As<int>()).As<int,T>();

            if(kind == PrimalKind.uint32)
                return Avx2.Add(lhs.As<uint>(), rhs.As<uint>()).As<uint,T>();

            if(kind == PrimalKind.int64)
                return Avx2.Add(lhs.As<long>(), rhs.As<long>()).As<long,T>();

            if(kind == PrimalKind.uint64)
                return Avx2.Add(lhs.As<ulong>(), rhs.As<ulong>()).As<ulong,T>();

            if(kind == PrimalKind.float32)
                return Avx2.Add(lhs.As<float>(), rhs.As<float>()).As<float,T>();

            if(kind == PrimalKind.float64)
                return Avx2.Add(lhs.As<double>(), rhs.As<double>()).As<double,T>();

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static unsafe void add<T>(in Vec128<T> lhs, in Vec128<T> rhs, void* dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                dinx.add(As.uint8(lhs), As.uint8(rhs), dst);

            if(kind == PrimalKind.uint8)
                dinx.add(As.uint8(lhs), As.uint8(rhs), dst);

            if(kind == PrimalKind.int16)
                dinx.add(As.int16(lhs), As.int16(rhs), dst);

            if(kind == PrimalKind.uint16)
                dinx.add(As.uint16(lhs), As.uint16(rhs), dst);

            if(kind == PrimalKind.int32)
                dinx.add(As.int32(lhs), As.int32(rhs), dst);

            if(kind == PrimalKind.uint32)
                dinx.add(As.uint32(lhs), As.uint32(rhs), dst);

            if(kind == PrimalKind.int64)
                dinx.add(As.int64(lhs), As.int64(rhs), dst);

            if(kind == PrimalKind.uint64)
                dinx.add(As.uint64(lhs), As.uint64(rhs), dst);

            if(kind == PrimalKind.float32)
                dinx.add(As.float32(lhs), As.float32(rhs), dst);

            if(kind == PrimalKind.float64)
                dinx.add(As.uint8(lhs), As.uint8(rhs), dst);
            
            throw errors.unsupported(kind);
        }
            


        [MethodImpl(Inline)]
        public static Vec256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int8)
                return Avx2.Add(lhs.As<sbyte>(), rhs.As<sbyte>()).As<sbyte,T>();

            if(kind == PrimalKind.uint8)
                return Avx2.Add(lhs.As<byte>(), rhs.As<byte>()).As<byte,T>();

            if(kind == PrimalKind.int16)
                return Avx2.Add(lhs.As<short>(), rhs.As<short>()).As<short,T>();

            if(kind == PrimalKind.uint16)
                return Avx2.Add(lhs.As<ushort>(), rhs.As<ushort>()).As<ushort,T>();

            if(kind == PrimalKind.int32)
                return Avx2.Add(lhs.As<int>(), rhs.As<int>()).As<int,T>();

            if(kind == PrimalKind.uint32)
                return Avx2.Add(lhs.As<uint>(), rhs.As<uint>()).As<uint,T>();

            if(kind == PrimalKind.int64)
                return Avx2.Add(lhs.As<long>(), rhs.As<long>()).As<long,T>();

            if(kind == PrimalKind.uint64)
                return Avx2.Add(lhs.As<ulong>(), rhs.As<ulong>()).As<ulong,T>();

            if(kind == PrimalKind.float32)
                return Avx2.Add(lhs.As<float>(), rhs.As<float>()).As<float,T>();

            if(kind == PrimalKind.float64)
                return Avx2.Add(lhs.As<double>(), rhs.As<double>()).As<double,T>();

            throw errors.unsupported(kind);
        }

        [MethodImpl(Inline)]
        public static ref T[] add<T>(T[] lhs, T[] rhs, ref T[] dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();        
            if(kind == PrimalKind.int8)
            {
                ref var xDst = ref As.int8(ref dst);
                dinx.add(As.int8(ref lhs), As.int8(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.uint8)
            {
                ref var xDst = ref As.uint8(ref dst);
                dinx.add(As.uint8(ref lhs), As.uint8(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.int16)
            {
                ref var xDst = ref As.int16(ref dst);
                dinx.add(As.int16(ref lhs), As.int16(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.uint16)
            {
                ref var xDst = ref As.uint16(ref dst);
                dinx.add(As.uint16(ref lhs), As.uint16(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.int32)
            {
                ref var xDst = ref As.int32(ref dst);
                dinx.add(As.int32(ref lhs), As.int32(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.uint32)
            {
                ref var xDst = ref As.uint32(ref dst);
                dinx.add(As.uint32(ref lhs), As.uint32(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.int64)
            {
                ref var xDst = ref As.int64(ref dst);
                dinx.add(As.int64(ref lhs), As.int64(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.uint64)
            {
                ref var xDst = ref As.uint64(ref dst);
                dinx.add(As.uint64(ref lhs), As.uint64(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.float32)
            {
                ref var xDst = ref As.float32(ref dst);
                dinx.add(As.float32(ref lhs), As.float32(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            if(kind == PrimalKind.float64)
            {
                ref var xDst = ref As.float64(ref dst);
                dinx.add(As.float64(ref lhs), As.float64(ref rhs), ref xDst);
                return ref As.generic<T>(ref xDst);
            }

            throw errors.unsupported(kind);
        }
    }
}