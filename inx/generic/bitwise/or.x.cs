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
        public static Span128<T> Or<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }


        public static Span256<T> Or<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }

    }



}