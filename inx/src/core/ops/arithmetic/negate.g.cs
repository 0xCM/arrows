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
        [MethodImpl(Inline)]
        public static Vec128<T> negate<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.negate(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.negate(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.negate(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.negate(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.negate(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.negate(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.negate(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.negate(in uint64(in src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.negate(in float32(in src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.negate(in float64(in src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> negate<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.negate(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.negate(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.negate(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.negate(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.negate(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.negate(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.negate(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.negate(in uint64(in src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.negate(in float32(in src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.negate(in float64(in src)));
            else 
                throw unsupported<T>();
        }
    }
}