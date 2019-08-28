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
    

    partial class gbits
    {

        /// <summary>
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline)]
        public static int movemask<T>(in Vec128<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return Bits.movemask(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return Bits.movemask(in uint8(in src));
            else if(typeof(T) == typeof(float))
                return Bits.movemask(in float32(in src));
            else if(typeof(T) == typeof(double))
                return Bits.movemask(in float64(in src));
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline)]
        public static int movemask<T>(in Vec256<T> src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return Bits.movemask(in int8(in src));
            else if(typeof(T) == typeof(byte))
                return Bits.movemask(in uint8(in src));
            else if(typeof(T) == typeof(float))
                return Bits.movemask(in float32(in src));
            else if(typeof(T) == typeof(double))
                return Bits.movemask(in float64(in src));
            else 
                throw unsupported<T>();
        }
    }
}