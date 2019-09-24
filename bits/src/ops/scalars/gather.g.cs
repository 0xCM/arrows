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
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T gather<T>(T src, T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.gather(int8(src), int8(mask)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.gather(uint8(src), uint8(mask)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.gather(int16(src), int16(mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.gather(uint16(src), uint16(mask)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.gather(int32(src), int32(mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.gather(uint32(src), uint32(mask)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.gather(int64(src), int64(mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.gather(uint64(src), uint64(mask)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Extracts mask-identified bits from the source and deposits 
        /// the result to the contiguous low bits of a zero-initialied target 
        /// </summary>
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref T gather<T>(T src, T mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Bits.gather(int8(src), int8(mask), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.gather(uint8(src), uint8(mask), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.gather(int16(src), int16(mask), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.gather(uint16(src), uint16(mask), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.gather(int32(src), int32(mask), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.gather(uint32(src), uint32(mask), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.gather(int64(src), int64(mask), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.gather(uint64(src), uint64(mask), ref uint64(ref dst));
            else            
                throw unsupported<T>();
            return ref dst;
        }           


    }

}