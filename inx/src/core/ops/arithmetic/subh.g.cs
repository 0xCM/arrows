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
        public static Vec128<T> subh<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.subh(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.subh(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.subh(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.subh(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();

        }

        [MethodImpl(Inline)]
        public static Vec256<T> subh<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.subh(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.subh(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.subh(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.subh(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();

        }

        [MethodImpl(Inline)]
        public static void subh<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                dinx.subh(in int16(in lhs), in int16(in rhs), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.subh(in int32(in lhs), in int32(in rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.subh(in float32(in lhs), in float32(in rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.subh(in float64(in lhs), in float64(in rhs), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }
        
        [MethodImpl(Inline)]
        public static void subh<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                dinx.subh(in int16(in lhs), in int16(in rhs), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.subh(in int32(in lhs), in int32(in rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.subh(in float32(in lhs), in float32(in rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.subh(in float64(in lhs), in float64(in rhs), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }        
   }
}