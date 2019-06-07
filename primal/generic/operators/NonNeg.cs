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
        public static bool nonneg<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.nonneg(int8(ref src));
            else if(typeof(T) == typeof(byte))
                return true;
            else if(typeof(T) == typeof(short))
                return math.nonneg(int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return true;
            else if(typeof(T) == typeof(int))
                return math.nonneg(int32(ref src));
            else if(typeof(T) == typeof(uint))
                return true;
            else if(typeof(T) == typeof(long))
                return math.nonneg(int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return true;
            else if(typeof(T) == typeof(float))
                return math.nonneg(float32(ref src));
            else if(typeof(T) == typeof(double))
                return math.nonneg(float64(ref src));
            else            
                throw unsupported<T>();
        }
    }
}