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
    using static AsInX;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static bool on<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.on(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.on(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return dinx.on(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return dinx.on(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return dinx.on(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return dinx.on(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return dinx.on(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return dinx.on(in uint64(in src));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool testc<T>(in Vec128<T> lhs,in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(in int8(in lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(in uint8(in lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                return dinx.testc(in int16(in lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(in uint16(in lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return dinx.testc(in int32(in lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(in uint32(in lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return dinx.testc(in int64(in lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(in uint64(in lhs), uint64(in rhs));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool testc<T>(in Vec256<T> lhs,in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.testc(in int8(in lhs), int8(in rhs));
            else if(typeof(T) == typeof(byte))
                return dinx.testc(in uint8(in lhs), uint8(in rhs));
            else if(typeof(T) == typeof(short))
                return dinx.testc(in int16(in lhs), int16(in rhs));
            else if(typeof(T) == typeof(ushort))
                return dinx.testc(in uint16(in lhs), uint16(in rhs));
            else if(typeof(T) == typeof(int))
                return dinx.testc(in int32(in lhs), int32(in rhs));
            else if(typeof(T) == typeof(uint))
                return dinx.testc(in uint32(in lhs), uint32(in rhs));
            else if(typeof(T) == typeof(long))
                return dinx.testc(in int64(in lhs), int64(in rhs));
            else if(typeof(T) == typeof(ulong))
                return dinx.testc(in uint64(in lhs), uint64(in rhs));
            else 
                throw unsupported<T>();
        }

    }

}