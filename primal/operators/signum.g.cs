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
        /// Computes the sign of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Sign signum<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.signum(int8(src));
            else if(typeof(T) == typeof(byte))
                return math.signum(uint8(src));
            else if(typeof(T) == typeof(short))
                return math.signum(int16(src));
            else if(typeof(T) == typeof(ushort))
                return math.signum(uint16(src));
            else if(typeof(T) == typeof(int))
                return math.signum(int32(src));
            else if(typeof(T) == typeof(uint))
                return math.signum(uint32(src));
            else if(typeof(T) == typeof(long))
                return math.signum(int64(src));
            else if(typeof(T) == typeof(ulong))
                return math.signum(uint64(src));
            else if(typeof(T) == typeof(float))
                return math.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return math.signum(float64(src));
            else            
                throw unsupported<T>();
        }           
    }

}