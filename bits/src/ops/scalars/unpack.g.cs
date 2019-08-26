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
        /// Populates a target span with bits from the source
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The target span</param>
        [MethodImpl(Inline)]
        public static Span<Bit> unpack<T>(in T src, out Span<Bit> dst)
            where T : struct
        {
            if(typeof(T) == typeof(byte))
                return Bits.unpack(in uint8(in src), out dst);
            else if(typeof(T) == typeof(ushort))
                return Bits.unpack(in uint16(in src), out dst);
            else if(typeof(T) == typeof(uint))
                return Bits.unpack(in uint32(in src), out dst);
            else if(typeof(T) == typeof(ulong))
                return Bits.unpack(in uint64(in src), out dst);
            else            
                throw unsupported<T>();
        }           


    }

}