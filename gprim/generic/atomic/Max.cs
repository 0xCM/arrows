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
        public static T max<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return maxI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return maxU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return maxI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return maxU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return maxI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return maxU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return maxI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return maxU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return maxF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return maxF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return generic<T>(math.max(int8(src)));
                case PrimalKind.uint8:
                    return generic<T>(math.max(uint8(src)));
                case PrimalKind.int16:
                    return generic<T>(math.max(int16(src)));
                case PrimalKind.uint16:
                    return generic<T>(math.max(uint16(src)));
                case PrimalKind.int32:
                    return generic<T>(math.max(int32(src)));
                case PrimalKind.uint32:
                    return generic<T>(math.max(uint32(src)));
                case PrimalKind.int64:
                    return generic<T>(math.max(int64(src)));
                case PrimalKind.uint64:
                    return generic<T>(math.max(uint64(src)));
                case PrimalKind.float32:
                    return generic<T>(math.max(float32(src)));
                case PrimalKind.float64:
                    return generic<T>(math.max(float64(src)));
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(Inline)]
        static T maxI8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        static T maxU8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        static T maxI16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T maxU16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T maxI32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T maxU32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T maxI64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        static T maxU64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        static T maxF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Max(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        static T maxF64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(float64(lhs), float64(rhs))));



    }

}