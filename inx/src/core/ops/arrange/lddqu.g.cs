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
    using static AsIn;

    using static zfunc;
    
    partial class ginx
    {
        
        [MethodImpl(Inline)]
        public static ref Vec128<T> lddqu<T>(in T src, ref Vec128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dinx.lddqu(in int8(in src), out int8(in dst));
            else if(typeof(T) == typeof(byte))
                dinx.lddqu(in uint8(in src), out uint8(in dst));
            else if(typeof(T) == typeof(short))
                dinx.lddqu(in int16(in src), out int16(in dst));
            else if(typeof(T) == typeof(ushort))
                dinx.lddqu(in uint16(in src), out uint16(in dst));
            else if(typeof(T) == typeof(int))
                dinx.lddqu(in int32(in src), out int32(in dst));
            else if(typeof(T) == typeof(uint))
                dinx.lddqu(in uint32(in src), out uint32(in dst));
            else if(typeof(T) == typeof(long))
                dinx.lddqu(in int64(in src), out int64(in dst));
            else if(typeof(T) == typeof(ulong))
                dinx.lddqu(in uint64(in src), out uint64(in dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<T> lddqu<T>(in T src, ref Vec256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dinx.lddqu(in int8(in src), out int8(in dst));
            else if(typeof(T) == typeof(byte))
                dinx.lddqu(in uint8(in src), out uint8(in dst));
            else if(typeof(T) == typeof(short))
                dinx.lddqu(in int16(in src), out int16(in dst));
            else if(typeof(T) == typeof(ushort))
                dinx.lddqu(in uint16(in src), out uint16(in dst));
            else if(typeof(T) == typeof(int))
                dinx.lddqu(in int32(in src), out int32(in dst));
            else if(typeof(T) == typeof(uint))
                dinx.lddqu(in uint32(in src), out uint32(in dst));
            else if(typeof(T) == typeof(long))
                dinx.lddqu(in int64(in src), out int64(in dst));
            else if(typeof(T) == typeof(ulong))
                dinx.lddqu(in uint64(in src), out uint64(in dst));
            else
                throw unsupported<T>();
            return ref dst;
        }

    }

}
