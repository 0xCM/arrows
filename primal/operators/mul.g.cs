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
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.mul(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.mul(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.mul(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mul(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.mul(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mul(uint32(lhs), uint32(rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.mul(int64(lhs), int64(rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.mul(uint64(lhs), uint64(rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.mul(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.mul(float64(lhs), float64(rhs)));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.mul(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.mul(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.mul(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mul(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.mul(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.mul(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.mul(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.mul(ref uint64(ref lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                math.mul(ref float32(ref lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                math.mul(ref float64(ref lhs), float64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }


    }
}
