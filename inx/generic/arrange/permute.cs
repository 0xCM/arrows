//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static AsIn;
    using static AsInX;

    partial class ginx
    {

       [MethodImpl(Inline)]
        public static Vec256<T> permute2x128<T>(in Vec256<T> lhs, Vec256<T> rhs, byte control)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.permute2x128(in int8(in lhs), in int8(in rhs), control));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.permute2x128(in uint8(in lhs), in uint8(in rhs), control));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.permute2x128(in int16(in lhs), in int16(in rhs), control));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.permute2x128(in uint16(in lhs), in uint16(in rhs), control));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.permute2x128(in int32(in lhs), in int32(in rhs), control));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.permute2x128(in uint32(in lhs), in uint32(in rhs), control));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.permute2x128(in int64(in lhs), in int64(in rhs), control));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.permute2x128(in uint64(in lhs), in uint64(in rhs), control));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.permute2x128(in float32(in lhs), in float32(in rhs), control));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.permute2x128(in float64(in lhs), in float64(in rhs), control));
            else 
                throw unsupported<T>();
        }
    }
}