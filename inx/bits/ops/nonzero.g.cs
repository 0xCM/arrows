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

    partial class gbits
    {
        [MethodImpl(Inline)]
        public static bool nonzero<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.nonzero(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.nonzero(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return dinx.nonzero(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return dinx.nonzero(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return dinx.nonzero(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return dinx.nonzero(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return dinx.nonzero(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return dinx.nonzero(in uint64(in src));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nonzero<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.nonzero(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.nonzero(in uint8(in src));
            else if(typeof(T) == typeof(short))
                return dinx.nonzero(in int16(in src));
            else if(typeof(T) == typeof(ushort))
                return dinx.nonzero(in uint16(in src));
            else if(typeof(T) == typeof(int))
                return dinx.nonzero(in int32(in src));
            else if(typeof(T) == typeof(uint))
                return dinx.nonzero(in uint32(in src));
            else if(typeof(T) == typeof(long))
                return dinx.nonzero(in int64(in src));
            else if(typeof(T) == typeof(ulong))
                return dinx.nonzero(in uint64(in src));
            else 
                throw unsupported<T>();
        }         
    }

}