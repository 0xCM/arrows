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
        public static bool divides<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dividesI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return dividesU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return dividesI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return dividesU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return dividesI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return dividesU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return dividesI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return dividesU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return dividesF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return dividesF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(Inline)]
        static bool dividesI8<T>(T lhs, T rhs)
            => int8(rhs) % int8(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU8<T>(T lhs, T rhs)
            => uint8(rhs) % uint8(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI16<T>(T lhs, T rhs)
            => int16(rhs) % int16(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU16<T>(T lhs, T rhs)
            => uint16(rhs) % uint16(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI32<T>(T lhs, T rhs)
            => int32(rhs) % int32(lhs) == 0;
        
        [MethodImpl(Inline)]
        static bool dividesU32<T>(T lhs, T rhs)
            => uint32(rhs) % uint32(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI64<T>(T lhs, T rhs)
            => int64(rhs) % int64(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU64<T>(T lhs, T rhs)
            => uint64(rhs) % uint64(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesF32<T>(T lhs, T rhs)
            => float32(rhs) % float32(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesF64<T>(T lhs, T rhs)
            => float64(rhs) % float64(lhs) == 0;
    }
}


