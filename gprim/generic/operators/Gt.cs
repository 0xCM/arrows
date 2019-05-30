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
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return gtI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return gtU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return gtI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return gtU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return gtI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return gtU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return gtI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return gtU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return gtF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return gtF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.gt(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.gt(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.gt(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.gt(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.gt(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.gt(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.gt(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.gt(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.gt(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(PrimalKinds.kind<T>());                
        }

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => gt(lhs,rhs,span<bool>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        static bool gtI8<T>(T lhs, T rhs)
            => int8(lhs) > int8(rhs);

        [MethodImpl(Inline)]
        static bool gtU8<T>(T lhs, T rhs)
            => uint8(lhs) > uint8(rhs);

        [MethodImpl(Inline)]
        static bool gtI16<T>(T lhs, T rhs)
            => int16(lhs) > int16(rhs);

        [MethodImpl(Inline)]
        static bool gtU16<T>(T lhs, T rhs)
            => uint16(lhs) > uint16(rhs);

        [MethodImpl(Inline)]
        static bool gtI32<T>(T lhs, T rhs)
            => int32(lhs) > int32(rhs);
        
        [MethodImpl(Inline)]
        static bool gtU32<T>(T lhs, T rhs)
            => uint32(lhs) > uint32(rhs);

        [MethodImpl(Inline)]
        static bool gtI64<T>(T lhs, T rhs)
            => int64(lhs) > int64(rhs);

        [MethodImpl(Inline)]
        static bool gtU64<T>(T lhs, T rhs)
            => uint64(lhs) > uint64(rhs);

        [MethodImpl(Inline)]
        static bool gtF32<T>(T lhs, T rhs)
            => float32(lhs) > float32(rhs);

        [MethodImpl(Inline)]
        static bool gtF64<T>(T lhs, T rhs)
            => float64(lhs) > float64(rhs);

    }

}