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
        public static bool eq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return eqI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return eqU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return eqI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return eqU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return eqI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return eqU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return eqI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return eqU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return eqF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return eqF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.eq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.eq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.eq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.eq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.eq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.eq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.eq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.eq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.eq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.eq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(PrimalKinds.kind<T>());                
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return gmath.eq(lhs,rhs,dst);
        }

        [MethodImpl(Inline)]
        static bool eqI8<T>(T lhs, T rhs)
            => int8(lhs) == int8(rhs);

        [MethodImpl(Inline)]
        static bool eqU8<T>(T lhs, T rhs)
            => uint8(lhs) == uint8(rhs);

        [MethodImpl(Inline)]
        static bool eqI16<T>(T lhs, T rhs)
            => int16(lhs) == int16(rhs);

        [MethodImpl(Inline)]
        static bool eqU16<T>(T lhs, T rhs)
            => uint16(lhs) == uint16(rhs);

        [MethodImpl(Inline)]
        static bool eqI32<T>(T lhs, T rhs)
            => int32(lhs) == int32(rhs);
        
        [MethodImpl(Inline)]
        static bool eqU32<T>(T lhs, T rhs)
            => uint32(lhs) == uint32(rhs);

        [MethodImpl(Inline)]
        static bool eqI64<T>(T lhs, T rhs)
            => int64(lhs) == int64(rhs);

        [MethodImpl(Inline)]
        static bool eqU64<T>(T lhs, T rhs)
            => uint64(lhs) == uint64(rhs);

        [MethodImpl(Inline)]
        static bool eqF32<T>(T lhs, T rhs)
        {
            var x = float32(lhs);
            var y = float32(rhs);
            if(x.IsNaN() && y.IsNaN())
                return true;
            else if(x.IsPosInf() && y.IsPosInf())
                return true;
            else if(x.IsNegInf() && y.IsNegInf())
                return true;
            else return x == y;
        }
            
        [MethodImpl(Inline)]
        static bool eqF64<T>(T lhs, T rhs)
        {
            var x = float64(lhs);
            var y = float64(rhs);
            if(x.IsNaN() && y.IsNaN())
                return true;
            else if(x.IsPosInf() && y.IsPosInf())
                return true;
            else if(x.IsNegInf() && y.IsNegInf())
                return true;
            else return x == y;
        }
    }
}