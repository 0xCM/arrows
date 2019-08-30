//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T pow<T>(T b, T exp)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.pow(int8(b), int8(exp)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.pow(uint8(b), uint8(exp)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.pow(int16(b), int16(exp)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.pow(uint16(b), uint16(exp)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.pow(int32(b), int32(exp)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.pow(uint32(b), uint32(exp)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.pow(int64(b), int64(exp)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.pow(uint64(b), uint64(exp)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.pow(float32(b), float32(exp)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.pow(float64(b), float64(exp)));
            else            
               throw unsupported<T>();
         }           

        [MethodImpl(Inline)]
        public static Span<T> pow<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.pow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.pow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.pow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.pow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.pow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.pow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.pow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                math.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(float64(lhs), float64(rhs));
            else
               throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> pow<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.pow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.pow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.pow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.pow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.pow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.pow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.pow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                math.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }
 
        [MethodImpl(Inline)]
        public static bool isPow2<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.isPow2(int8(src));
            else if(typeof(T) == typeof(byte))
                return math.isPow2(uint8(src));
            else if(typeof(T) == typeof(short))
                return math.isPow2(int16(src));
            else if(typeof(T) == typeof(ushort))
                return math.isPow2(uint16(src));
            else if(typeof(T) == typeof(int))
                return math.isPow2(int32(src));
            else if(typeof(T) == typeof(uint))
                return math.isPow2(uint32(src));
            else if(typeof(T) == typeof(long))
                return math.isPow2(int64(src));
            else if(typeof(T) == typeof(ulong))
                return math.isPow2(uint64(src));
            else            
                throw unsupported<T>();
        }           

    }
}