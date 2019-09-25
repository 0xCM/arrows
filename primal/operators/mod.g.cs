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
        public static T mod<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return modu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                return modi(lhs,rhs);
            else if(typeof(T) == typeof(float) 
                ||  typeof(T) == typeof(double))
                return gfp.mod(lhs,rhs);
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
        public static ref T mod<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return ref modu(ref lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                return ref modi(ref lhs,rhs);
            else if(typeof(T) == typeof(float) 
                ||  typeof(T) == typeof(double))
                return ref gfp.mod(ref lhs,rhs);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static T modi<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.mod(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.mod(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.mod(uint32(lhs), uint32(rhs)));
            else
                 return generic<T>(math.mod(int64(lhs), int64(rhs)));
        }

        [MethodImpl(Inline)]
        static T modu<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.mod(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.mod(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.mod(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.mod(uint64(lhs), uint64(rhs)));
        }

        [MethodImpl(Inline)]
        static ref T modi<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 math.mod(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 math.mod(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 math.mod(ref uint32(ref lhs), uint32(rhs));
            else
                 math.mod(ref int64(ref lhs), int64(rhs));
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref T modu<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                math.mod(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                math.mod(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                math.mod(ref uint32(ref lhs), uint32(rhs));
            else 
                math.mod(ref uint64(ref lhs), uint64(rhs));
            return ref lhs;
        }
    }
}
