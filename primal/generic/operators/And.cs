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
        public static T and<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return andI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return andU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return andI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return andU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return andI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return andU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return andI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return andU64(lhs,rhs);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static ref T and<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref andI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref andU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref andI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref andU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref andI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref andU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref andI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref andU64(ref lhs,rhs);
            else            
                throw unsupported<T>();
        }


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
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => and(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static ref Span<T> and<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
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
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> and<T>(ref Span<T> lhs, T rhs)
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
            return ref lhs;
        }


        [MethodImpl(Inline)]
        static T andI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) & int8(rhs)));

        [MethodImpl(Inline)]
        static T andU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) & uint8(rhs)));

        [MethodImpl(Inline)]
        static T andI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) & int16(rhs)));

        [MethodImpl(Inline)]
        static T andU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) & uint16(rhs)));

        [MethodImpl(Inline)]
        static T andI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) & int32(rhs));
        
        [MethodImpl(Inline)]
        static T andU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) & uint32(rhs));

        [MethodImpl(Inline)]
        static T andI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) & int64(rhs));

        [MethodImpl(Inline)]
        static T andU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) & uint64(rhs));

        [MethodImpl(Inline)]
        static ref T andI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T andU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }
    }
}