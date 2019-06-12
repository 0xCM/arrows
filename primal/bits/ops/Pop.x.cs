//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    
    using static zfunc;

    partial class BitX
    {
        public static ulong PopCount(this ReadOnlySpan<Bit> src)
        {
            var count = 0ul;
            for(var i=0; i<src.Length; i++)
                if(src[i]) count++;
            return count;
        }

        [MethodImpl(Inline)]        
        public static ulong PopCount(this Span<Bit> src)
            => src.ReadOnly().PopCount();

               
        /// <summary>
        /// Converts a bit to a byte
        /// </summary>
        /// <param name="src">The source value to convert</param>
        [MethodImpl(Inline)]   
        public static byte ToByte(this Bit src)
            => src ? (byte)1 : (byte)0;

        [MethodImpl(Inline)]   
        public static ulong PopCount(this Span<byte> src)
            => Bits.pop(src);
    }

}