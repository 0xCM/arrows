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
    using System.Diagnostics;
    
    using static zfunc;    
    using static As;

    partial class euclid
    {

        [MethodImpl(Inline)]
        public static bool divides<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return divides(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                return divides(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                return divides(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                return divides(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                return divides(int32(lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                return divides(uint32(lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                return divides(int64(lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return divides(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                return divides(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                return divides(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bool divides(sbyte lhs, sbyte rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(byte lhs, byte rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(short lhs, short rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(ushort lhs, ushort rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(int lhs, int rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(uint lhs, uint rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(long lhs, long rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(ulong lhs, ulong rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(float lhs, float rhs)
            => rhs % lhs == 0;

        [MethodImpl(Inline)]
        static bool divides(double lhs, double rhs)
            => rhs % lhs == 0;
    }
}