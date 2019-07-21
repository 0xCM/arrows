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

    partial class ginxs
    {        
        public static Span128<T> XOr<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinxx.XOr(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinxx.XOr(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinxx.XOr(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinxx.XOr(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinxx.XOr(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinxx.XOr(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinxx.XOr(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinxx.XOr(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinxx.XOr(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinxx.XOr(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }

        public static Span256<T> XOr<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinxx.XOr(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinxx.XOr(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinxx.XOr(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinxx.XOr(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinxx.XOr(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinxx.XOr(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinxx.XOr(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinxx.XOr(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinxx.XOr(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinxx.XOr(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }


    }

}