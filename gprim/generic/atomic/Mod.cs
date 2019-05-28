//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T mod<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return modI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return modU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return modI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return modU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return modI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return modU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return modI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return modU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return modF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return modF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref modI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref modU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref modI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref modU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref modI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref modU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref modI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref modU64(ref lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ref modF32(ref lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ref modF64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(NotInline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.mod(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.mod(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.mod(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.mod(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.mod(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.mod(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.mod(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.mod(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.mod(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.mod(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        static T modI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) % int8(rhs)));

        [MethodImpl(Inline)]
        static T modU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) % uint8(rhs)));

        [MethodImpl(Inline)]
        static T modI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) % int16(rhs)));

        [MethodImpl(Inline)]
        static T modU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) % uint16(rhs)));

        [MethodImpl(Inline)]
        static T modI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) % int32(rhs));
        
        [MethodImpl(Inline)]
        static T modU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) % uint32(rhs));

        [MethodImpl(Inline)]
        static T modI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) % int64(rhs));

        [MethodImpl(Inline)]
        static T modU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) % uint64(rhs));

        [MethodImpl(Inline)]
        static T modF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) % float32(rhs));

        [MethodImpl(Inline)]
        static T modF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) % float64(rhs));


        [MethodImpl(Inline)]
        static ref T modI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modF32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref float32(ref lhs), float32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T modF64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mod(ref float64(ref lhs), float64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            
    }
}
