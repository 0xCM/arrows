//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static As;
    

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static unsafe void store<T>(Vec128<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void store<T>(Vector128<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void store<T>(Vector256<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static unsafe void store<T>(Vec256<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(int8(src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(uint8(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(int16(src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(uint16(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(int32(src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(uint32(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(int64(src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(uint64(src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(float32(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(float64(src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }
    }
}