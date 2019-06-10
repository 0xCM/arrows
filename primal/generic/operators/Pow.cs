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
        public static T pow<T>(T b, T exp)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return powI8(b, exp);
            else if(typeof(T) == typeof(byte))
                return powU8(b, exp);
            else if(typeof(T) == typeof(short))
                return powI16(b, exp);
            else if(typeof(T) == typeof(ushort))
                return powU16(b, exp);
            else if(typeof(T) == typeof(int))
                return powI32(b, exp);
            else if(typeof(T) == typeof(uint))
                return powU32(b, exp);
            else if(typeof(T) == typeof(long))
                return powI64(b, exp);
            else if(typeof(T) == typeof(ulong))
                return powU64(b, exp);
            else if(typeof(T) == typeof(float))
                return powF32(b, exp);
            else if(typeof(T) == typeof(double))
                return powF64(b, exp);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref Span<T> pow<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.pow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.pow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.pow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.pow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.pow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.pow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.pow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                math.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(float64(lhs), float64(rhs));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> pow<T>(ref Span<T> lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.pow(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.pow(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.pow(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.pow(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.pow(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.pow(uint32(lhs), uint32(rhs));
            if(typeof(T) == typeof(long))
                math.pow(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(uint64(lhs), uint64(rhs));
            if(typeof(T) == typeof(float))
                math.pow(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(ulong))
                math.pow(float64(lhs), float64(rhs));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }


        [MethodImpl(Inline)]
        static T powU8<T>(T src, T exp)
            => generic<T>(math.pow(int8(src), int8(exp)));

        [MethodImpl(Inline)]
        static T powI8<T>(T src, T exp)
            => generic<T>(math.pow(uint8(src), uint8(exp)));

        [MethodImpl(Inline)]
        static T powI16<T>(T src, T exp)
            => generic<T>(math.pow(int16(src), int16(exp)));

        [MethodImpl(Inline)]
        static T powU16<T>(T src, T exp)
            => generic<T>(math.pow(uint16(src), uint16(exp)));

        [MethodImpl(Inline)]
        static T powI32<T>(T src, T exp)
            => generic<T>(math.pow(int32(src), int32(exp)));
        
        [MethodImpl(Inline)]
        static T powU32<T>(T src, T exp)
            => generic<T>(math.pow(uint32(src), uint32(exp)));

        [MethodImpl(Inline)]
        static T powI64<T>(T src, T exp)
            => generic<T>(math.pow(int64(src), int64(exp)));

        [MethodImpl(Inline)]
        static T powU64<T>(T src, T exp)
            => generic<T>(math.pow(uint64(src), uint64(exp)));

        [MethodImpl(Inline)]
        static T powF32<T>(T src, T exp)
            => generic<T>(math.pow(float32(src), float32(exp)));

        [MethodImpl(Inline)]
        static T powF64<T>(T src, T exp)
            => generic<T>(math.pow(float64(src), float64(exp)));
    }
}