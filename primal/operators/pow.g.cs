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
        public static ref T pow<T>(ref T b, T exp)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.ipow(ref int8(ref b), int8(exp));
            else if(typeof(T) == typeof(byte))
                math.ipow(ref uint8(ref b), uint8(exp));
            else if(typeof(T) == typeof(short))
                math.ipow(ref int16(ref b), int16(exp));
            else if(typeof(T) == typeof(ushort))
                math.ipow(ref uint16(ref b), uint16(exp));
            else if(typeof(T) == typeof(int))
                math.ipow(ref int32(ref b), int32(exp));
            else if(typeof(T) == typeof(uint))
                math.ipow(ref uint32(ref b), uint32(exp));
            else if(typeof(T) == typeof(long))
                math.ipow(ref int64(ref b), int64(exp));
            else if(typeof(T) == typeof(ulong))
                math.ipow(ref uint64(ref b), uint64(exp));
            else if(typeof(T) == typeof(float))
                fmath.pow(ref float32(ref b), float32(exp));
            else if(typeof(T) == typeof(double))
                fmath.pow(ref float64(ref b), float64(exp));
            else            
               throw unsupported<T>();
            
            return ref b;
         }           

        [MethodImpl(Inline)]
        public static Span<T> pow<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.ipow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.ipow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.ipow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.ipow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.ipow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.ipow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.ipow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.ipow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                fmath.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                fmath.pow(float64(lhs), float64(rhs));
            else
               throw unsupported<T>();
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> pow<T>(Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.ipow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.ipow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.ipow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.ipow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.ipow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.ipow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.ipow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.ipow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                fmath.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                fmath.pow(float64(lhs), float64(rhs));
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