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
        /// Extracts a sequence of mask-identifed bits from the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T extract<T>(T src, T mask)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Extracts a contiguous range of bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="start">The bit posiion within the source where extraction should benin</param>
        /// <param name="length">The number of bits that should be extracted</param>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.Int)]
        public static T extract<T>(in T lhs, in byte start, in byte length)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.extract(in int8(in lhs), in start, in length));
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.extract(in uint8(in lhs), in start, in length));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.extract(in int16(in lhs), in start, in length));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.extract(in uint16(in lhs), in start, in length));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.extract(in int32(in lhs), in start, in length));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.extract(in uint32(in lhs), in start, in length));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.extract(in int64(in lhs), in start, in length));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.extract(in uint64(in lhs), in start, in length));
            else            
                throw unsupported<T>();
        }           
    }
}