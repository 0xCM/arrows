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
        
        /// <summary>
        /// Extracts an index-identified component from a vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The identifying index</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static T component<T>(in Vec128<T> src, byte index)
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

    }
}