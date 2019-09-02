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
        public static bool testc<T>(in Vec128<T> src,in Vec128<T> mask)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(in int8(in src), in int8(in mask));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(in uint8(in src), in uint8(in mask));
            else if(typeof(T) == typeof(short))
                return dinx.testc(in int16(in src), in int16(in mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(in uint16(in src), in uint16(in mask));
            else if(typeof(T) == typeof(int))
                return dinx.testc(in int32(in src), in int32(in mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(in uint32(in src), in uint32(in mask));
            else if(typeof(T) == typeof(long))
                return dinx.testc(in int64(in src), in int64(in mask));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(in uint64(in src), in uint64(in mask));
            else if(typeof(T) == typeof(float))
                return dfp.testc(in float32(in src), in float32(in mask));
            else if(typeof(T) == typeof(double))
                return dfp.testc(in float64(in src), in float64(in mask));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether mask-specified source bits are all on
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="mask">Specifies the bits in the source to test</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bool testc<T>(in Vec256<T> src,in Vec256<T> mask)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(in int8(in src), in int8(in mask));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(in uint8(in src), in uint8(in mask));
            else if(typeof(T) == typeof(short))
                return dinx.testc(in int16(in src), in int16(in mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(in uint16(in src), in uint16(in mask));
            else if(typeof(T) == typeof(int))
                return dinx.testc(in int32(in src), in int32(in mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(in uint32(in src), in uint32(in mask));
            else if(typeof(T) == typeof(long))
                return dinx.testc(in int64(in src), in int64(in mask));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(in uint64(in src), in uint64(in mask));
            else if(typeof(T) == typeof(float))
                return dfp.testc(in float32(in src), in float32(in mask));
            else if(typeof(T) == typeof(double))
                return dfp.testc(in float64(in src), in float64(in mask));
            else 
                throw unsupported<T>();
        }

    }

}