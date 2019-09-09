//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static AsIn;
    
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec256<T> blendv<T>(in Vec256<T> lhs, in Vec256<T> rhs, in Vec256<T> control)        
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.blendv(in int8(in lhs), in int8(in rhs), in int8(in control)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.blendv(in uint8(in lhs), in uint8(in rhs), in uint8(in control)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.blendv(in int16(in lhs), in int16(in rhs), in int16(in control)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.blendv(in uint16(in lhs), in uint16(in rhs), in uint16(in control)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.blendv(in int32(in lhs), in int32(in rhs), in int32(in control)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.blendv(in uint32(in lhs), in uint32(in rhs), in uint32(in control)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.blendv(in int64(in lhs), in int64(in rhs), in int64(in control)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.blendv(in uint64(in lhs), in uint64(in rhs), in uint64(in control)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.blendv(in float32(in lhs), in float32(in rhs), in float32(in control)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.blendv(in float64(in lhs), in float64(in rhs), in float64(in control)));
            else 
                throw unsupported<T>();
        }
    }

}