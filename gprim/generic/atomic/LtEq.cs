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
        public static bool lteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return lteqI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return lteqU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return lteqI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return lteqU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return lteqI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return lteqU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return lteqI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return lteqU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return lteqF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return lteqF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.lteq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.lteq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.lteq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.lteq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.lteq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.lteq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.lteq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.lteq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.lteq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.lteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gmath.lteq(lhs,rhs,dst);
        }

        [MethodImpl(Inline)]
        static bool lteqI8<T>(T lhs, T rhs)
            => int8(lhs) <= int8(rhs);

        [MethodImpl(Inline)]
        static bool lteqU8<T>(T lhs, T rhs)
            => uint8(lhs) <= uint8(rhs);

        [MethodImpl(Inline)]
        static bool lteqI16<T>(T lhs, T rhs)
            => int16(lhs) <= int16(rhs);

        [MethodImpl(Inline)]
        static bool lteqU16<T>(T lhs, T rhs)
            => uint16(lhs) <= uint16(rhs);

        [MethodImpl(Inline)]
        static bool lteqI32<T>(T lhs, T rhs)
            => int32(lhs) <= int32(rhs);
        
        [MethodImpl(Inline)]
        static bool lteqU32<T>(T lhs, T rhs)
            => uint32(lhs) <= uint32(rhs);

        [MethodImpl(Inline)]
        static bool lteqI64<T>(T lhs, T rhs)
            => int64(lhs) <= int64(rhs);

        [MethodImpl(Inline)]
        static bool lteqU64<T>(T lhs, T rhs)
            => uint64(lhs) <= uint64(rhs);

        [MethodImpl(Inline)]
        static bool lteqF32<T>(T lhs, T rhs)
            => float32(lhs) <= float32(rhs);

        [MethodImpl(Inline)]
        static bool lteqF64<T>(T lhs, T rhs)
            => float64(lhs) <= float64(rhs);


    }

}