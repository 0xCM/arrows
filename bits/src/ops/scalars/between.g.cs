//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {

        /// <summary>
        /// Extracts a contiguous range of bits from a primal source inclusively between two index positions
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="rhs">The left bit position</param>
        /// <param name="dst">The right bit position</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T between<T>(in T src, BitPos p0, BitPos p1)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(Bits.between(in int8(in src), p0, p1));
            else if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.between(in uint8(in src), p0, p1));
            else if(typeof(T) == typeof(short))
                 return generic<T>(Bits.between(in int16(in src), p0, p1));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.between(in uint16(in src), p0, p1));
            else if(typeof(T) == typeof(int))
                 return generic<T>(Bits.between(in int32(in src), p0, p1));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.between(in uint32(in src), p0, p1));
            else if(typeof(T) == typeof(long))
                 return generic<T>(Bits.between(in int64(in src), p0, p1));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.between(in uint64(in src), p0, p1));
            else if(typeof(T) == typeof(float))
                 return generic<T>(Bits.between(in float32(in src), p0, p1));
            else if(typeof(T) == typeof(double))
                 return generic<T>(Bits.between(in float64(in src), p0, p1));
            else            
                throw unsupported<T>();
        }
    
    }

}