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
                return generic<T>((Math.Max(int8(lhs), int8(rhs))));
            else if(typeof(T) == typeof(byte))
                return generic<T>((Math.Max(uint8(lhs), uint8(rhs))));
            else if(typeof(T) == typeof(short))
                return generic<T>((Math.Max(int16(lhs), int16(rhs))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((Math.Max(uint16(lhs), uint16(rhs))));
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
                throw unsupported<T>();
        }           

        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.max(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.max(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.max(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.max(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.max(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.max(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.max(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.max(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.max(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.max(float64(src)));
            else
                throw unsupported<T>();
        }


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