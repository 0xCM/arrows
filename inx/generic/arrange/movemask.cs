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
        public static int movemask<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.movemask(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.movemask(in uint8(in src));
            else if(typeof(T) == typeof(float))
                return dinx.movemask(in float32(in src));
            else if(typeof(T) == typeof(double))
                return dinx.movemask(in float64(in src));
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static int movemask<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.movemask(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return dinx.movemask(in uint8(in src));
            else if(typeof(T) == typeof(float))
                return dinx.movemask(in float32(in src));
            else if(typeof(T) == typeof(double))
                return dinx.movemask(in float64(in src));
            else throw unsupported<T>();
        }


    }
}