//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;
    using static AsIn;


    partial class gmath
    {
        [MethodImpl(Inline)]
        static T andi<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.and(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.and(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.and(uint32(lhs), uint32(rhs)));
            else
                 return generic<T>(math.and(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T andu<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.and(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.and(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.and(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.and(uint64(lhs), uint64(rhs)));
        }

        /// <summary>
        /// Computes the bitwise AND between two primal integers
        /// </summary>
        /// <param name="lhs">The left integer</param>
        /// <param name="rhs">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || 
                typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return andu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || 
                typeof(T) == typeof(int) || typeof(T) == typeof(long))
                    return andi(lhs,rhs);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static ref T and<T>(in T lhs, in T rhs, ref T dst)
            where T : struct
        {
            dst = and(lhs,rhs);
            return ref dst;
        }

    }
}