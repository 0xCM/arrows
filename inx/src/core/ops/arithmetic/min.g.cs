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
        public static Vector128<T> min<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.min(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.min(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.min(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.min(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.min(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.min(uint32(lhs), uint32(rhs)));
            else 
                throw unsupported<T>();

        }
         
       [MethodImpl(Inline)]
       public static Vector256<T> min<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.min(int8(lhs), int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.min(uint8(lhs), uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.min(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.min(uint16(lhs), uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.min(int32(lhs), int32(rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.min(uint32(lhs), uint32(rhs)));
            else 
                throw unsupported<T>();
        }        
    }
}