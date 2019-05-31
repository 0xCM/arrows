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
        public static T div<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return divI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return divU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return divI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return divU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return divI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return divU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return divI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return divU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return divF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return divF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ref T div<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref divI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref divU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref divI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref divU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref divI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref divU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref divI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref divU64(ref lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ref divF32(ref lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ref divF64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.div(int8(lhs), int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.div(uint8(lhs), uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.div(int16(lhs), int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.div(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.div(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.div(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.div(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.div(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.div(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                math.div(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
                => div(lhs,rhs, span<T>(length(lhs,rhs)));

        [MethodImpl(Inline)]
        public static ref Span<T> div<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.div(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.div(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.div(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.div(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.div(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.div(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.div(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.div(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.div(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(float))
                math.div(float64(lhs), float64(rhs));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static T divI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) / int8(rhs)));

        [MethodImpl(Inline)]
        static T divU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) / uint8(rhs)));

        [MethodImpl(Inline)]
        static T divI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) / int16(rhs)));

        [MethodImpl(Inline)]
        static T divU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) / uint16(rhs)));

        [MethodImpl(Inline)]
        static T divI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) / int32(rhs));
        
        [MethodImpl(Inline)]
        static T divU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) / uint32(rhs));

        [MethodImpl(Inline)]
        static T divI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) / int64(rhs));

        [MethodImpl(Inline)]
        static T divU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) / uint64(rhs));

        [MethodImpl(Inline)]
        static T divF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) / float32(rhs));

        [MethodImpl(Inline)]
        static T divF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) / float64(rhs));


        [MethodImpl(Inline)]
        static ref T divI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divI16<T>(ref T lhs, T rhs)
        {
            var result = (short) (int16(ref lhs) / int16(ref rhs));
            lhs = generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divI64<T>(ref T lhs, T rhs)
        {
            lhs = generic<T>(int64(ref lhs) / int64(ref rhs));
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divF32<T>(ref T lhs, T rhs)
        {
            lhs = generic<T>(float32(ref lhs) / float32(ref rhs));
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T divF64<T>(ref T lhs, T rhs)
        {
            lhs = generic<T>(float64(ref lhs) / float64(ref rhs));
            return ref lhs;
        }
    }
}
