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
        public static T xor<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return xorI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return xorU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return xorI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return xorU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return xorI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return xorU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return xorI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return xorU64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());                   
        }           

        [MethodImpl(Inline)]
        public static ref T xor<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref xorI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref xorU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref xorI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref xorU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref xorI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref xorU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref xorI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref xorU64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs), uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => xor(lhs,rhs, span<T>(length(lhs,rhs)));
        

        [MethodImpl(Inline)]
        public static ref Span<T> xor<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.xor(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.xor(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.xor(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.xor(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.xor(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.xor(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.xor(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.xor(uint64(lhs), uint64(rhs));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T xorI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) ^ int8(rhs)));

        [MethodImpl(Inline)]
        static T xorU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) ^ uint8(rhs)));

        [MethodImpl(Inline)]
        static T xorI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) ^ int16(rhs)));

        [MethodImpl(Inline)]
        static T xorU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) ^ uint16(rhs)));

        [MethodImpl(Inline)]
        static T xorI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) ^ int32(rhs));
        
        [MethodImpl(Inline)]
        static T xorU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) ^ uint32(rhs));

        [MethodImpl(Inline)]
        static T xorI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) ^ int64(rhs));

        [MethodImpl(Inline)]
        static T xorU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) ^ uint64(rhs));

        [MethodImpl(Inline)]
        static ref T xorI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T xorU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.xor(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }
    }
}