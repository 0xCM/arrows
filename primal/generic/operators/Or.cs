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
        public static T or<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return orI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return orU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return orI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return orU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return orI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return orU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return orI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return orU64(lhs,rhs);
            else            
                throw unsupported<T>();
        }           


        [MethodImpl(Inline)]
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref orI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref orU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref orI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref orU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref orI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref orU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref orI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref orU64(ref lhs,rhs);
            else            
                throw unsupported<T>();
        }

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => or(lhs,rhs, span<T>(length(lhs,rhs)));


        [MethodImpl(Inline)]
        public static ref Span<T> or<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> or<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(uint64(lhs), uint64(rhs));
            else
                throw unsupported<T>();
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T orI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) | int8(rhs)));

        [MethodImpl(Inline)]
        static T orU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) | uint8(rhs)));

        [MethodImpl(Inline)]
        static T orI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) | int16(rhs)));

        [MethodImpl(Inline)]
        static T orU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) | uint16(rhs)));

        [MethodImpl(Inline)]
        static T orI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) | int32(rhs));
        
        [MethodImpl(Inline)]
        static T orU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) | uint32(rhs));

        [MethodImpl(Inline)]
        static T orI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) | int64(rhs));

        [MethodImpl(Inline)]
        static T orU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) | uint64(rhs));
                    [MethodImpl(Inline)]
        static ref T orI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        static ref T orI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T orU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            
    }
}