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
        public static bool gt<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.gt(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                return math.gt(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                return math.gt(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.gt(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                return math.gt(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                return math.gt(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return math.gt(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                return fmath.gt(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                return fmath.gt(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }


    }


}