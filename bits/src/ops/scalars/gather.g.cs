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
        public static T gather<T>(in T src, in T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Bits.gather(in int8(in src), in int8(in mask)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(Bits.gather(in uint8(in src), in uint8(in mask)));
            else if(typeof(T) == typeof(short))
                return generic<T>(Bits.gather(in int16(in src), in int16(in mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.gather(in uint16(in src), in uint16(in mask)));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.gather(in int32(in src), in int32(in mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.gather(in uint32(in src), in uint32(in mask)));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.gather(in int64(in src), in int64(in mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.gather(in uint64(in src), in uint64(in mask)));
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
        public static ref T gather<T>(in T src, in T mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Bits.gather(in int8(in src), in int8(in mask), ref int8(ref dst));
            else if(typeof(T) == typeof(byte))
                Bits.gather(in uint8(in src), in uint8(in mask), ref uint8(ref dst));
            else if(typeof(T) == typeof(short))
                Bits.gather(in int16(in src), in int16(in mask), ref int16(ref dst));
            else if(typeof(T) == typeof(ushort))
                Bits.gather(in uint16(in src), in uint16(in mask), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                Bits.gather(in int32(in src), in int32(in mask), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                Bits.gather(in uint32(in src), in uint32(in mask), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                Bits.gather(in int64(in src), in int64(in mask), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                Bits.gather(in uint64(in src), in uint64(in mask), ref uint64(ref dst));
            else            
                throw unsupported<T>();
            return ref dst;
        }           


    }

}