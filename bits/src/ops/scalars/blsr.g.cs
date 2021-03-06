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
        /// Copies all bits from the source to the result, and disable the bit in the 
        /// result that corresponds to the lowest set bit in a. 
        /// Exquivalent to the composite operation (src - 1) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsr<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.blsr(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.blsr(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.blsr(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.blsr(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        

 
    }

}