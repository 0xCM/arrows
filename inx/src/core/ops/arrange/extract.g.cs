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
    using static As;

    partial class ginx
    {        
        /// <summary>
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The identifying index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T extract<T>(in Vec128<T> src, byte index)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.extract(in uint8(in src), index));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(int8(src[index]));
            else if(typeof(T) == typeof(short))
                return generic<T>(int16(src[index]));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.extract(in uint16(in src), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.extract(in int32(in src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.extract(in uint32(in src), index));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.extract(in int64(in src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.extract(in uint64(in src), index));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.extract(in float32(in src), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(src[index]));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<T> extract128<T>(in Vec256<T> src, byte index)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.extract128(in uint8(in src), index));
            else if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.extract128(in int8(in src), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.extract128(in int16(in src), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.extract128(in uint16(in src), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.extract128(in int32(in src), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.extract128(in uint32(in src), index));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.extract128(in int64(in src), index));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.extract128(in uint64(in src), index));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.extract128(in float32(in src), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.extract128(in float64(in src), index));
            else 
                throw unsupported<T>();
        }

    }
}