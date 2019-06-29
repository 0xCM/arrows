//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    
    using static As;
    using static AsInX;
    using static zfunc;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128Cmp<T> gt<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.gt(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.gt(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.gt(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dinx.gt(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dinx.gt(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256Cmp<T> gt<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.gt(in int8(in lhs), in int8(in rhs)).As<T>();
            else if(typeof(T) == typeof(short))
                return dinx.gt(in int16(in lhs), in int16(in rhs)).As<T>();
            else if(typeof(T) == typeof(int))
                return dinx.gt(in int32(in lhs), in int32(in rhs)).As<T>();
            else if(typeof(T) == typeof(long))
                return dinx.gt(in int64(in lhs), in int64(in rhs)).As<T>();
            else if(typeof(T) == typeof(float))
                return dinx.gt(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dinx.gt(in float64(in lhs), in float64(in rhs)).As<T>();
            else 
                throw unsupported<T>();
        }

    }
}