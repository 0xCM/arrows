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
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return gteqI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return gteqU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return gteqI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return gteqU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return gteqI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return gteqU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return gteqI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return gteqU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return gteqF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return gteqF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.gteq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.gteq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.gteq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.gteq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.gteq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.gteq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.gteq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.gteq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.gteq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.gteq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gteq(lhs,rhs,dst);
        }

        [MethodImpl(Inline)]
        static bool gteqI8<T>(T lhs, T rhs)
            => int8(lhs) >= int8(rhs);

        [MethodImpl(Inline)]
        static bool gteqU8<T>(T lhs, T rhs)
            => uint8(lhs) >= uint8(rhs);

        [MethodImpl(Inline)]
        static bool gteqI16<T>(T lhs, T rhs)
            => int16(lhs) >= int16(rhs);

        [MethodImpl(Inline)]
        static bool gteqU16<T>(T lhs, T rhs)
            => uint16(lhs) >= uint16(rhs);

        [MethodImpl(Inline)]
        static bool gteqI32<T>(T lhs, T rhs)
            => int32(lhs) >= int32(rhs);
        
        [MethodImpl(Inline)]
        static bool gteqU32<T>(T lhs, T rhs)
            => uint32(lhs) >= uint32(rhs);

        [MethodImpl(Inline)]
        static bool gteqI64<T>(T lhs, T rhs)
            => int64(lhs) >= int64(rhs);

        [MethodImpl(Inline)]
        static bool gteqU64<T>(T lhs, T rhs)
            => uint64(lhs) >= uint64(rhs);

        [MethodImpl(Inline)]
        static bool gteqF32<T>(T lhs, T rhs)
            => float32(lhs) >= float32(rhs);

        [MethodImpl(Inline)]
        static bool gteqF64<T>(T lhs, T rhs)
            => float64(lhs) >= float64(rhs);


    }

}