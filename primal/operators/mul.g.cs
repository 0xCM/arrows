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
        /// <summary>
        /// Multiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T mul<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return mulu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                return muli(lhs,rhs);
            else if(typeof(T) == typeof(float) 
                ||  typeof(T) == typeof(double))
                return gfp.mul(lhs,rhs);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Multiplies two primal values
        /// </summary>
        /// <param name="lhs">The left value</param>
        /// <param name="rhs">The right value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T mul<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return ref mulu(ref lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                return ref muli(ref lhs,rhs);
            else if(typeof(T) == typeof(float) 
                ||  typeof(T) == typeof(double))
                return ref gfp.mul(ref lhs,rhs);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static T muli<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.mul(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.mul(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.mul(uint32(lhs), uint32(rhs)));
            else
                 return generic<T>(math.mul(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T mulu<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.mul(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mul(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mul(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.mul(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T muli<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.mul(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.mul(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.mul(ref uint32(ref lhs), uint32(rhs));
            else
                 math.mul(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T mulu<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                math.mul(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mul(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.mul(ref uint32(ref lhs), uint32(rhs));
            else 
                math.mul(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
