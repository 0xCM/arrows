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
        /// Isolate least set bit and complement, computed by dst := ~src | (src - 1),
        /// where all bits in the target are set except for the least set bit in the source
        /// For example, [11101010] |> blisc = [11111101]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T blsic<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsic(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsic(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsic(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsic(uint64(src)));
            else            
                throw unsupported<T>();
        }           


    }

}