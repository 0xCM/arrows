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
        public static bool lt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ltI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ltU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ltI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ltU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ltI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ltU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ltI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ltU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ltF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ltF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.lt(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.lt(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.lt(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.lt(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.lt(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.lt(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.lt(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.lt(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.lt(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.lt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(PrimalKinds.kind<T>());                
        }

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => lt(lhs,rhs,span<bool>(length(lhs,rhs)));
                
        [MethodImpl(Inline)]
        static bool ltI8<T>(T lhs, T rhs)
            => int8(lhs) < int8(rhs);

        [MethodImpl(Inline)]
        static bool ltU8<T>(T lhs, T rhs)
            => uint8(lhs) < uint8(rhs);

        [MethodImpl(Inline)]
        static bool ltI16<T>(T lhs, T rhs)
            => int16(lhs) < int16(rhs);

        [MethodImpl(Inline)]
        static bool ltU16<T>(T lhs, T rhs)
            => uint16(lhs) < uint16(rhs);

        [MethodImpl(Inline)]
        static bool ltI32<T>(T lhs, T rhs)
            => int32(lhs) < int32(rhs);
        
        [MethodImpl(Inline)]
        static bool ltU32<T>(T lhs, T rhs)
            => uint32(lhs) < uint32(rhs);

        [MethodImpl(Inline)]
        static bool ltI64<T>(T lhs, T rhs)
            => int64(lhs) < int64(rhs);

        [MethodImpl(Inline)]
        static bool ltU64<T>(T lhs, T rhs)
            => uint64(lhs) < uint64(rhs);

        [MethodImpl(Inline)]
        static bool ltF32<T>(T lhs, T rhs)
            => float32(lhs) < float32(rhs);

        [MethodImpl(Inline)]
        static bool ltF64<T>(T lhs, T rhs)
            => float64(lhs) < float64(rhs);

    }

}