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
    using static AsIn;

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) & int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) & uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) & int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) & uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) & int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) & uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) & int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) & uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.and(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.and(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.and(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.and(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.and(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.and(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.and(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.and(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.and(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.and(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.and(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.and(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => and(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return  lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.and(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.and(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return  dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return  lhs;
        }

        [MethodImpl(Inline)]
        public static Memory<T> and<T>(Memory<T> lhs, ReadOnlyMemory<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.and(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.and(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.and(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.and(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.and(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.and(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.and(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.and(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.and(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.and(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return lhs;
        }
 
    }
}