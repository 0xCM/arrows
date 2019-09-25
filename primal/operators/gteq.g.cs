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
    using static AsIn;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(lhs) >= int8(rhs);
            else if(typeof(T) == typeof(byte))
                return uint8(lhs) >= uint8(rhs);
            else if(typeof(T) == typeof(short))
                return int16(lhs) >= int16(rhs);
            else if(typeof(T) == typeof(ushort))
                return uint16(lhs) >= uint16(rhs);
            else if(typeof(T) == typeof(int))
                return int32(lhs) >= int32(rhs);
            else if(typeof(T) == typeof(uint))
                return uint32(lhs) >= uint32(rhs);
            else if(typeof(T) == typeof(long))
                return int64(lhs) >= int64(rhs);
            else if(typeof(T) == typeof(ulong))
                return uint64(lhs) >= uint64(rhs);
            else if(typeof(T) == typeof(float))
                return float32(lhs) >= float32(rhs);
            else if(typeof(T) == typeof(double))
                return float64(lhs) >= float64(rhs);
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(in T lhs, in T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(in lhs) >= int8(in rhs);
            else if(typeof(T) == typeof(byte))
                return uint8(in lhs) >= uint8(in rhs);
            else if(typeof(T) == typeof(short))
                return int16(in lhs) >= int16(in rhs);
            else if(typeof(T) == typeof(ushort))
                return uint16(in lhs) >= uint16(in rhs);
            else if(typeof(T) == typeof(int))
                return int32(in lhs) >= int32(in rhs);
            else if(typeof(T) == typeof(uint))
                return uint32(in lhs) >= uint32(in rhs);
            else if(typeof(T) == typeof(long))
                return int64(in lhs) >= int64(in rhs);
            else if(typeof(T) == typeof(ulong))
                return uint64(in lhs) >= uint64(in rhs);
            else if(typeof(T) == typeof(float))
                return float32(in lhs) >= float32(in rhs);
            else if(typeof(T) == typeof(double))
                return float64(in lhs) >= float64(in rhs);
            else            
                throw unsupported<T>();
        }

    }

}