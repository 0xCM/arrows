//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {        

        /// <summary>
        /// Computes the base-2 log of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T log2<T>(T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.log2(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.log2(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.log2(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.log2(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.log2(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.log2(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.log2(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.log2(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.log2(float64(src)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the base-e log of the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T ln<T>(T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.ln(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.ln(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.ln(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.ln(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.ln(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.ln(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.ln(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.ln(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.ln(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.ln(float64(src)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes the base-b log of the source value if the base b is specified;
        /// otherwise, computes the base-10 log.
        /// </summary>
        /// <param name="b">The base value</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T log<T>(T src, T? b = null)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.log(int8(src), int8(b)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.log(uint8(src), uint8(b)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.log(int16(src), int16(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.log(uint16(src), uint16(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.log(int32(src), int32(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.log(uint32(src), uint32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.log(int64(src), int64(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.log(uint64(src), uint64(b)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.log(float32(src), float32(b)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.log(float64(src), float64(b)));
            else
                throw unsupported<T>();
        }
    }

}