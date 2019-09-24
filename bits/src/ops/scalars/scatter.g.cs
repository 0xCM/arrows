//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
       /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline)]
        public static T scatter<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.scatter(int8(src), int8(mask)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.scatter(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.scatter(int16(src), int16(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.scatter(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.scatter(int32(src), int32(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.scatter(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.scatter(int64(src), int64(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.scatter(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           


    }

}