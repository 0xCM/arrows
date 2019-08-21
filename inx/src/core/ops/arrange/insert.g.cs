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

        /// <summary>
        /// Overwrites an identified component in the target vector with a specified value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">The 0-based index of the component to overwrite</param>
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

        /// <summary>
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
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