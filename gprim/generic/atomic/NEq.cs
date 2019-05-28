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
        public static bool neq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return neqI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return neqU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return neqI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return neqU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return neqI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return neqU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return neqI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return neqU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return neqF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return neqF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.neq(int8(lhs), int8(rhs), dst);
            else if(kind == PrimalKind.uint8)
                math.neq(uint8(lhs), uint8(rhs), dst);
            else if(kind == PrimalKind.int16)
                math.neq(int16(lhs), int16(rhs), dst);
            else if(kind == PrimalKind.uint16)
                math.neq(uint16(lhs), uint16(rhs), dst);
            else if(kind == PrimalKind.int32)
                math.neq(int32(lhs), int32(rhs), dst);
            else if(kind == PrimalKind.uint32)
                math.neq(uint32(lhs), uint32(rhs), dst);
            else if(kind == PrimalKind.int64)
                math.neq(int64(lhs), int64(rhs), dst);
            else if(kind == PrimalKind.uint64)
                math.neq(uint64(lhs), uint64(rhs), dst);
            else if(kind == PrimalKind.float32)
                math.neq(float32(lhs), float32(rhs), dst);
            else if(kind == PrimalKind.float64)
                math.neq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        static bool neqI8<T>(T lhs, T rhs)
            => int8(lhs) != int8(rhs);

        [MethodImpl(Inline)]
        static bool neqU8<T>(T lhs, T rhs)
            => uint8(lhs) != uint8(rhs);

        [MethodImpl(Inline)]
        static bool neqI16<T>(T lhs, T rhs)
            => int16(lhs) != int16(rhs);

        [MethodImpl(Inline)]
        static bool neqU16<T>(T lhs, T rhs)
            => uint16(lhs) != uint16(rhs);

        [MethodImpl(Inline)]
        static bool neqI32<T>(T lhs, T rhs)
            => int32(lhs) != int32(rhs);
        
        [MethodImpl(Inline)]
        static bool neqU32<T>(T lhs, T rhs)
            => uint32(lhs) != uint32(rhs);

        [MethodImpl(Inline)]
        static bool neqI64<T>(T lhs, T rhs)
            => int64(lhs) != int64(rhs);

        [MethodImpl(Inline)]
        static bool neqU64<T>(T lhs, T rhs)
            => uint64(lhs) != uint64(rhs);

        [MethodImpl(Inline)]
        static bool neqF32<T>(T lhs, T rhs)
            => float32(lhs) != float32(rhs);

        [MethodImpl(Inline)]
        static bool neqF64<T>(T lhs, T rhs)
            => float64(lhs) != float64(rhs);



    }

}