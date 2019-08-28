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
        public static T ifma<T>(T x, T y, T z)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.fma(int8(x), int8(y), int8(z)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.fma(uint8(x), uint8(y), uint8(z)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.fma(int16(x), int16(y), int16(z)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.fma(uint16(x), uint16(y), uint16(z)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.fma(int32(x), int32(y), int32(z)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.fma(uint32(x), uint32(y), uint32(z)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.fma(int64(x), int64(y), int64(z)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.fma(uint64(x), uint64(y), uint64(z)));
            else            
                throw unsupported<T>();
        }

    }

}