//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static zfunc;    
    using static As;
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128Cmp<T> cmpeq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.cmpeq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.cmpeq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.cmpeq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.cmpeq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.cmpeq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.cmpeq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.cmpeq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.cmpeq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dinx.cmpeq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dinx.cmpeq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256Cmp<T> cmpeq<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.cmpeq(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return dinx.cmpeq(in uint8(in lhs), in uint8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.cmpeq(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return dinx.cmpeq(in uint16(in lhs), in uint16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.cmpeq(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return dinx.cmpeq(in uint32(in lhs), in uint32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.cmpeq(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return dinx.cmpeq(in uint64(in lhs), in uint64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dinx.cmpeq(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dinx.cmpeq(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        // [MethodImpl(Inline)]
        // public static Span<Bit> eq<T>(in Vec128<T> lhs, in Vec128<T> rhs)
        //     where T : struct
        // {
        //     if(typeof(T) == typeof(sbyte))
        //         return dinx.eq(in int8(in lhs), in int8(in rhs));
        //     else if(typeof(T) == typeof(byte))
        //         return dinx.eq(in uint8(in lhs), in uint8(in rhs));
        //     else if(typeof(T) == typeof(short))
        //         return dinx.eq(in int16(in lhs), in int16(in rhs));
        //     else if(typeof(T) == typeof(ushort))
        //         return dinx.eq(in uint16(in lhs), in uint16(in rhs));
        //     else if(typeof(T) == typeof(int))
        //         return dinx.eq(in int32(in lhs), in int32(in rhs));
        //     else if(typeof(T) == typeof(uint))
        //         return dinx.eq(in uint32(in lhs), in uint32(in rhs));
        //     else if(typeof(T) == typeof(long))
        //         return dinx.eq(in int64(in lhs), in int64(in rhs));
        //     else if(typeof(T) == typeof(ulong))
        //         return dinx.eq(in uint64(in lhs), in uint64(in rhs));
        //     else if(typeof(T) == typeof(float))
        //         return dinx.eq(in float32(in lhs), in float32(in rhs));
        //     else if(typeof(T) == typeof(double))
        //         return dinx.eq(in float64(in lhs), in float64(in rhs));
        //     else 
        //         throw unsupported(PrimalKinds.kind<T>());
        // }

        // [MethodImpl(Inline)]
        // public static Span<Bit> eq<T>(in Vec256<T> lhs, in Vec256<T> rhs)
        //     where T : struct
        // {
        //     if(typeof(T) == typeof(sbyte))
        //         return dinx.eq(in int8(in lhs), in int8(in rhs));
        //     else if(typeof(T) == typeof(byte))
        //         return dinx.eq(in uint8(in lhs), in uint8(in rhs));
        //     else if(typeof(T) == typeof(short))
        //         return dinx.eq(in int16(in lhs), in int16(in rhs));
        //     else if(typeof(T) == typeof(ushort))
        //         return dinx.eq(in uint16(in lhs), in uint16(in rhs));
        //     else if(typeof(T) == typeof(int))
        //         return dinx.eq(in int32(in lhs), in int32(in rhs));
        //     else if(typeof(T) == typeof(uint))
        //         return dinx.eq(in uint32(in lhs), in uint32(in rhs));
        //     else if(typeof(T) == typeof(long))
        //         return dinx.eq(in int64(in lhs), in int64(in rhs));
        //     else if(typeof(T) == typeof(ulong))
        //         return dinx.eq(in uint64(in lhs), in uint64(in rhs));
        //     else 
        //         throw unsupported(PrimalKinds.kind<T>());
        // }


        [MethodImpl(Inline)]
        public static bool eq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.eq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.eq(in float64(in lhs), in float64(in rhs));
            throw unsupported(PrimalKinds.kind<T>());
        }


        // public static Span<Bit> eq<T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs)
        //     where T : struct
        // {            
        //     if(typeof(T) == typeof(sbyte))
        //         return dinx.eq(int8(lhs), int8(rhs));
        //     else if(typeof(T) == typeof(byte))
        //         dinx.add(uint8(lhs), uint8(rhs), uint8(dst));
        //     else if(typeof(T) == typeof(short))
        //         dinx.add(int16(lhs), int16(rhs), int16(dst));
        //     else if(typeof(T) == typeof(ushort))
        //         dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
        //     else if(typeof(T) == typeof(int))
        //         dinx.add(int32(lhs), int32(rhs), int32(dst));
        //     else if(typeof(T) == typeof(uint))
        //         dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
        //     else if(typeof(T) == typeof(long))
        //         dinx.add(int64(lhs), int64(rhs), int64(dst));
        //     else if(typeof(T) == typeof(ulong))
        //         dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
        //     else if(typeof(T) == typeof(float))
        //         dinx.add(float32(lhs), float32(rhs), float32(dst));
        //     else if(typeof(T) == typeof(double))
        //         dinx.add(float64(lhs), float64(rhs), float64(dst));
        //     else 
        //         throw unsupported(PrimalKinds.kind<T>());
        //     return dst;
        // }


    }
}