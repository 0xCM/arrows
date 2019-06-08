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
                return math.neq(int8(lhs),int8(rhs));
            else if(typeof(T) == typeof(byte))
                return math.neq(uint8(lhs),uint8(rhs));
            else if(typeof(T) == typeof(short))
                return math.neq(int16(lhs),int16(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.neq(uint16(lhs),uint16(rhs));
            else if(typeof(T) == typeof(int))
                return math.neq(int32(lhs),int32(rhs));
            else if(typeof(T) == typeof(uint))
                return math.neq(uint32(lhs),uint32(rhs));
            else if(typeof(T) == typeof(long))
                return math.neq(int64(lhs),int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return math.neq(uint64(lhs),uint64(rhs));
            else if(typeof(T) == typeof(float))
                return math.neq(float32(lhs),float32(rhs));
            else if(typeof(T) == typeof(double))
                return math.neq(float64(lhs),float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => neq(lhs,rhs,span<bool>(length(lhs,rhs)));

        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.neq(int8(lhs), int8(rhs), dst);
            else if(typeof(T) == typeof(byte))
                return math.neq(uint8(lhs), uint8(rhs), dst);
            else if(typeof(T) == typeof(short))
                return math.neq(int16(lhs), int16(rhs), dst);
            else if(typeof(T) == typeof(ushort))
                return math.neq(uint16(lhs), uint16(rhs), dst);
            else if(typeof(T) == typeof(int))
                return math.neq(int32(lhs), int32(rhs), dst);
            else if(typeof(T) == typeof(uint))
                return math.neq(uint32(lhs), uint32(rhs), dst);
            else if(typeof(T) == typeof(long))
                return math.neq(int64(lhs), int64(rhs), dst);
            else if(typeof(T) == typeof(ulong))
                return math.neq(uint64(lhs), uint64(rhs), dst);
            else if(typeof(T) == typeof(float))
                return math.neq(float32(lhs), float32(rhs), dst);
            else if(typeof(T) == typeof(double))
                return math.neq(float64(lhs), float64(rhs), dst);
            else
                throw unsupported(PrimalKinds.kind<T>());                
        }

    }

}