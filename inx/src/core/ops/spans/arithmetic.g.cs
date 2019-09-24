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

    partial class ginx
    {

        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.add(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinx.add(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinx.add(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinx.add(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinx.add(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dfp.add(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dfp.add(float64(lhs), float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.add(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinx.add(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinx.add(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinx.add(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinx.add(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinx.add(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinx.add(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinx.add(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dfp.add(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dfp.add(float64(lhs), float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        } 


    }

}