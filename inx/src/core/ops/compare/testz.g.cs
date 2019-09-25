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
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz<T>(Vector128<T> src,Vector128<T> mask)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testz(int8(src), int8(mask));
            else if(typeof(T) == typeof(byte))
                return dinx.testz(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.testz(int16(src), int16(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.testz(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.testz(int32(src), int32(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.testz(uint32(src), uint32(mask));
            else if(typeof(T) == typeof(long))
                return dinx.testz(int64(src), int64(mask));
            else if(typeof(T) == typeof(ulong))
                return dinx.testz(uint64(src), uint64(mask));
            else if(typeof(T) == typeof(float))
                return dfp.testz(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.testz(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Determines whether all mask-specified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bool testz<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testz(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                return dinx.testz(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                return dinx.testz(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                return dinx.testz(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                return dinx.testz(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                return dinx.testz(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                return dinx.testz(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return dinx.testz(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                return dfp.testz(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                return dfp.testz(float64(lhs), float64(rhs));
            else 
                throw unsupported<T>();
        }

    }

}