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
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bool testc<T>(Vector128<T> src, Vector128<T> mask)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(int8(src), int8(mask));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.testc(int16(src), int16(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.testc(int32(src), int32(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(uint32(src), uint32(mask));
            else if(typeof(T) == typeof(long))
                return dinx.testc(int64(src), int64(mask));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(uint64(src), uint64(mask));
            else if(typeof(T) == typeof(float))
                return dfp.testc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.testc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bool testc<T>(Vector256<T> src, Vector256<T> mask)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(int8(src), int8(mask));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.testc(int16(src), int16(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.testc(int32(src), int32(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(uint32(src), uint32(mask));
            else if(typeof(T) == typeof(long))
                return dinx.testc(int64(src), int64(mask));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(uint64(src), uint64(mask));
            else if(typeof(T) == typeof(float))
                return dfp.testc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.testc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

    }

}