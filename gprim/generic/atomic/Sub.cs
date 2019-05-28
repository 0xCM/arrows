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
        public static T sub<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return subI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return subU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return subI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return subU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return subI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return subU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return subI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return subU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return subF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return subF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static ref T sub<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref subI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref subU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref subI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref subU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref subI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref subU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref subI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref subU64(ref lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ref subF32(ref lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ref subF64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.sub(int8(lhs), int8(rhs), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.sub(uint8(lhs), uint8(rhs), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.sub(int16(lhs), int16(rhs), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.sub(uint16(lhs), uint16(rhs), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.sub(int32(lhs), int32(rhs), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.sub(uint32(lhs), uint32(rhs), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.sub(int64(lhs), int64(rhs), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.sub(uint64(lhs), uint64(rhs), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.sub(float32(lhs), float32(rhs), float32(dst));
            else if(kind == PrimalKind.float64)
                math.sub(float64(lhs), float64(rhs), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }


        [MethodImpl(Inline)]
        static T subI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) - int8(rhs)));

        [MethodImpl(Inline)]
        static T subU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) - uint8(rhs)));

        [MethodImpl(Inline)]
        static T subI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) - int16(rhs)));

        [MethodImpl(Inline)]
        static T subU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) - uint16(rhs)));

        [MethodImpl(Inline)]
        static T subI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) - int32(rhs));
        
        [MethodImpl(Inline)]
        static T subU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) - uint32(rhs));

        [MethodImpl(Inline)]
        static T subI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) - int64(rhs));

        [MethodImpl(Inline)]
        static T subU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) - uint64(rhs));

        [MethodImpl(Inline)]
        static T subF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) - float32(rhs));

        [MethodImpl(Inline)]
        static T subF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) - float64(rhs));

        [MethodImpl(Inline)]
        static ref T subI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        static ref T subI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subF32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref float32(ref lhs), float32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T subF64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.sub(ref float64(ref lhs), float64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }
    }
}
