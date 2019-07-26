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

    public static partial class gbits
    {


        /// <summary>
        /// Returns the position of the least on bit in the source
        /// </summary>
        /// <param name="src">The source vale</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static T lopos<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.lopos(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.lopos(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.lopos(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.lopos(uint64(src)));
            else            
                throw unsupported<T>();
        }           

    }

}