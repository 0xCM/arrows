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
        public static T inc<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(int8(src) + 1);
            else if(typeof(T) == typeof(byte))
                return generic<T>(uint8(src) + 1);
            else if(typeof(T) == typeof(short))
                return generic<T>(int16(src) + 1);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(uint16(src) + 1);
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) + 1);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) + 1);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) + 1);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) + 1);
            else if(typeof(T) == typeof(float))
                return generic<T>(float32(src) + 1);
            else if(typeof(T) == typeof(double))
                return generic<T>(float64(src) + 1);
            else            
                 throw unsupported<T>();                
       }           

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.inc(ref int8(ref src));
            else if(typeof(T) == typeof(byte))
                math.inc(ref uint8(ref src));
            else if(typeof(T) == typeof(short))
                math.inc(ref int16(ref src));
            else if(typeof(T) == typeof(ushort))
                math.inc(ref uint16(ref src));
            else if(typeof(T) == typeof(int))
                math.inc(ref int32(ref src));
            else if(typeof(T) == typeof(uint))
                math.inc(ref uint32(ref src));
            else if(typeof(T) == typeof(long))
                math.inc(ref int64(ref src));
            else if(typeof(T) == typeof(ulong))
                math.inc(ref uint64(ref src));
            else if(typeof(T) == typeof(float))
                math.inc(ref float32(ref src));
            else if(typeof(T) == typeof(double))
                math.inc(ref float64(ref src));
            else            
                 throw unsupported<T>();                

            return ref src;
        }           

    }
}