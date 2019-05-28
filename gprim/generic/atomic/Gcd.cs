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
        public static T gcd<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return gcdI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return gcdU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return gcdI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return gcdU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return gcdI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return gcdU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return gcdI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return gcdU64(lhs,rhs);
            else if(typeof(T) == typeof(float))
                return gcdF32(lhs, rhs);
            else if(typeof(T) == typeof(double))
                return gcdF64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        static T gcdI8<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        static T gcdU8<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        static T gcdI16<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T gcdU16<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        static T gcdI32<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T gcdU32<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        static T gcdI64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        static T gcdU64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        static T gcdF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Max(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        static T gcdF64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(float64(lhs), float64(rhs))));

    }

}