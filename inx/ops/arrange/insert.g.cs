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
        public static Vec128<T> insert<T>(in T src, in Vec128<T> dst, byte index)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.insert(int8(src), in int8(in dst), index));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.insert(uint8(src), in uint8(in dst), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.insert(int16(src), in int16(in dst), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.insert(uint16(src), in uint16(in dst), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.insert(int32(src), in int32(in dst), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.insert(uint32(src), in uint32(in dst), index));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.insert(int64(src), in int64(in dst), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.insert(uint64(src), in uint64(in dst), index));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> insert<T>(Vec128<T> src, in Vec256<T> dst, byte index)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.insert(in int8(in src), in int8(in dst), index));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.insert(in uint8(in src), in uint8(in dst), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.insert(in int16(in src), in int16(in dst), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.insert(in uint16(in src), in uint16(in dst), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.insert(in int32(in src), in int32(in dst), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.insert(in uint32(in src), in uint32(in dst), index));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.insert(in int64(in src), in int64(in dst), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.insert(in uint64(in src), in uint64(in dst), index));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.insert(in float32(in src), in float32(in dst), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.insert(in float64(in src), in float64(in dst), index));
            else
                throw unsupported<T>();
        }
    }

}