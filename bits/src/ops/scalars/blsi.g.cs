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
        /// Extracts the lowest set bit from the source, if any, and is logically equivalent to
        /// the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsi<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsi(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsi(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsi(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsi(uint64(src)));
            else            
                throw unsupported<T>();
        }           


    }

}