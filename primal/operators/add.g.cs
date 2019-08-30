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
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(lhs) + int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(lhs) + uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(lhs) + int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(lhs) + uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(lhs) + int32(rhs));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(lhs) + uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(lhs) + int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(lhs) + uint64(rhs));
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(lhs) + float32(rhs));
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(lhs) + float64(rhs));
            else            
                throw unsupported<T>();
        }
                    
        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : struct
        {                        
            if(typeof(T) == typeof(sbyte))
                 math.add(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                 math.add(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                 math.add(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                 math.add(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                 math.add(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                 math.add(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                 math.add(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                 math.add(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                 math.add(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 math.add(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => add(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static ref Span<T> add<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct        
                => add(ref lhs, rhs);
        
        [MethodImpl(Inline)]
        public static ref Span<T> add<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.add(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.add(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.add(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.add(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.add(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.add(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.add(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.add(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.add(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.add(float64(lhs), float64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }
    }
}