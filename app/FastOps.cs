namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static zcore;

    public readonly struct Result<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator T(Result<T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Result<T>(T src)
            => new Result<T>(src);

        [MethodImpl(Inline)]
        public Result(T Value)
            => this.Value = Value;

        public readonly T Value;
    }

    public static class FastOps
    {

        [MethodImpl(Inline)]
        static Result<T> addI8<T>(T lhs, T rhs)
        {
            var result = (sbyte)(Unsafe.As<T,sbyte>(ref lhs) + Unsafe.As<T,sbyte>(ref rhs));
            return Unsafe.As<sbyte,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addU8<T>(T lhs, T rhs)
        {
            var result = (byte)(Unsafe.As<T,byte>(ref lhs) + Unsafe.As<T,byte>(ref rhs));
            return Unsafe.As<byte,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addI16<T>(T lhs, T rhs)
        {
            var result = (short)(Unsafe.As<T,short>(ref lhs) + Unsafe.As<T,short>(ref rhs));
            return Unsafe.As<short,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addU16<T>(T lhs, T rhs)
        {
            var result = (ushort)(Unsafe.As<T,ushort>(ref lhs) + Unsafe.As<T,ushort>(ref rhs));
            return Unsafe.As<ushort,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addI32<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,int>(ref lhs) + Unsafe.As<T,int>(ref rhs);
            return Unsafe.As<int,T>(ref result);
        }
        
        [MethodImpl(Inline)]
        static Result<T> addU32<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,uint>(ref lhs) + Unsafe.As<T,uint>(ref rhs);
            return Unsafe.As<uint,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addI64<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,long>(ref lhs) + Unsafe.As<T,long>(ref rhs);
            return Unsafe.As<long,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addU64<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,ulong>(ref lhs) + Unsafe.As<T,ulong>(ref rhs);
            return Unsafe.As<ulong,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addF32<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,float>(ref lhs) + Unsafe.As<T,float>(ref rhs);
            return Unsafe.As<float,T>(ref result);
        }

        [MethodImpl(Inline)]
        static Result<T> addF64<T>(T lhs, T rhs)
        {
            var result = Unsafe.As<T,double>(ref lhs) + Unsafe.As<T,double>(ref rhs);
            return Unsafe.As<double,T>(ref result);
        }

        public static (long ticks, long ms, string format) TimeAdd(int reps)
        {
            var sw = stopwatch();
            for (int i = 0; i < reps; i++) 
            {
                var resut = add(2u,3u).Value;
            }
            return snapshot(sw);
        }

        [MethodImpl(Inline)]
        public static Result<T> add<T>(T lhs, T rhs)
            where T : struct, IEquatable<T>
        {
            var kind = PrimKinds.kind<T>();

            if(kind == PrimKind.float32)
                return addF32(lhs,rhs);

            if(kind == PrimKind.float64)
                return addF64(lhs,rhs);

            if(kind == PrimKind.int32)
                return addI32(lhs,rhs);

            if(kind == PrimKind.uint32)
                return addU32(lhs,rhs);

            if(kind == PrimKind.int64)
                return addI64(lhs,rhs);

            if(kind == PrimKind.uint64)
                return addU64(lhs,rhs);

            if(kind == PrimKind.int16)
                return addI16(lhs,rhs);

            if(kind == PrimKind.uint16)
                return addU16(lhs,rhs);

            if(kind == PrimKind.int8)
                return addI8(lhs,rhs);

            if(kind == PrimKind.uint8)
                return addU8(lhs,rhs);

            throw new Exception("Kind not supported");
        }
    }
}