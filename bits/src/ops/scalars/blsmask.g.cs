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
        /// Sets all the lower bits of the result up to and including the lowest set bit in the source
        /// Equivalent to the composite operation (a-1) ^ a
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsmask<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsmask(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsmask(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsmask(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsmask(uint64(src)));
            else            
                throw unsupported<T>();
        }           


    }
}