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
        public static void flip<T>(in Vec128<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dinx.flip(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                dinx.flip(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.flip(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                dinx.flip(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.flip(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.flip(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.flip(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.flip(in uint64(in src), ref uint64(ref dst));
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
 
         [MethodImpl(Inline)]
        public static void flip<T>(in Vec256<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dinx.flip(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                dinx.flip(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.flip(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                dinx.flip(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.flip(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.flip(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.flip(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.flip(in uint64(in src), ref uint64(ref dst));
            else 
                throw unsupported<T>();
        }

    }
}