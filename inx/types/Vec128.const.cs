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
    using static AsInX;

    public static class Vec128C
    {
        static readonly Vec128<byte> OneU8 = Vec128.define((byte)1);

        static readonly Vec128<sbyte> OneI8 = Vec128.define((sbyte)1);

        static readonly Vec128<short> OneI16 = Vec128.define((short)1);

        static readonly Vec128<ushort> OneU16 = Vec128.define((ushort)1);

        static readonly Vec128<int> OneI32 = Vec128.define(1);

        static readonly Vec128<uint> OneU32 = Vec128.define(1u);

        static readonly Vec128<long> OneI64 = Vec128.define(1L);

        static readonly Vec128<ulong> OneU64 = Vec128.define(1ul);

        static readonly Vec128<float> OneF32 = Vec128.define(1f);

        static readonly Vec128<double> OneF64 = Vec128.define(1d);


        [MethodImpl(Inline)]
         public static Vec128<T> one<T>()
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(in OneI8);
            else if(typeof(T) == typeof(byte))
                return generic<T>(in OneU8);
            else if(typeof(T) == typeof(short))
                return generic<T>(in OneI16);
            else if(typeof(T) == typeof(ushort))
                return generic<T>(in OneU16);
            else if(typeof(T) == typeof(int))
                return generic<T>(in OneI32);
            else if(typeof(T) == typeof(uint))
                return generic<T>(in OneU32);
            else if(typeof(T) == typeof(long))
                return generic<T>(in OneI64);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(in OneU64);
            else if(typeof(T) == typeof(float))
                return generic<T>(in OneF32);
            else if(typeof(T) == typeof(double))
                return generic<T>(in OneF64);
            else
                throw unsupported<T>();

        }

    }

 
}