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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T :  struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.sum(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(math.sum(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.sum(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.sum(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.sum(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.sum(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.sum(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.sum(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(math.sum(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(math.sum(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T :  struct
                => sum(src.ReadOnly());
        

    }
}
