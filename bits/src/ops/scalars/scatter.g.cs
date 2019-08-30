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

    public static partial class gbits
    {
        /// <summary>
        /// Scatters contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The scatter spec</param>
        /// <typeparam name="T">The identifiying mask</typeparam>
        [MethodImpl(Inline)]
        public static T scatter<T>(in T src, in T mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.scatter(in uint8(in src), uint8(in mask)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.scatter(in uint16(in src), uint16(in mask)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.scatter(in uint32(in src), uint32(in mask)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.scatter(in uint64(in src), uint64(in mask)));
            else            
                throw unsupported<T>();
        }           



    }
}