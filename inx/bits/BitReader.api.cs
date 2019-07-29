//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;


    public static class BitReader
    {
        /// <summary>
        /// Reads a span of primal bits
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="i0">The start bit position</param>
        /// <param name="i1">The end bit position</param>
        /// <typeparam name="T">The primal bit source type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBits<T>(T src, uint i0, uint i1)
            where T : struct
        {
            var size = Unsafe.SizeOf<T>();
            if(size == 1)
                return As.uint8(src).ReadBits(i0, i1);
            else if(size == 2)
                return As.uint16(src).ReadBits(i0, i1);
            else if(size == 3 || size == 4)
                return As.uint32(src).ReadBits(i0, i1);
            else if(size <= 8)
                return As.uint64(src).ReadBits(i0, i1);
            else
                throw unsupported<T>();
        }
    }

}