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
        public static Quorem<T> quorem<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.quorem(int8(lhs), int8(rhs)).As<T>();
            else if(typeof(T) == typeof(byte))
                return math.quorem(uint8(lhs), uint8(rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return math.quorem(int16(lhs), int16(rhs)).As<T>();
            else if(typeof(T) == typeof(ushort))
                return math.quorem(uint16(lhs), uint16(rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return math.quorem(int32(lhs), int32(rhs)).As<T>();
            else if(typeof(T) == typeof(uint))
                return math.quorem(uint32(lhs), uint32(rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return math.quorem(int64(lhs), int64(rhs)).As<T>();
            else if(typeof(T) == typeof(ulong))
                return math.quorem(uint64(lhs), uint64(rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return math.quorem(float32(lhs), float32(rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return math.quorem(float64(lhs), float64(rhs)).As<T>();
            else            
                throw unsupported<T>();
        }

    }

}