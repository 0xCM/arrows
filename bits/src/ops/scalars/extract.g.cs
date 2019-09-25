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
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline)]
        public static T extract<T>(T lhs, byte start, byte length)
            where T : struct
        {
            if(typeof(T) == typeof(byte) 
                || typeof(T) == typeof(ushort) 
                || typeof(T) == typeof(uint) 
                || typeof(T) == typeof(ulong))
                    return extractu(lhs,start,length);
            else if(typeof(T) == typeof(sbyte) 
                || typeof(T) == typeof(short)
                || typeof(T) == typeof(int) 
                || typeof(T) == typeof(long))
                    return extracti(lhs,start,length);
            else
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        static T extracti<T>(T lhs, byte start, byte length)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.extract(int8(lhs), start, length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.extract(int16(lhs), start, length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.extract(int32(lhs), start, length));
            else 
                return generic<T>(Bits.extract(int64(lhs), start, length));
        }           

        [MethodImpl(Inline)]
        static T extractu<T>(T lhs, byte start, byte length)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(uint8(lhs), start, length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(uint16(lhs), start, length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(uint32(lhs), start, length));
            else 
                return generic<T>(Bits.extract(uint64(lhs), start, length));
        }           

    }
}