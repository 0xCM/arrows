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
        public static bool between<T>(T x, T a, T b, BetweenMode mode = BetweenMode.Inclusive)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.between(int8(x), int8(a), int8(b), mode);
            else if(typeof(T) == typeof(byte))
                return math.between(uint8(x), uint8(a), uint8(b), mode);
            else if(typeof(T) == typeof(short))
                return math.between(int16(x), int16(a), int16(b), mode);
            else if(typeof(T) == typeof(ushort))
                return math.between(uint16(x), uint16(a), uint16(b), mode);
            else if(typeof(T) == typeof(int))
                return math.between(int32(x), int32(a), int32(b), mode);
            else if(typeof(T) == typeof(uint))
                return math.between(uint32(x), uint32(a), uint32(b), mode);
            else if(typeof(T) == typeof(long))
                return math.between(int64(x), int64(a), int64(b), mode);
            else if(typeof(T) == typeof(ulong))
                return math.between(uint64(x), uint64(a), uint64(b), mode);
            else if(typeof(T) == typeof(float))
                return math.between(float32(x), float32(a), float32(b), mode);
            else if(typeof(T) == typeof(double))
                return math.between(float64(x), float64(a), float64(b), mode);
            else            
                throw unsupported<T>();
        }

    }

}