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
        public static ref T or<T>(ref T lhs, T rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.or(ref int8(ref lhs), int8(rhs));
            else if(typeof(T) == typeof(byte))
                math.or(ref uint8(ref lhs), uint8(rhs));
            else if(typeof(T) == typeof(short))
                math.or(ref int16(ref lhs), int16(rhs));
            else if(typeof(T) == typeof(ushort))
                math.or(ref uint16(ref lhs), uint16(rhs));
            else if(typeof(T) == typeof(int))
                math.or(ref int32(ref lhs), int32(rhs));
            else if(typeof(T) == typeof(uint))
                math.or(ref uint32(ref lhs), uint32(rhs));
            else if(typeof(T) == typeof(long))
                math.or(ref int64(ref lhs), int64(rhs));
            else if(typeof(T) == typeof(ulong))
                math.or(ref uint64(ref lhs), uint64(rhs));
            else            
                throw unsupported<T>();
            return ref lhs;
        }


   }
}