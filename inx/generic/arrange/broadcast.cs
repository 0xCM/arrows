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
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static ref Vec128<T> broadcast<T>(in T src, out Vec128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(dinx.broadcast(in int8(in src), out Vec128<sbyte> x));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(dinx.broadcast(in uint8(in src), out Vec128<byte> x));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(dinx.broadcast(in int16(in src), out Vec128<short> x));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(dinx.broadcast(in uint16(in src), out Vec128<ushort> x));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(dinx.broadcast(in int32(in src), out Vec128<int> x));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(dinx.broadcast(in uint32(in src), out Vec128<uint> x));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(dinx.broadcast(in int64(in src), out Vec128<long> x));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(dinx.broadcast(in uint64(in src), out Vec128<ulong> x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(dinx.broadcast(in float32(in src), out Vec128<float> x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(dinx.broadcast(in float64(in src), out Vec128<double> x));
            else 
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<T> broadcast<T>(in T src, out Vec256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(dinx.broadcast(in int8(in src), out Vec256<sbyte> x));
            else if(typeof(T) == typeof(byte))
                dst = generic<T>(dinx.broadcast(in uint8(in src), out Vec256<byte> x));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(dinx.broadcast(in int16(in src), out Vec256<short> x));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(dinx.broadcast(in uint16(in src), out Vec256<ushort> x));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(dinx.broadcast(in int32(in src), out Vec256<int> x));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(dinx.broadcast(in uint32(in src), out Vec256<uint> x));
            else if(typeof(T) == typeof(long))
                dst = generic<T>(dinx.broadcast(in int64(in src), out Vec256<long> x));
            else if(typeof(T) == typeof(ulong))
                dst = generic<T>(dinx.broadcast(in uint64(in src), out Vec256<ulong> x));
            else if(typeof(T) == typeof(float))
                dst = generic<T>(dinx.broadcast(in float32(in src), out Vec256<float> x));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(dinx.broadcast(in float64(in src), out Vec256<double> x));
            else 
                throw unsupported<T>();
            return ref dst;
        }
    }

}