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
        public static T add<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return addI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return addU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return addI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return addU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return addI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return addU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return addI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return addU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return addF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return addF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }
                    
        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, T rhs)
            where T : struct
        {                        
            if(typeof(T) == typeof(sbyte))
                return ref addI8(ref lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return ref addU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref addI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref addU16(ref lhs,rhs);
            else if(typeof(T) == typeof(int))
                return ref addI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref addU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref addI64(ref lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return ref addU64(ref lhs,rhs);
            else if(typeof(T) == typeof(float))
                return ref addF32(ref lhs, rhs);
            else if(typeof(T) == typeof(double))
                return ref addF64(ref lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }

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
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }


        [MethodImpl(Inline)]
        static T addI8<T>(T lhs, T rhs) 
            => generic<T>((sbyte)(int8(lhs) + int8(rhs)));            

        [MethodImpl(Inline)]
        static T addU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) + uint8(rhs)));
                   
        [MethodImpl(Inline)]
        static T addI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) + int16(rhs)));

        [MethodImpl(Inline)]
        static T addU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) + uint16(rhs)));

        [MethodImpl(Inline)]
        static T addI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) + int32(rhs));
        
        [MethodImpl(Inline)]
        static T addU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) + uint32(rhs));

        [MethodImpl(Inline)]
        static T addI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) + int64(rhs));

        [MethodImpl(Inline)]
        static T addU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) + uint64(rhs));

        [MethodImpl(Inline)]
        static T addF32<T>(T lhs, T rhs)
        {
            var result = math.add(float32(ref asRef(in lhs)), float32(ref asRef(in rhs)));
            return generic<T>(ref result);
        }
            
        [MethodImpl(Inline)]
        static T addF64<T>(T lhs, T rhs)
        {
            var result = math.add(float64(ref asRef(in lhs)), float64(ref asRef(in rhs)));
            return generic<T>(ref result);
        }

        [MethodImpl(Inline)]
        static ref T addI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addF32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref float32(ref lhs), float32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T addF64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref float64(ref lhs), float64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            
    }
}