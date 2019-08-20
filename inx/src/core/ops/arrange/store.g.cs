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
    

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec128<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(in uint64(in src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(in float32(in src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(in float64(in src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static unsafe void store<T>(in Vec256<T> src, ref T dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                vstore(in int8(in src), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                vstore(in uint8(in src), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                vstore(in int16(in src), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                vstore(in uint16(in src), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                vstore(in int32(in src), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                vstore(in uint32(in src), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                vstore(in int64(in src), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                vstore(in uint64(in src), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                vstore(in float32(in src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                vstore(in float64(in src), ref float64(ref dst));
            else 
                throw unsupported<T>();
        }
    }
}