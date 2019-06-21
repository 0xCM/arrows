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

        [MethodImpl(Inline)]
        public static T log2<T>(T src)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.log2(int8(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.log2(int8(src)));
            else
                throw unsupported<T>();
        }

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

        [MethodImpl(Inline)]
        public static T log<T>(T src, T? @base = null)
            where T : struct
        {        
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.log(int8(src), int8(@base)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.log(uint8(src), uint8(@base)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.log(int16(src), int16(@base)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.log(uint16(src), uint16(@base)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.log(int32(src), int32(@base)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.log(uint32(src), uint32(@base)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.log(int64(src), int64(@base)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.log(uint64(src), uint64(@base)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.log(float32(src), float32(@base)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.log(float64(src), float64(@base)));
            else
                throw unsupported<T>();
        }
    }

}