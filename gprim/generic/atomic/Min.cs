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
        public static T min<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return minI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return minU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return minI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return minU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return minI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return minU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return minI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return minU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return minF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return minF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           
 
        [MethodImpl(Inline)]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(math.min(int8(src)));
                case PrimalKind.uint8:
                    return generic<T>(math.min(uint8(src)));
                case PrimalKind.int16:
                    return generic<T>(math.min(int16(src)));
                case PrimalKind.uint16:
                    return generic<T>(math.min(uint16(src)));
                case PrimalKind.int32:
                    return generic<T>(math.min(int32(src)));
                case PrimalKind.uint32:
                    return generic<T>(math.min(uint32(src)));
                case PrimalKind.int64:
                    return generic<T>(math.min(int64(src)));
                case PrimalKind.uint64:
                    return generic<T>(math.min(uint64(src)));
                case PrimalKind.float32:
                    return generic<T>(math.min(float32(src)));
                case PrimalKind.float64:
                    return generic<T>(math.min(float64(src)));
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(Inline)]
        static T minI8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        static T minU8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        static T minI16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T minU16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T minI32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T minU32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T minI64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        static T minU64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        static T minF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Min(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        static T minF64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(float64(lhs), float64(rhs))));
    }
}