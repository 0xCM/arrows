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
        public static Vec128<T> flip<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> flip<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.flip(in int8(in src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.flip(in uint8(in src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.flip(in int16(in src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.flip(in uint16(in src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.flip(in int32(in src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.flip(in uint32(in src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.flip(in int64(in src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.flip(in uint64(in src)));
            else 
                throw unsupported<T>();
        }
    }
}