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
    using static zfunc;
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vec128<T> mul<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.mul(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.mul(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vec128<T> mul<S,T>(in Vec128<S> lhs, in Vec128<S> rhs)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<T>(dinx.mul(in int32(in lhs), in int32(in rhs)));
            else if(typeof(S) == typeof(uint))
                return generic<T>(dinx.mul(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(S) == typeof(float))
                return generic<T>(dinx.mul(in float32(in lhs), in float32(in rhs)));
            else if(typeof(S) == typeof(double))
                return generic<T>(dinx.mul(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<S>();

        }

        [MethodImpl(Inline)]
        public static Vec256<T> mul<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.mul(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.mul(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> mul<S,T>(in Vec256<S> lhs, in Vec256<S> rhs)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<T>(dinx.mul(in int32(in lhs), in int32(in rhs)));
            else if(typeof(S) == typeof(uint))
                return generic<T>(dinx.mul(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(S) == typeof(float))
                return generic<T>(dinx.mul(in float32(in lhs), in float32(in rhs)));
            else if(typeof(S) == typeof(double))
                return generic<T>(dinx.mul(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<S>();

        }

        [MethodImpl(Inline)]
        public static ref Vec128<S> mul<S,T>(in Vec128<T> lhs, in Vec128<T> rhs, ref Vec128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(T) == typeof(int))
                dst = generic<S>(dinx.mul(in int32(in lhs), in int32(in rhs)));
            else if (typeof(T) == typeof(uint))
                dst = generic<S>(dinx.mul(in uint32(in lhs), in uint32(in rhs)));
            else if (typeof(T) == typeof(float))
                dst = generic<S>(dinx.mul(in float32(in lhs), in float32(in rhs)));
            else if (typeof(T) == typeof(double))
                dst = generic<S>(dinx.mul(in float64(in lhs), in float64(in rhs)));
            else
                throw unsupported<T>();
            
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe Span<T> mul<S,T>(in Vec128<S> lhs, in Vec128<S> rhs, Span<T> dst)
            where S : struct
            where T : struct
        {
                if(typeof(T) == typeof(int))
                    dinx.mul(int32(lhs), int32(rhs), ref int64(ref head(dst)));
                else if(typeof(T) == typeof(uint))
                    dinx.mul(uint32(lhs), uint32(rhs), ref uint64(ref head(dst)));
                else if(typeof(T) == typeof(float))
                    dinx.mul(float32(lhs), float32(rhs), ref float32(ref head(dst)));
                else if(typeof(T) == typeof(double))
                    dinx.mul(float64(lhs), float64(rhs), ref float64(ref head(dst)));
                else
                    throw unsupported<T>();
            return dst;
        }
 


    }
}