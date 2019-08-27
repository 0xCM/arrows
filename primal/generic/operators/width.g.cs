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
        public static ref T width<S,T>(S lhs, S rhs, out T dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(sbyte))
                dst = convert<T>(math.width(int8(rhs), int8(lhs)));
            else if(typeof(S) == typeof(byte))
                dst = convert<T>(math.width(uint8(rhs), uint8(lhs)));
            else if(typeof(S) == typeof(short))
                dst = convert<T>(math.width(int16(rhs), int16(lhs)));
            else if(typeof(S) == typeof(ushort))
                dst = convert<T>(math.width(uint16(rhs), uint16(lhs)));
            else if(typeof(S) == typeof(int))
                dst = convert<T>(math.width(int32(rhs), int32(lhs)));
            else if(typeof(S) == typeof(uint))
                dst = convert<T>(math.width(uint32(lhs), uint32(rhs)));
            else if(typeof(S) == typeof(long))
                dst = convert<T>(math.width(int64(rhs), int64(lhs)));
            else if(typeof(S) == typeof(ulong))
                dst = convert<T>(math.width(uint64(rhs), uint64(lhs)));
            else if(typeof(S) == typeof(float))
                dst = convert<T>(math.width(float32(rhs), float32(lhs)));
            else if(typeof(S) == typeof(double))
                dst = convert<T>(math.width(float64(rhs), float64(lhs)));
            else            
                throw unsupported<T>();
            return ref dst;
        } 
    }

}