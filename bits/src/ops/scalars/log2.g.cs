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
        /// Computes floor(log(src,2))
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static T log2<T>(in T src)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(Bits.log2(AsIn.uint8(in asRef(in src))));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(Bits.log2(AsIn.uint16(in asRef(in src))));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(Bits.log2(AsIn.uint32(in asRef(in src))));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(Bits.log2(AsIn.uint64(in asRef(in src))));
            else 
                throw unsupported<T>();
        }

    }

}