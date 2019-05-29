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
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return mulI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return mulU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return mulI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return mulU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return mulI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return mulU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return mulI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return mulU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return mulF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return mulF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref mulI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref mulU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref mulI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref mulU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref mulI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref mulU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref mulI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref mulU64(ref lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ref mulF32(ref lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ref mulF64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mul(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.mul(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.mul(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.mul(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.mul(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.mul(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.mul(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.mul(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.mul(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.mul(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        static T mulI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) * int8(rhs)));

        [MethodImpl(Inline)]
        static T mulU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) * uint8(rhs)));

        [MethodImpl(Inline)]
        static T mulI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) * int16(rhs)));

        [MethodImpl(Inline)]
        static T mulU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) * uint16(rhs)));

        [MethodImpl(Inline)]
        static T mulI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) * int32(rhs));
        
        [MethodImpl(Inline)]
        static T mulU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) * uint32(rhs));

        [MethodImpl(Inline)]
        static T mulI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) * int64(rhs));

        [MethodImpl(Inline)]
        static T mulU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) * uint64(rhs));

        [MethodImpl(Inline)]
        static T mulF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) * float32(rhs));

        [MethodImpl(Inline)]
        static T mulF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) * float64(rhs));

        [MethodImpl(Inline)]
        static ref T mulI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulF32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref float32(ref lhs), float32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T mulF64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.mul(ref float64(ref lhs), float64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }
    }
}
