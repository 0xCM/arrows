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
        public static bool nonzero<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return math.nonzero(int8(ref src));
            else if(typeof(T) == typeof(byte))
                return math.nonzero(uint8(ref src));
            else if(typeof(T) == typeof(short))
                return math.nonzero(int16(ref src));
            else if(typeof(T) == typeof(ushort))
                return math.nonzero(uint16(ref src));
            else if(typeof(T) == typeof(int))
                return math.nonzero(int32(ref src));
            else if(typeof(T) == typeof(uint))
                return math.nonzero(uint32(ref src));
            else if(typeof(T) == typeof(long))
                return math.nonzero(int64(ref src));
            else if(typeof(T) == typeof(ulong))
                return math.nonzero(uint64(ref src));
            else if(typeof(T) == typeof(float))
                return math.nonzero(float32(ref src));
            else if(typeof(T) == typeof(double))
                return math.nonzero(float64(ref src));
            else            
                throw unsupported<T>();
        }

 

    }

}