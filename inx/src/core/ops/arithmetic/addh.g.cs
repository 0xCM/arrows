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
    
    using static zfunc;

    using static As;
    

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<T> addh<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.hadd(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.hadd(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.hadd(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.hadd(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> addh<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.hadd(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.hadd(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.hadd(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.hadd(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }
        
   }
}