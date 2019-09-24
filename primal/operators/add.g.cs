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

        /// <summary>
        /// Adds two primal integers
        /// </summary>
        /// <param name="lhs">The left integer</param>
        /// <param name="rhs">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static T iadd<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(math.add(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.add(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.add(uint32(lhs), uint32(rhs)));
            else
                 return generic<T>(math.add(int64(lhs), int64(rhs)));
        }

        /// <summary>
        /// Adds two primal integers
        /// </summary>
        /// <param name="lhs">The left integer</param>
        /// <param name="rhs">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static T uadd<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.add(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.add(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.add(uint32(lhs), uint32(rhs)));
            else 
                return generic<T>(math.add(uint64(lhs), uint64(rhs)));
        }

        /// <summary>
        /// Adds two primal integers
        /// </summary>
        /// <param name="lhs">The left integer</param>
        /// <param name="rhs">The right integer</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T add<T>(T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || 
                typeof(T) == typeof(uint) || typeof(T) == typeof(ulong))
                    return uadd(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) || typeof(T) == typeof(short) || 
                typeof(T) == typeof(int) || typeof(T) == typeof(long))
                    return iadd(lhs,rhs);
            else if(typeof(T) == typeof(float) || typeof(T) == typeof(double))
                return gfp.fadd(lhs,rhs);
            else
                throw unsupported<T>();
        }

                    
        [MethodImpl(Inline)]
        public static ref T add<T>(ref T lhs, in T rhs)
            where T : struct
        {                        
            lhs = add(lhs,rhs);
            return ref lhs;
        }


    }
}